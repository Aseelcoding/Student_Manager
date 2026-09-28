using Student_Manager.Staff_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager.Staff
{
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        //this function will check if the staff is valid : done
        private bool IsStaffValid() 
        {
            bool IsValid=true;

            if(txtName.Text.Length<4 || txtName.Text.Length > 256) 
            {
                MessageBox.Show("The name's length must be more than 4 and less than 256", "Warning", MessageBoxButtons.OK);
                IsValid = false;
                txtName.Clear();
            }
            if(txtUserName.Text.Length<5 || txtUserName.Text.Length > 25)
            {
                MessageBox.Show("The Username's length must be more than 4 and less than 26", "Warning", MessageBoxButtons.OK);
                IsValid = false;
                txtUserName.Clear();
            }

            if (txtPassword.Text.Length < 3 || txtUserName.Text.Length > 10)
            {
                MessageBox.Show("The Password's length must be more than 2 and less than 11", "Warning", MessageBoxButtons.OK);
                IsValid = false;
                txtPassword.Clear();
            }

            return IsValid;
        }
        //this function will save the staff info into object:
        private void SaveStaffIntoObject(ref clsStaff NewStaff) 
        {
            NewStaff.Name = txtName.Text;
            NewStaff.Username= txtUserName.Text;
            NewStaff.Password= txtPassword.Text;
        }
        //this function will send the new staff to the database :

        private bool SaveStaff() 
        {
            clsStaff NewStaff = new clsStaff();
            SaveStaffIntoObject(ref NewStaff);

            return Student_Manager__Business_Logic_Layer.BusinessLogic.AddNewStaff
                (
                NewStaff.Name, NewStaff.Username, NewStaff.Password);


        }
        private void btnAddStduent_Click(object sender, EventArgs e)
        {
            if (IsStaffValid())
            {
                if (SaveStaff())
                {
                    MessageBox.Show("Staff Added done successfully", "Success", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Staff Added Faild", "Warning", MessageBoxButtons.OK);
                   
                }
            }

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
