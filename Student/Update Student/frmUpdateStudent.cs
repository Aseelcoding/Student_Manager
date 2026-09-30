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
    public partial class frmUpdateStudent : frmAddStudent
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
            try
            {
                Student_Manager__Business_Logic_Layer.BusinessLogic.GetStudentByID(Student.StudentID, ref Student.StudentName,
                ref Student.Level, ref Student.ProgramName, ref Student.DateOfBirth,
                ref Student.Phone, ref Student.Email, ref Student.Address, ref Student.ImagePath);

                lapStudentID.Text = Student.StudentID.ToString();
                txtName.Text = Student.StudentName;
                txtEmail.Text = Student.Email;
                mtxPhone.Text = Student.Phone;
                txtDate.Value = Student.DateOfBirth;
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
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
        //here we will save student info into an abject :
        private void StudentInfoIntoObject(ref clsCurrentStudent Student)
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
            StudentInfoIntoObject(ref Student);

            bool IsUpdated=false;
            try
            {
                IsUpdated= Student_Manager__Business_Logic_Layer.BusinessLogic.UpdateStudent(Student.StudentID, Student.StudentName,
                Student.Email, Student.Phone, Student.ProgramName, Student.Level, Student.DateOfBirth, Student.Address, Student.ImagePath);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return IsUpdated;
        }
     
        protected override void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(IsPhotoChanged)
            {
                try { SelectedPath= Student_Manager__Business_Logic_Layer.BusinessLogic.SaveImageToAppFolder(SelectedPath); 
                
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                

            if (IsStudentInfoValid())
            {
                if (UpdateStudent())
                {
                    MessageBox.Show("Student with the ID :" + Student.StudentID + " updated successfully", "info", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Student with the ID :" + Student.StudentID + " failed ", "info", MessageBoxButtons.OK);
                    return;
                }
            }
            
        }

        protected override void btnChangePhoto_Click(object sender, EventArgs e)
        {
            fdPersonalPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fdPersonalPhoto.Title = "Choose the Personal Photo please ";

            if (fdPersonalPhoto.ShowDialog() == DialogResult.OK)
            {
                SelectedPath = fdPersonalPhoto.FileName;
                pbPersonalPhoto.Image = Image.FromFile(SelectedPath);
                IsPhotoChanged = true;
            }
        

        }

      
    }
}
