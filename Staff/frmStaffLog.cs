using Student_Manager.Main_Screen;
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
    public partial class frmStaffLog : Form
    {
        DataTable dtStaffLog;
        public frmStaffLog()
        {
            InitializeComponent();
        }
        // here we will load all staff's logs from databse
        private void LoadStaffLogs() 
        {
            try
            {
                dtStaffLog = Student_Manager__Business_Logic_Layer.BusinessLogic.GetAllStaffLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve Staff log data.\n\nDetails:" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            DataView dvStafflog = dtStaffLog.DefaultView;

            foreach(DataRowView row in dvStafflog)
            {

                dgvStaffLog.Rows.Add
                    (
                    row["LogID"],
                    row["StaffID"],
                    row["StudentID"],
                    row["Operation"],
                    row["Time"]
                    );
            }
        }
        private void frmStaffLog_Load(object sender, EventArgs e)
        {
            LoadStaffLogs();
            cbSearch.SelectedIndex = 0;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainScreen frmMainScreen = new frmMainScreen();
            frmMainScreen.Show();
        }

        //this function will filter the table:
        private void FilterResult(string Filter)
        {
            dgvStaffLog.Rows.Clear();

            DataView dtvStaffLog = new DataView();
            dtvStaffLog = dtStaffLog.DefaultView;


            if (cbSearch.SelectedIndex == 0)
            {
                int ID;

                int.TryParse(Filter, out ID);

                dtvStaffLog.RowFilter = $"StaffID={ID}";

            }
            if (cbSearch.SelectedIndex == 1)
            {
                int ID;

                int.TryParse(Filter, out ID);

                dtvStaffLog.RowFilter = $"StudentID={ID}";

            }
         
            else if (cbSearch.SelectedIndex == 2)
            {
                dtvStaffLog.RowFilter = $"Operation Like '{Filter}%'";
            }

            if (Filter == string.Empty)
            {
                dtvStaffLog.RowFilter = string.Empty;
            }

            foreach (DataRowView rowView in dtvStaffLog)
            {
                DataRow row = rowView.Row;

                dgvStaffLog.Rows.Add(

                     row["StaffID"],
                    row["StudentID"],
                    row["Operation"],
                    row["Time"]
                );
            }
        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            string Filter = txtBarSearch.Text;
            FilterResult(Filter);

        }
    }
}
