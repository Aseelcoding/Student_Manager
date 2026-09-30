using Student_Manager_DataAsccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.Mail;

namespace Student_Manager__Business_Logic_Layer
{
    public class BusinessLogic
    {
        //General check functions:
        static private void IsIDValid(int ID,string NameOfId) 
        {
            if (ID < 1) { throw new Exception($"{NameOfId} ID is not valid"); }
        }

        //Staff's Business Logic Functions:
        static private void IsStaffinfoValid(string Name,string UserName,string Password)
        {
            if (Name == string.Empty)
            { throw new Exception("Name must has value"); }

            if (Name.Length < 4 || Name.Length > 255)
            {
                throw new Exception("Name length must be between 4 and 255 ");

            }

            if (UserName == string.Empty)
            { throw new Exception("Username must has value"); }

            if (UserName.Length < 5 || UserName.Length > 25)
            {
                throw new Exception("UserName length must be between 5 and 25 ");

            }

            if (Password == string.Empty)
            { throw new Exception("Password must has value"); }

            if (Password.Length < 3 || Password.Length > 10)
            {
                throw new Exception("Password length must be between 3 and 10 ");

            }

        }
        static public bool IsStaffExist(ref int StaffID,ref string Name,string UserName, string Password)
        {
           

            return Student_Manager_DataAsccess.DataAccess.IsStaffExist(ref StaffID,ref Name, UserName, Password);
        }
        static public DataTable GetAllStaff() 
        {
            return Student_Manager_DataAsccess.DataAccess.GetAllStaff();

        }
        static public bool AddNewStaff(string StaffName, string Username, string Password)
        {
            IsStaffinfoValid(StaffName, Username, Password);
            return Student_Manager_DataAsccess.DataAccess.AddNewStaff(StaffName,Username,Password);
        }
        //here we will add UpdateStaff function:
        static public bool DeleteStaffByID(int StaffID)
        {
            IsIDValid(StaffID, "Staff");
            return Student_Manager_DataAsccess.DataAccess.DeleteStaffByID(StaffID);
        }
        //Student's Business Logic Functions:
        static private void IsStudentInfoValid(string Name, string Email, string Phone, string Address, string ImagePath,
            string ProgramName,string Level,
            DateTime DateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(Name))
            { throw new Exception("Name must has value"); }

             if (Name.Length < 4 || Name.Length > 255)
                {
                    throw new Exception("Name length must be between 4 and 255 ");

                }

            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new Exception("Email must has value");
            }
            try
            {
                MailAddress m = new MailAddress(Email);
                
            }
            catch (FormatException)
            {
                throw;
            }
            if (string.IsNullOrWhiteSpace(Phone)) 
            {
                throw new Exception("Phone must has value");
            }
            if (Phone.Length < 11 || Phone.Length > 20)
            {
                throw new Exception("phone number must be between 11 and  20");
            }

            if (!string.IsNullOrEmpty(Address))
            {
                if (Address.Length > 255)
                {
                    throw new Exception("Address must not be more than 255");
                }
            }

            if (ImagePath == null || string.IsNullOrWhiteSpace(ImagePath))
            {
                throw new Exception("Selected path must has a value");
            }

            if (ProgramName == string.Empty)
            {
                throw new Exception("ProgramName must has value");
            }
            if (ProgramName.Length < 3 || ProgramName.Length > 100)
            {
                throw new Exception("Program name length must be between 3 and 100");
            }

            if (Level == string.Empty)
            {
                throw new Exception("Level must has value");
            }
            if(Level!= "Bachelor"&&Level!= "Master"&&Level!= "Doctoral") 
            {
                throw new Exception("Level must be one of these : 'Bachelor' , 'Master' , 'Doctoral'");
            }

            
            if (DateOfBirth < new DateTime(1950, 1,1) ||DateOfBirth>new DateTime(2009, 12,31))
            {
                throw new Exception("Date of birth must be between 1950 and 2009");
            }

        }
       static public string SaveImageToAppFolder(string sourceFilePath)
        {
            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
                return string.Empty;

            // 1. تحديد مجلد مستندات المستخدم (MyDocuments) وإنشاء مجلد خاص بالتطبيق بداخله
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appImagesFolder = Path.Combine(documentsPath, "StudentManager_Images");

            // إذا لم يكن المجلد موجوداً، قم بإنشائه تلقائياً
            if (!Directory.Exists(appImagesFolder))
            {
                Directory.CreateDirectory(appImagesFolder);
            }

            // 2. استخراج صيغة الملف (مثل .jpg أو .png)
            string fileExtension = Path.GetExtension(sourceFilePath);

            // 3. إنشاء اسم فريد تماماً للصورة لتجنب تكرار الأسماء
            string uniqueImageName = Guid.NewGuid().ToString() + fileExtension;

            // 4. المسار النهائي الذي ستخزن فيه الصورة على جهاز المستخدم
            string destinationFilePath = Path.Combine(appImagesFolder, uniqueImageName);

            // 5. نسخ الصورة فعلياً للمجلد الدائم
            File.Copy(sourceFilePath, destinationFilePath, true);

            // إرجاع المسار الجديد الدائم (وهذا ما يتم تخزينه في قاعدة البيانات وفي الكلاس)
            return destinationFilePath;
        }
        static public bool AddNewStudent(ref int StudentID, string Name, string Email, string Phone
            ,string ProgramName,string Level, DateTime DateOfBirth, string Address, string ImagePath) 
        {

            IsStudentInfoValid(Name, Email, Phone, Address, ImagePath, ProgramName, Level, DateOfBirth);

            return Student_Manager_DataAsccess.DataAccess.AddNewStudent(
                ref StudentID,
                Name,Email,Phone,ProgramName,
                Level, DateOfBirth,Address,ImagePath);
        }
        static public bool UpdateStudent( int StudentID, string Name, string Email, string Phone
            , string ProgramName, string Level, DateTime DateOfBirth, string Address, string ImagePath) 
        {
            IsIDValid(StudentID, "Student");
            IsStudentInfoValid(Name, Email, Phone, Address, ImagePath, ProgramName, Level, DateOfBirth);
            return Student_Manager_DataAsccess.DataAccess.UpdateStudentByID(
                StudentID, Name, Level, 
                ProgramName, DateOfBirth, Phone,
                Email, Address, ImagePath);
        }
        static public DataTable GetAllStudents() 
        {
            return Student_Manager_DataAsccess.DataAccess.GetAllStudents();
        }
        static public bool GetStudentByID(int StudentID, ref string Name, ref string Level, ref string ProgramName, ref DateTime DateOfBirth, ref string Phone, ref string Email, ref string Address, ref string ImagePath)
        {
            IsIDValid(StudentID, "Student");

            return Student_Manager_DataAsccess.DataAccess.GetStudentByID
                (StudentID, ref Name, ref Level, ref ProgramName, 
                ref DateOfBirth, ref Phone, ref Email,
                ref Address, ref ImagePath);
        }
        static public bool DeleteStudentID(int StudentID)
        {
            IsIDValid(StudentID, "Student");
            return Student_Manager_DataAsccess.DataAccess.DeleteStudentByID(StudentID);
        }
        //Program's DataAccess Functions:
        static private void IsProgramInfoValid(string ProgramName,string Level) 
        {
            if (ProgramName == string.Empty)
            {
                throw new Exception("ProgramName must has value");
            }
            if (ProgramName.Length < 3 || ProgramName.Length > 100)
            {
                throw new Exception("Program name length must be between 3 and 100");
            }

            if (Level == string.Empty)
            {
                throw new Exception("Level must has value");
            }
            if (Level != "Bachelor" && Level != "Master" && Level != "Doctoral")
            {
                throw new Exception("Level must be one of these : 'Bachelor' , 'Master' , 'Doctoral'");
            }
        }
        static public DataTable GetProgramsBasedOnLevel(string Level)
        {

            if (Level == string.Empty)
            {
                throw new Exception("Level must has value");
            }
            if (Level != "Bachelor" && Level != "Master" && Level != "Doctoral")
            {
                throw new Exception("Level must be one of these : 'Bachelor' , 'Master' , 'Doctoral'");
            }
            return Student_Manager_DataAsccess.DataAccess.GetProgramsBasedOnLevel(Level);

        }
        static public DataTable GetProgramsTableWithNumOfStudents() 
        {
            return Student_Manager_DataAsccess.DataAccess.GetProgramsTableWithNumOfStudents();
        }
        static public bool SaveNewProgram(string ProgramName,string Level)
        {
            IsProgramInfoValid(ProgramName, Level);


            return Student_Manager_DataAsccess.DataAccess.AddNewProgram(ProgramName, Level);
        }
        static public bool UpdateProgramByID(int ProgramID,string ProgramName,string Level)
        {
            bool IsUpdated = false;
            IsIDValid(ProgramID, "Program");

            IsProgramInfoValid(ProgramName, Level);
            try { IsUpdated=Student_Manager_DataAsccess.DataAccess.UpdateProgramByID(ProgramID, ProgramName, Level); }
            catch
            {
                throw;
            }
            return IsUpdated;
        }
        static public bool DeleteProgramByID(int ProgramID)
        {
            IsIDValid(ProgramID, "Program");
            return Student_Manager_DataAsccess.DataAccess.DeleteProgramByID(ProgramID);
        }
    }
}
