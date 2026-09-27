using Student_Manager.Student_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager.Add_Student
{
    public partial class frmAddStduent : Form
    {
        public frmAddStduent()
        {
            InitializeComponent();

           
        }
        private static string SelectedPath;
        protected virtual void btnChangePhoto_Click(object sender, EventArgs e)
        {
            fdPersonalPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fdPersonalPhoto.Title = "Chose the Personal Photo please ";

            if (fdPersonalPhoto.ShowDialog() == DialogResult.OK)
            {
                SelectedPath = fdPersonalPhoto.FileName;
                pbPersonalPhoto.Image = Image.FromFile(SelectedPath);

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this function will check if the stduent is valid:
        protected  bool IsStudentInfoValid() 
        {
            if (txtName.Text.Length <=0 || txtName.Text.Length > 255) 
            {
                MessageBox.Show("The name must be more then 0 and less then 256", "Warning", MessageBoxButtons.OK);
                txtName.Clear();

                return false;
            }

            if (txtEmail.Text.Length<11 || txtEmail.Text.Length > 256)
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

            if (txtAddress.Text.Length >256)
            {
                MessageBox.Show("The Address must be more then 256", "Warning", MessageBoxButtons.OK);
                txtAddress.Clear();

                return false;
            }

            if (SelectedPath == null)
            {
                MessageBox.Show("You muse choose a photo for the student", "Warning", MessageBoxButtons.OK);

                return false;
            }

          



            return true;
        }
        protected string SaveImageToAppFolder(string sourceFilePath)
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
            Student.DateOfBirth = txtDate.Value;
            Student.StudentName= txtName.Text;
            Student.Email= txtEmail.Text;
            Student.Phone=mtxPhone.Text;
            Student.Level = cbLevel.SelectedItem.ToString();
            Student.Address= txtAddress.Text;

            Student.ProgramName = cbProgram.Text;
           int.TryParse(cbProgram.SelectedValue.ToString(), out Student.ProgramID);


            Student.ImagePath = SaveImageToAppFolder(SelectedPath);

        }

        //this function will take the Student object and send it to the database :
        private bool SaveNewStduent()
        {
            clsCurrentStudent NewStduent = new clsCurrentStudent();
            StduentInfoIntObject(ref NewStduent);


           return  Student_Manager__Business_Logic_Layer.BusinessLogic.SaveNewStudent(ref NewStduent.StudentID,
                NewStduent.StudentName, NewStduent.Email, NewStduent.Phone,
                NewStduent.ProgramName,NewStduent.Level, NewStduent.DateOfBirth, NewStduent.Address, NewStduent.ImagePath);


        }

        protected virtual void btnAddStduent_Click(object sender, EventArgs e)
        {
            if (IsStudentInfoValid()) 
            {
                //the student now is valid so we will save his info in an object and we will send it to the second layer:

                if (SaveNewStduent())
                    {
                    MessageBox.Show("Student Add Successfully", "Add", MessageBoxButtons.OK);

                    }
                else
                {
                    MessageBox.Show("Student Add Faild", "Add", MessageBoxButtons.OK);
                }
            

            }
            else
            {
                MessageBox.Show("Student Add Faild", "Add", MessageBoxButtons.OK);
                return;
            }

        }

        //this function will fill the combobox of programs based on the level
        protected void FillProgramsAndLevels() 
        {
           

            string Level = cbLevel.SelectedItem.ToString();
            DataView dataView = new DataView();
            DataTable dataTable= Student_Manager__Business_Logic_Layer.BusinessLogic.GetProgramsBasedOnLevel(Level);
            dataView = dataTable.DefaultView;

            cbProgram.DataSource= dataView;
            cbProgram.DisplayMember = "Name";
            //cbProgram.ValueMember = "ProgramID";
           
            if (cbProgram.SelectedIndex == -1)
            {
                cbProgram.SelectedIndex = 0;
            }
        }
        private void frmAddStduent_Load(object sender, EventArgs e)
        {



            if (cbLevel.SelectedIndex == -1)
            {
                cbLevel.SelectedIndex = 0;
            }







        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
        

            FillProgramsAndLevels();
        }
    }
}
