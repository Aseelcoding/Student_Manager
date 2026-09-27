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

namespace Student_Manager.Programs
{
    public partial class frmProgram : Form
    {
        DataTable dtPrograms;
        public frmProgram()
        {
            InitializeComponent();
            cbbSearch.SelectedIndex = 0;

        }
        private void LoadProgramsInfo() 
        {
             dtPrograms = Student_Manager__Business_Logic_Layer.BusinessLogic.GetProgramsTableWithNumOfStudents();

            DataView dtvPrograms = dtPrograms.DefaultView;

            foreach (DataRow dr in dtvPrograms.Table.Rows) 
            {
                dgvPrograms.Rows.Add
                    (
                    dr["ProgramID"],
                    dr["ProgramName"],
                    dr["Level"],
                    dr["NumOfStudents"]
                    
                    );
            }
        }
        private void frmProgram_Load(object sender, EventArgs e)
        {
            LoadProgramsInfo();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainScreen frmMainScreen = new frmMainScreen();
            frmMainScreen.Show();
        }

        private void FilterdtPrograms(string Filter)
        {

//            Program ID
//            Program Name
//            Level
//            Number of students
            dgvPrograms.Rows.Clear();
            
            DataView dtvPrograms = new DataView();
            dtvPrograms = dtPrograms.DefaultView ;


            if (cbbSearch.SelectedIndex == 0)
            {
                int ID;

                int.TryParse(Filter, out ID);

                dtvPrograms.RowFilter = $"ProgramID={ID}";

            }
            else if (cbbSearch.SelectedIndex == 1)
            {
                dtvPrograms.RowFilter = $"ProgramName Like '%{Filter}%'";
            }
            else if (cbbSearch.SelectedIndex == 2)
            {
                dtvPrograms.RowFilter = $"Level Like '%{Filter}%'";
            }
            else if (cbbSearch.SelectedIndex == 3)
            {
                int Num;
                int.TryParse(Filter, out Num);
                dtvPrograms.RowFilter = $"NumOfStudents = {Num}";
            }
           

            if (Filter == string.Empty)
            {
                dtvPrograms.RowFilter = string.Empty;
            }

            foreach (DataRowView rowView in dtvPrograms)
            {
                DataRow row = rowView.Row;

                dgvPrograms.Rows.Add(

                     row["ProgramID"],
                    row["ProgramName"],
                    row["Level"],
                    row["NumOfStudents"]
                );
            }
        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {

            string Filter = txtBarSearch.Text.ToString();

            FilterdtPrograms(Filter);




        }
    }
}
