using Student_Manager.Main_Screen;
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

namespace Student_Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

         
        }


        //Function to save Staff's info
        private void SaveStaffInfo(int StaffID,string Name,string Username,string Password) 
        {
            clsCurrentStaff.StaffID= StaffID;
            clsCurrentStaff.Name= Name;
            clsCurrentStaff.Username= Username;
            clsCurrentStaff.Password= Password;
        }

        //Function to perform the login process:
        private void Login() 
        {
            int StaffID = -1;
            string Name = "";
            string UserName = txtUserName.Text.ToString();
            string Password = txtPassword.Text.ToString();
            if (UserName == "" || Password == "")
            {
                MessageBox.Show("Please enter the user name and the password", "try again", MessageBoxButtons.OK);

                return;
            }
            if (Student_Manager__Business_Logic_Layer.BusinessLogic.IsStaffExist(ref StaffID,ref Name, UserName, Password))
            {
                MessageBox.Show("Access is Approved by: " + Name, "Success", MessageBoxButtons.OK);
                SaveStaffInfo(StaffID,Name,UserName,Password);
                //here it will move ot the next form and if the user close the program will be closed
                this.Hide();
                frmMainScreen frmMainScreen = new frmMainScreen();
                frmMainScreen.Show();

            }
            else
            {
                MessageBox.Show("Access is not Approved", "Failed", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Login();
            txtUserName.Text = "";
            txtPassword.Text = "";
           


        }
    }
}
