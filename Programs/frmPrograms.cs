using Student_Manager.Main_Screen;
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

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            //here we will create the form of adding new Program :
            frmAddNewProgram frmAddNewProgram = new frmAddNewProgram();
           
            frmAddNewProgram.ShowDialog();
            LoadProgramsInfo();

        }
        private void GetSelectedRow(ref clsCurrentProgram ProgramToUpdate)
        {
            string PID = dgvPrograms.SelectedRows[0].Cells["ProgramID"].Value.ToString();
            ProgramToUpdate.ProgramName = dgvPrograms.SelectedRows[0].Cells["ProgramName"].Value.ToString();
            ProgramToUpdate.Level = dgvPrograms.SelectedRows[0].Cells["Level"].Value.ToString();

            string NumOfStudents = dgvPrograms.SelectedRows[0].Cells["NumOfStudents"].ToString();
            int.TryParse(NumOfStudents, out ProgramToUpdate.NumOfStudents);

            int.TryParse(PID, out ProgramToUpdate.ProgramID);

        }
        private void tsbmUpdate_Click(object sender, EventArgs e)
        {
            if(dgvPrograms.SelectedRows.Count < 0)
                {
                MessageBox.Show("Please select a full row to update", "Warning", MessageBoxButtons.OK);
                return;

            }
            clsCurrentProgram ProgramToUpdate = new clsCurrentProgram();
            GetSelectedRow(ref ProgramToUpdate);
           
            //here we will show the program's form update:
            frmUpdateProgram frmUpdateProgram = new frmUpdateProgram(ProgramToUpdate);
            frmUpdateProgram.ShowDialog();
            LoadProgramsInfo();
        }

        //this function will delete the program:
        private bool DeleteProgram()
        {
            clsCurrentProgram clsCurrentProgram = new clsCurrentProgram();
            GetSelectedRow(ref clsCurrentProgram);
            if (clsCurrentProgram.NumOfStudents > 0) 
            {
                MessageBox.Show("You can not delete a program while there are students in it","Warning",MessageBoxButtons.OK);
                return false ;
            
            }

            return Student_Manager__Business_Logic_Layer.BusinessLogic.DeleteProgramByID(clsCurrentProgram.ProgramID);

        }
        private void tsbmDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrograms.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a full row to update", "Warning", MessageBoxButtons.OK);
                return;

            }

            if (MessageBox.Show("Are you sure want to delete this Program ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (DeleteProgram())
                {
                    MessageBox.Show("Delete the program done successfully", "success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Faild to delete the program try again later", "Warning", MessageBoxButtons.OK);
                }
            }

            LoadProgramsInfo();
        }
    }
}
