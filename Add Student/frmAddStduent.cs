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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
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
        //this function will check if the student is valid:
        protected bool IsStudentInfoValid() 
        {


            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You must enter a correct name");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("You must enter an Email");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text.ToString()))
            {
                  MessageBox.Show("You can not enter White Spaces in an email");
                txtEmail.Focus();
                return false;

            }

            if (string.IsNullOrEmpty(mtxPhone.Text))
            {
                MessageBox.Show("You must enter an Phone");
                mtxPhone.Focus();
                return false;

            }
            if (string.IsNullOrWhiteSpace(mtxPhone.Text.ToString()))
            {
                MessageBox.Show("You can not enter White Spaces in a phone number");
                mtxPhone.Focus();
                return false;

            }
           
            if (cbLevel.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a level of program");
                cbLevel.SelectedIndex = 0;
                return false;
            }

            if (cbProgram.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a program");
                cbProgram.SelectedIndex = 0;
                return false;
            }
            
             if (pbPersonalPhoto.Image == null || SelectedPath==string.Empty)
            {
                MessageBox.Show("You must load a photo for the student");

                pbPersonalPhoto.Focus();
                return false;
            }
            return true;
        }
       
        //here we will save student info into an abject :
        private void StudentInfoIntoObject(ref clsCurrentStudent Student)
        {
            Student.DateOfBirth = txtDate.Value;
            Student.StudentName= txtName.Text;
            Student.Email= txtEmail.Text;
            Student.Phone=mtxPhone.Text;
            Student.Level = cbLevel.SelectedItem.ToString();
            Student.Address= txtAddress.Text;

            Student.ProgramName = cbProgram.Text;
           int.TryParse(cbProgram.SelectedValue.ToString(), out Student.ProgramID);


            Student.ImagePath = Student_Manager__Business_Logic_Layer.BusinessLogic.SaveImageToAppFolder(SelectedPath);


        }

        //this function will take the Student object and send it to the database :
        private bool AddNewStudent()
        {
            clsCurrentStudent NewStduent = new clsCurrentStudent();

            StudentInfoIntoObject(ref NewStduent); 
           

           return Student_Manager__Business_Logic_Layer.BusinessLogic.AddNewStudent(ref NewStduent.StudentID,
                NewStduent.StudentName, NewStduent.Email, NewStduent.Phone,
                NewStduent.ProgramName,NewStduent.Level, NewStduent.DateOfBirth, NewStduent.Address, NewStduent.ImagePath);


        }

        protected virtual void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (IsStudentInfoValid()) 
            {
                //the student now is valid so we will save his info in an object and we will send it to the second layer:
                try
                {
                    if (AddNewStudent())
                    {
                        MessageBox.Show("Student Add Successfully", "Add", MessageBoxButtons.OK);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not add new student. \n\nDetails:"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
    
        }

        //this function will fill the combobox of programs based on the level
        protected void FillProgramsAndLevels()
        {

            if (cbLevel.SelectedIndex < 0)
                return;

            string Level = cbLevel.SelectedItem.ToString();
            DataView dataView = new DataView();

            DataTable dataTable = new DataTable();
            try
            {
                dataTable = Student_Manager__Business_Logic_Layer.BusinessLogic.GetProgramsBasedOnLevel(Level);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get programs based on level. \n\nDetails:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            dataView = dataTable.DefaultView;

            cbProgram.DataSource = dataView;
            cbProgram.DisplayMember = "Name";
            //cbProgram.ValueMember = "ProgramID";
        
            if (cbProgram.SelectedIndex == -1)
            {
                cbProgram.SelectedIndex = 0;

            }
        
        }
        
        private void frmAddStudent_Load(object sender, EventArgs e)
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
