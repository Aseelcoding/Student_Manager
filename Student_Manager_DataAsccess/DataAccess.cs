using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager_DataAsccess
{
    public class DataAccess
    {

        //Staff's DataAccess Functions:
        static public bool IsStaffExist(ref int StaffID,ref string Name,string  UserName,string Password)
        {
            bool IsFound=false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"select StaffID,Name from Staff
                            where UserName=@UserName and Password =@Password;
                                                                ";

            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            connection.Open();
            try
            {
                SqlDataReader reder = cmd.ExecuteReader();
                if (reder.Read())
                {
                    Name = reder["Name"].ToString();
                    int.TryParse(reder["StaffID"].ToString(), out StaffID);
                    IsFound = true;
                }
            } 
            catch(Exception ex)
            {

                throw new Exception("Failed to check if the staff exist.", ex);
            }
            finally { connection.Close(); }

            return IsFound;
        }
        static public DataTable GetAllStaff()
        {
            DataTable dtStaff = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"select * from Staff;";

            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dtStaff.Load(reader);

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get all staff.", ex);


            }
            finally { connection.Close(); }

            return dtStaff;

        }
        static public bool AddNewStaff(string StaffName,string Username,string Password) 
        {
            bool IsAdded = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"INSERT INTO [dbo].[Staff]
           ([Name]
           ,[UserName]
           ,[Password])
     VALUES
           (@StaffName
           ,@Username
           ,@Password);";

            SqlCommand cmd=new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsAdded = true;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add staff", ex);
            }
            finally
            {
                connection.Close();
            }


            return IsAdded;
        }
        static public bool DeleteStaffByID(int StaffID) 
        {
            bool IsDeleted = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"Delete from Staff 
                            where StaffID=@StaffID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StaffID", StaffID);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0) 
                {
                    IsDeleted = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to delete staff.", ex);

            }
            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }
        //Student's DataAccess Functions:
        static public DataTable GetAllStudents() 
        {
            DataTable dtStudents= new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string qurey = @"select S.StudentID,
		            S.Name as StudentName,
		            S.DateOfBirth,
		            S.Address,
                    S.ImagePath,
                    S.ContactID,
		            P.Name as ProgramName,
		            P.Level
		        from Student as S
		        inner join Program as P
		        on S.ProgramID=P.ProgramID
";

            SqlCommand cmd = new SqlCommand(qurey, connection);

            try
            {
                connection.Open();

                SqlDataReader reader= cmd.ExecuteReader();

                dtStudents.Load(reader);

            }

            catch (Exception ex)
            {
                throw new Exception("Failed to get students.", ex);

            }
            finally 
            {
                connection.Close();
           
            }
            return dtStudents;
        }
       
        static public bool AddNewStudent(ref int StudentID,string Name, string Email,string Phone 
            ,string ProgramName,string Level,DateTime DateOfBirth ,string Address,string ImagePath)
        {
            bool IsAdded = false;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSeetings.connectionString);

            try
            {
                connection.Open();

             
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int ProgramID = GetProgramID(ProgramName, Level);

                    if (ProgramID == -1)
                    {
                        transaction.Rollback();
                        return false;
                    }

                   
                    string contactQuery = @"
                INSERT INTO [dbo].[Contact]
                    ([Phone], [Email])
                VALUES
                    (@Phone, @Email);

                SELECT SCOPE_IDENTITY();";

                    int ContactID;

                    using (SqlCommand cmdContact =
                        new SqlCommand(contactQuery, connection, transaction))
                    {
                        cmdContact.Parameters.AddWithValue("@Phone", Phone);
                        cmdContact.Parameters.AddWithValue("@Email", Email);

                        ContactID = Convert.ToInt32(
                            cmdContact.ExecuteScalar());
                    }

                    string studentQuery = @"
                INSERT INTO [dbo].[Student]
                    ([Name],
                     [ProgramID],
                     [DateOfBirth],
                     [ContactID],
                     [Address],
                     [ImagePath])
                VALUES
                    (@Name,
                     @ProgramID,
                     @DateOfBirth,
                     @ContactID,
                     @Address,
                     @ImagePath);

                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdStudent =
                        new SqlCommand(studentQuery, connection, transaction))
                    {
                        cmdStudent.Parameters.AddWithValue("@Name", Name);
                        cmdStudent.Parameters.AddWithValue("@ProgramID", ProgramID);
                        cmdStudent.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmdStudent.Parameters.AddWithValue("@ContactID", ContactID);
                        cmdStudent.Parameters.AddWithValue("@Address", Address);
                        cmdStudent.Parameters.AddWithValue("@ImagePath", ImagePath);

                        StudentID = Convert.ToInt32(
                            cmdStudent.ExecuteScalar());
                    }

                    transaction.Commit();

                    IsAdded = true;
                }
                catch
                {
                  
                    transaction.Rollback();

                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add new Student.",ex);
            }
            finally
            {
                connection.Close();
            }

            return IsAdded;

        }
        static public bool GetStudentByID(int StudentID,ref string Name,ref string Level,ref string ProgramName,ref DateTime DateOfBirth,ref string Phone,ref string Email,ref string Address,ref string ImagePath) 
        {
            bool isFound = false;

            string query = @"select S.StudentID,
		            S.Name as StudentName,
		            S.DateOfBirth,
		            S.Address,
                    S.ImagePath,
					C.Email,
					C.Phone,
		            P.Name as ProgramName,
		            P.Level
		        from Student as S
		        inner join Program as P
		        on S.ProgramID=P.ProgramID
				inner join Contact as C
				on S.ContactID=C.ContactID

				where S.StudentID=@StudentID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);

                    try
                    {
                        connection.Open();

                       
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                             reader.Read();
                                isFound = true;

                                //
                               Name=reader["StudentName"].ToString();
                                Level = reader["Level"].ToString();
                                ProgramName = reader["ProgramName"].ToString();
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Phone = reader["Phone"].ToString();
                                Email = reader["Email"].ToString();
                                if(reader["Address"]!=DBNull.Value)
                                Address = reader["Address"].ToString();

                                ImagePath = reader["ImagePath"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed to get student by id.", ex);
                    }
                    finally { connection.Close(); }
                }
            }

            return isFound;
        }
        static public bool UpdateStudentByID(int StudentID,  string Name,  string Level,  string ProgramName,  DateTime DateOfBirth,  string Phone,  string Email,  string Address,  string ImagePath)
        {
            int ContactID= GetContactID(Phone, Email);
            int ProgramID= GetProgramID(ProgramName, Level);

            bool isUpdated = false;

       
            string updateContactQuery = @"UPDATE Contact 
                                  SET Phone = @Phone, Email = @Email 
                                  WHERE ContactID = @ContactID";
            
         
            string updateStudentQuery = @"UPDATE Student 
                                  SET Name = @Name, 
                                      ProgramID = @ProgramID, 
                                      DateOfBirth = @DateOfBirth, 
                                      Address = @Address, 
                                      ImagePath = @ImagePath 
                                  WHERE StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString))
            {
                try
                {
                    connection.Open();

                   
                    using (SqlCommand cmdContact = new SqlCommand(updateContactQuery, connection))
                    {
                        cmdContact.Parameters.AddWithValue("@Phone", Phone);
                        cmdContact.Parameters.AddWithValue("@Email", Email);
                        cmdContact.Parameters.AddWithValue("@ContactID", ContactID);

                        cmdContact.ExecuteNonQuery();
                    }


                
                    using (SqlCommand cmdStudent = new SqlCommand(updateStudentQuery, connection))
                    {
                        cmdStudent.Parameters.AddWithValue("@StudentID", StudentID);
                        cmdStudent.Parameters.AddWithValue("@Name", Name);
                        cmdStudent.Parameters.AddWithValue("@ProgramID", ProgramID);
                        cmdStudent.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                        if (string.IsNullOrEmpty(Address))
                            cmdStudent.Parameters.AddWithValue("@Address", DBNull.Value);
                        else
                            cmdStudent.Parameters.AddWithValue("@Address", Address);

                        cmdStudent.Parameters.AddWithValue("@ImagePath", ImagePath);

                        int rowsAffected = cmdStudent.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update student.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            return isUpdated;

        }
        static public bool DeleteStudentByID(int StudentID) 
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"DELETE FROM [dbo].[Contact]
                    WHERE ContactID IN (
                    SELECT ContactID 
                        FROM [dbo].[Student] 
                        WHERE StudentID = @StudentID
                                                );

                
                    DELETE FROM [dbo].[Student]
                    WHERE StudentID = @StudentID;
";

            SqlCommand cmd= new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsDeleted = true;

            }

            catch(Exception ex)
            {
                throw new Exception("Failed to delete student by id.", ex);
            }
            finally 
            {
                connection.Close();
            }

            return IsDeleted;
        }
        //Program's DataAccess Functions:
        static public bool AddNewProgram(string ProgramName,string Level) 
        {
            bool IsAdded = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"INSERT INTO [dbo].[Program]
           ([Name]
           ,[Level])
            VALUES
          ( @ProgramName,
           @Level);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProgramName", ProgramName);
            cmd.Parameters.AddWithValue("@Level", Level);

            try
            {
                connection.Open();

                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsAdded = true;
                }

            }

            catch (Exception ex) { throw new Exception("Failed to add new program.", ex);  }
            finally { connection.Close(); }

            return IsAdded;

        }
        static public DataTable GetProgramsBasedOnLevel(string Level)
        {
            
            DataTable dtPrograms = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string qurey = @"select Name from Program 
                       where Level=@Level; ";

            SqlCommand cmd = new SqlCommand(qurey, connection);
 cmd.Parameters.AddWithValue("@Level", Level);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dtPrograms.Load(reader);

            }

            catch (Exception ex)
            {
                throw new Exception("Failed to get program based on level,", ex);

            }
            finally
            {
                connection.Close();

            }

            return dtPrograms;

        }
        static public int GetProgramID(string ProgramName,string Level)
        {

            int ProgramID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"select ProgramID from Program
where Name=@ProgramName and Level=@Level;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Level", Level);
            cmd.Parameters.AddWithValue("@ProgramName", ProgramName);


            try
            {
                connection.Open();
                object Results = cmd.ExecuteScalar();

               int.TryParse(Results.ToString(), out ProgramID);

            }

            catch (Exception ex)
            {
                throw new Exception("Failed to get program id.", ex);

            }
            finally
            {
                connection.Close();

            }

            return ProgramID;
        }
        static public DataTable GetProgramsTableWithNumOfStudents() 
        {
            DataTable dtPrograms = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"select P.ProgramID,
	                        P.Name as ProgramName,
	                        P.Level,
	                        Count(S.StudentID) as NumOfStudents
	                        From Program as P
	                     left JOIN  Student as S
	                     on S.ProgramID=P.ProgramID
	                 group by P.Name,P.Level,P.ProgramID
	                order by NumOfStudents Desc;";

            SqlCommand cmd=new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                    dtPrograms.Load(reader);

                
            }
            catch (Exception ex) 
            {
                throw new Exception("Failed to get programs with number of students.", ex);
            }
            finally
            {
                connection.Close();
            }

            return dtPrograms;

        }
        static public bool UpdateProgramByID(int ProgramID,string ProgramName,string Level)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"UPDATE [dbo].[Program]
   SET [Name] = @ProgramName
      ,[Level] = @Level
 WHERE ProgramID=@ProgramID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProgramID", ProgramID);
            cmd.Parameters.AddWithValue("@ProgramName", ProgramName);
            cmd.Parameters.AddWithValue("@Level", Level);


            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception ex)
            { throw new Exception("Failed to update program by id.", ex); }
            finally
            {
                connection.Close();
            }


            return IsUpdated;
        }
        static public bool DeleteProgramByID(int ProgramID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"DELETE FROM [dbo].[Program]
      WHERE ProgramID=@ProgramID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProgramID", ProgramID);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsDeleted = true;

            }

            catch (Exception ex)
            {
                throw new Exception("Failed to delete program by id.", ex);
            }
            finally
            {
                connection.Close();
            }

            return IsDeleted;




        }
        //Contact's DataAccess Functions:
        static public int GetContactID(string Phone, string Email)
        {
            int contactID = -1;

            string query = @"SELECT ContactID FROM Contact 
                     WHERE Phone = @Phone AND Email = @Email";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    try
                    {
                        connection.Open();


                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            contactID = id;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed to get contact id.", ex);
                    }
                    finally { connection.Close(); };
                }
            }

            return contactID; 
        }
    }
}
