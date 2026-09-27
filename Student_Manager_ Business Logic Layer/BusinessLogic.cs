using Student_Manager_DataAsccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager__Business_Logic_Layer
{
    public class BusinessLogic
    {
        //Staff's Business Logic Functions:
        static public bool IsStaffExist(ref int StaffID,ref string Name,string UserName, string Password)
        {
            return Student_Manager_DataAsccess.DataAccess.IsStaffExist(ref StaffID,ref Name, UserName, Password);
        }
        //Student's Business Logic Functions:
        static public bool SaveNewStudent(ref int StudentID, string Name, string Email, string Phone
            , string ProgramName,string Level, DateTime DateOfBirth, string Address, string ImagePath) 
        {
            return Student_Manager_DataAsccess.DataAccess.SaveNewStudent(ref StudentID,Name,Email,Phone,ProgramName,  Level, DateOfBirth,Address,ImagePath);
        }
        static public bool UpdateStudent( int StudentID, string Name, string Email, string Phone
            , string ProgramName, string Level, DateTime DateOfBirth, string Address, string ImagePath) 
        {
            return Student_Manager_DataAsccess.DataAccess.UpdateStudentByID(StudentID, Name, Level, ProgramName, DateOfBirth, Phone, Email, Address, ImagePath);
        }
        static public DataTable GetAllStudents() 
        {
            return Student_Manager_DataAsccess.DataAccess.GetAllStudents();
        }
        static public bool GetStudentByID(int StudentID, ref string Name, ref string Level, ref string ProgramName, ref DateTime DateOfBirth, ref string Phone, ref string Email, ref string Address, ref string ImagePath)
        {
            return Student_Manager_DataAsccess.DataAccess.GetStudentByID(StudentID, ref Name, ref Level, ref ProgramName, ref DateOfBirth, ref Phone, ref Email, ref Address, ref ImagePath);
        }
        //Program's DataAccess Functions:
        static public DataTable GetProgramsBasedOnLevel(string Level)
        {
            return Student_Manager_DataAsccess.DataAccess.GetProgramsBasedOnLevel(Level);

        }
        static public DataTable GetProgramsTableWithNumOfStudents() 
        {
            return Student_Manager_DataAsccess.DataAccess.GetProgramsTableWithNumOfStudents();
        }
    }
}
