using Student_Manager.Add_Student;
using Student_Manager.Student_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Manager.Update_Student
{
    public partial class frmUpdateStudent : frmAddStduent
    {
        clsCurrentStudent Student;
        string SelectedPath;
        bool IsPhotoChanged=false;
        public frmUpdateStudent(clsCurrentStudent currentStudent)
        {
            InitializeComponent();
            Student=currentStudent;

            FillUpdateScreenStudentInfo();
        }
      
        private void FillUpdateScreenStudentInfo()
        {
            

            //we will bring the info from the database :
            if(Student_Manager__Business_Logic_Layer.BusinessLogic.GetStudentByID(Student.StudentID,ref Student.StudentName,
                ref Student.Level,ref Student.ProgramName,ref Student.DateOfBirth,
                ref Student.Phone,ref Student.Email,ref Student.Address,ref Student.ImagePath))
            {
                lapStudentID.Text = Student.StudentID.ToString();
                txtName.Text = Student.StudentName;
                txtEmail.Text = Student.Email;
                mtxPhone.Text = Student.Phone;
                txtDate.Value= Student.DateOfBirth;
                txtAddress.Text = Student.Address;
                cbLevel.Text = Student.Level;
                cbProgram.Text = Student.ProgramName;
                SelectedPath = Student.ImagePath;

                Image studentImage = null;
                string imagePath = SelectedPath;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        studentImage = Image.FromFile(imagePath);
                    }
                    catch
                    {
                        studentImage = null;
                    }
                    pbPersonalPhoto.Image = studentImage;
                }


            }
            else
            {
                MessageBox.Show("Faild to load Student info please try again", "Warning", MessageBoxButtons.OK);
                this.Close();
            }

        }
        //this function will check if the stduent is valid:
        protected new bool IsStudentInfoValid()
        {
            if (txtName.Text.Length <= 0 || txtName.Text.Length > 255)
            {
                MessageBox.Show("The name must be more then 0 and less then 256", "Warning", MessageBoxButtons.OK);
                txtName.Clear();

                return false;
            }

            if (txtEmail.Text.Length < 11 || txtEmail.Text.Length > 256)
            {
                MessageBox.Show("The email must be more then 10 and less then 256", "Warning", MessageBoxButtons.OK);
                txtEmail.Clear();

                return false;
            }

            if (mtxPhone.Text.Length < 11 || mtxPhone.Text.Length > 256)
            {
                MessageBox.Show("The phone number must be more then 9 and less then 15", "Warning", MessageBoxButtons.OK);
                mtxPhone.Clear();

                return false;
            }

            if (txtAddress.Text.Length > 256)
            {
                MessageBox.Show("The Address must be more then 256", "Warning", MessageBoxButtons.OK);
                txtAddress.Clear();

                return false;
            }

            if (SelectedPath == null || pbPersonalPhoto==null)
            {
                MessageBox.Show("You muse choose a photo for the student", "Warning", MessageBoxButtons.OK);

                return false;
            }





            return true;
        }
        protected new string SaveImageToAppFolder(string sourceFilePath)
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
        //here we will save student info into an abject :
        private void StduentInfoIntObject(ref clsCurrentStudent Student)
        {
            //int.TryParse(lapStudentID.Text, out Student.StudentID);
            Student.DateOfBirth = txtDate.Value;
            Student.StudentName = txtName.Text;
            Student.Email = txtEmail.Text;
            Student.Phone = mtxPhone.Text;
            Student.Level = cbLevel.SelectedItem.ToString();
            Student.Address = txtAddress.Text;

            Student.ProgramName = cbProgram.Text;
            int.TryParse(cbProgram.SelectedValue.ToString(), out Student.ProgramID);


            //Student.ImagePath = SaveImageToAppFolder(SelectedPath);

        }
        private bool UpdateStudent() 
        {

            
            StduentInfoIntObject(ref Student);

            return Student_Manager__Business_Logic_Layer.BusinessLogic.UpdateStudent(Student.StudentID, Student.StudentName, Student.Email, Student.Phone, Student.ProgramName, Student.Level, Student.DateOfBirth, Student.Address, Student.ImagePath);

        }
        
    

        protected override void btnAddStduent_Click(object sender, EventArgs e)
        {
            if(IsPhotoChanged)
            Student.ImagePath = SaveImageToAppFolder(SelectedPath);

            if (IsStudentInfoValid())
            {
                if (UpdateStudent())
                {
                    MessageBox.Show("Student with the ID :" + Student.StudentID + " updated successfully", "info", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Student with the ID :" + Student.StudentID + " faild ", "info", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Student with the ID :" + Student.StudentID + " faild ", "info", MessageBoxButtons.OK);
                return;
            }
        }

        protected override void btnChangePhoto_Click(object sender, EventArgs e)
        {
            fdPersonalPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fdPersonalPhoto.Title = "Chose the Personal Photo please ";

            if (fdPersonalPhoto.ShowDialog() == DialogResult.OK)
            {
                SelectedPath = fdPersonalPhoto.FileName;
                pbPersonalPhoto.Image = Image.FromFile(SelectedPath);
                IsPhotoChanged = true;
            }
        

        }
    }
}
