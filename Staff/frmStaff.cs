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

namespace Student_Manager.Staff
{
    public partial class frmStaff : Form
    {
        
        public frmStaff()
        {
            InitializeComponent();
        }
        DataTable dtStaff;
        //this function will get all the staff and load it into the Data Grid View:
        private void LoadAllStaff() 
        {
            dgvStaff.Rows.Clear();
            try
            {
                dtStaff = Student_Manager__Business_Logic_Layer.BusinessLogic.GetAllStaff();
            }

            catch (Exception ex)  { MessageBox.Show(ex.Message); }

            if (dtStaff != null)
            {
                DataView dtvStaff = dtStaff.DefaultView;


                foreach(DataRowView row in dtvStaff)
                {
                    dgvStaff.Rows.Add(
                        row["StaffID"],
                        row["Name"],
                        row["UserName"],
                        row["Password"]
                        );
                }
            }


        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            LoadAllStaff();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            frmMainScreen frmMainScreen = new frmMainScreen();
            frmMainScreen.Show();

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            

            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.ShowDialog();
            LoadAllStaff();
        }

        private void GetSelectedRow(ref clsStaff Staff) 
        {
            if (dgvStaff.Rows.Count > 0) 
            {
                string StID = dgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString();
                int.TryParse(StID, out Staff.StaffID);

                Staff.Name= dgvStaff.SelectedRows[0].Cells["StaffName"].Value.ToString();
                Staff.Password= dgvStaff.SelectedRows[0].Cells["Password"].Value.ToString();
            }
        }
        //this function will delete a staff by ID:
        private bool DeleteStaff(int StaffID)  
        {
            bool IsDeleted = false;

            try
            {
                IsDeleted=Student_Manager__Business_Logic_Layer.BusinessLogic.DeleteStaffByID(StaffID);
            }
            catch { throw; }
           return IsDeleted;
        }
        //this function will check if the user is trying to delete with login user or deleteing the last user:
        private bool CheckUser() 
        {
            clsStaff Staff = new clsStaff();
            GetSelectedRow(ref Staff);

            if (dgvStaff.Rows.Count==1)
            {
                MessageBox.Show("hehe, You are trying to delete the last user , You can not do this operation", "Warning", MessageBoxButtons.OK);
                return false;
            }
            if (Staff.StaffID == clsCurrentStaff.StaffID) 
            {
                MessageBox.Show("hehe, You are trying to delete the user that you using it , You can not do this operation", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        
        private void tsbmDelete_Click(object sender, EventArgs e)
        {

            bool IsDeleted=false;
            clsStaff StaffToDelete = new clsStaff();
            GetSelectedRow(ref StaffToDelete);

            if (CheckUser())
            {
                try
                {
                    IsDeleted=DeleteStaff(StaffToDelete.StaffID);
                    MessageBox.Show("Staff  with the ID :" + StaffToDelete.StaffID + " Deleted successfully", "Success", MessageBoxButtons.OK);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
            

            LoadAllStaff();

        }

        //this function will update the data grid view :
        private void FilterData(string Filter) 
        {
            DataView dvStaff = dtStaff.DefaultView;
            if (Filter != string.Empty)
            {
                if (cbSearch.SelectedIndex == 0)
                {
                    int STID;
                    int.TryParse(Filter, out STID);
                    dvStaff.RowFilter = $"StaffID={STID}";

                } 
                else if (cbSearch.SelectedIndex == 1)
                {
                    dvStaff.RowFilter = $"Name like '{Filter}%'";
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    dvStaff.RowFilter = $"UserName like '{Filter}%'";
                }
                else if (cbSearch.SelectedIndex == 3)
                {
                    dvStaff.RowFilter = $"Password like'{Filter}%'";
                }
            }
            else { dvStaff.RowFilter = string.Empty; }

            dgvStaff.Rows.Clear();
            if (dvStaff != null)
            {
              


                foreach (DataRowView row in dvStaff)
                {
                    dgvStaff.Rows.Add(
                        row["StaffID"],
                        row["Name"],
                        row["UserName"],
                        row["Password"]
                        );
                }
            }
        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            
           string Filter = txtBarSearch.Text;

            FilterData(Filter);

        }
    }
}
