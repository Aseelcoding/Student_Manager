using Student_Manager.Add_Student;
using Student_Manager.Programs;
using Student_Manager.Staff;
using Student_Manager.Student_Data;
using Student_Manager.Update_Student;
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


namespace Student_Manager.Main_Screen
{
    public partial class frmMainScreen : Form
    {

        DataTable dtStudents;
        public frmMainScreen()
        {
            InitializeComponent();


            //for the combobox above the search bar

            if (cbSearch.SelectedIndex == -1)
            {
                { cbSearch.SelectedIndex = 0; }
            }

        }

        //to fill info staff and time in the right up corner 
        private void FillInfo() 
        {
            txtStaffName.Text = Staff_Data.clsCurrentStaff.Name;
            lapTime.Text = DateTime.Now.ToString();
        }
        private void btnAddStduent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStduent = new frmAddStudent();
            frmAddStduent.ShowDialog();
            LoadStudentsInfo();
        }


        private void LoadStudentsInfo()
        {
            dtgStudents.Rows.Clear();
            dtgStudents.AutoGenerateColumns = false;

            try
            {
                dtStudents = Student_Manager__Business_Logic_Layer.BusinessLogic.GetAllStudents();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Could not retrieve student's data.\n\nDetails:"+ ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataView dtView = dtStudents.DefaultView;

            foreach (DataRowView rowView in dtView) 
            {
                DataRow row = rowView.Row;

                Image studentImage = null;
                string imagePath = row["ImagePath"]?.ToString();

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
                }

             
                dtgStudents.Rows.Add(
                    studentImage,
                    row["StudentID"],
                    row["StudentName"],
                    row["Level"],
                    row["ProgramName"],
                    row["DateOfBirth"],
                    row["ContactID"]
                    
                   
                );
            }
        }
        private void frmMainScreen_Load(object sender, EventArgs e)
        {

            //here we will load Students info :
            LoadStudentsInfo();




            FillInfo();
        }

        //this function will bring the data of the student from the selected row in the data grid view:

        private void GetSelectedRow(ref clsCurrentStudent Student) 
        {
            string SID=dtgStudents.SelectedRows[0].Cells["StudentID"].Value.ToString();

            int.TryParse(SID, out Student.StudentID);

        }
        private void tsbmUpdate_Click(object sender, EventArgs e)
        {
            if (dtgStudents.SelectedRows.Count<= 0)
            {

                MessageBox.Show("Please choose a valid row!", "Warning", MessageBoxButtons.OK);

                return;
            
            }

            //here we will open the form and send an object from clsCurrentStudents info:
            clsCurrentStudent student = new clsCurrentStudent();
            GetSelectedRow(ref student);

            frmUpdateStudent frmUpdateStudent = new frmUpdateStudent(student);
            frmUpdateStudent.ShowDialog();

            LoadStudentsInfo();
        }
        private void FilterdtStudents(string Filter)
        {

            dtgStudents.Rows.Clear();

            DataView dtvStudents = new DataView();
            dtvStudents = dtStudents.DefaultView;


            if(cbSearch.SelectedIndex==0)
            {
                int ID;
                int.TryParse(Filter, out ID);
                dtvStudents.RowFilter = $"StudentID={ID}";
            }
            else if(cbSearch.SelectedIndex == 1)
            {
                dtvStudents.RowFilter = $"StudentName Like '{Filter}%'";
            }
            else if (cbSearch.SelectedIndex == 2)
            {
                dtvStudents.RowFilter = $"Level Like '{Filter}%'";
            }
            else if (cbSearch.SelectedIndex == 3)
            {
                dtvStudents.RowFilter = $"ProgramName Like '%{Filter}%'";
            }
            else if (cbSearch.SelectedIndex == 4)
            {
                int ID;
                int.TryParse(Filter, out ID);
                dtvStudents.RowFilter = $"ContactID ={ID}";
            }
            else if (cbSearch.SelectedIndex == 5)
            {
                DateTime dt=new DateTime();
                try {  dt = DateTime.Parse(Filter); dtvStudents.RowFilter = $"DateOfBirth = '{dt.ToShortDateString()}'"; }
                catch {  }



               
            }

            if (Filter == string.Empty) 
            {
                dtvStudents.RowFilter=string.Empty ;
            }
            foreach (DataRowView rowView in dtvStudents)
            {
                DataRow row = rowView.Row;

                Image studentImage = null;
                string imagePath = row["ImagePath"]?.ToString();

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
                }


                dtgStudents.Rows.Add(
                    studentImage,
                    row["StudentID"],
                    row["StudentName"],
                    row["Level"],
                    row["ProgramName"],
                    row["DateOfBirth"],
                    row["ContactID"]


                );
            }
        }
        //this function is for The searching Proccess:
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            //cbSearch 

            FilterdtStudents(txtBarSearch.Text);
            
        }
        
        private void btnPrograms_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmProgram programs = new frmProgram();
            programs.Show();
            
        }
        //this function will delete the selected Student
        private bool DeleteStudent() 
        {
           
            clsCurrentStudent student = new clsCurrentStudent();
            GetSelectedRow(ref student);

                        
                return Student_Manager__Business_Logic_Layer.BusinessLogic.DeleteStudentID(student.StudentID);
            
           
            
        }
        private void tsbmDelete_Click(object sender, EventArgs e)
        {
            bool IsDeleted = false;
            if (dtgStudents.SelectedRows.Count <= 0)
            {

                MessageBox.Show("Please choose a valid row!", "Warning", MessageBoxButtons.OK);

                return;

            }

            if(MessageBox.Show("Are you sure want to delete this student ?", "Warning", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {

                try
                {
                    IsDeleted = DeleteStudent();
  
                    if (IsDeleted)
                    {
                        MessageBox.Show("Delete the student done successfully", "success", MessageBoxButtons.OK);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could not delete student.\n\nDetails:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadStudentsInfo();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //here we will open the staff form :
            this.Hide();
            frmStaff frm= new frmStaff();
            frm.Show();
            

        }

        private void btnStaffLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffLog frm= new frmStaffLog();

            frm.Show();

        }
    }
}
