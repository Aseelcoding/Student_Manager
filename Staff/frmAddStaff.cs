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

            if(string.IsNullOrWhiteSpace(txtName.Text)) 
            {
                MessageBox.Show("Name must has value and does not start with space");
                IsValid = false;
                txtName.Clear();
                txtName.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username must has value and does not start with space");
                IsValid = false;
                txtUserName.Clear();
                txtUserName.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password must has value and does not start with space");
                IsValid = false;
                txtPassword.Clear();
                txtPassword.Focus();
            }

            return IsValid;
        }
        //this function will save the staff info into object:
        private void SaveStaffIntoObject(ref Student_Manager.Staff_Data.clsStaff NewStaff) 
        {
            NewStaff.Name = txtName.Text;
            NewStaff.Username= txtUserName.Text;
            NewStaff.Password= txtPassword.Text;
        }
        //this function will send the new staff to the database :

        private bool AddNewStaff() 
        {
            bool IsAdded = false;
            clsStaff NewStaff = new clsStaff();
            SaveStaffIntoObject(ref NewStaff);

            try
            {
                IsAdded =Student_Manager__Business_Logic_Layer.BusinessLogic.AddNewStaff
                (
                NewStaff.Name, NewStaff.Username, NewStaff.Password);
            }

            catch
            {
                throw;
            }
            return IsAdded;

        }
        private void btnAddStduent_Click(object sender, EventArgs e)
        {
            if (IsStaffValid())
            {
                try
                {
                    if (AddNewStaff())
                    {
                        MessageBox.Show("Staff Added done successfully", "Success", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Staff Added Faild", "Warning", MessageBoxButtons.OK);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
