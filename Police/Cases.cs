using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police
{
    public partial class Cases : Form
    {
        public Cases()
        {
            InitializeComponent();
            ShowCases();
            GetCriminals();
            CountCases();
            OffNameLbl.Text = Login.OffName;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCases()
        {
            Con.Open();
            string Query = "Select * from CaseTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CaseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void GetCriminalName()
        {
            Con.Open();
            string Query = "select * from CriminalTable where CrCode=" + CriminalCb.SelectedValue.ToString() + "";
            SqlCommand cdm = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cdm);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                CrimNameTb.Text = dr["CrName"].ToString();

            }
            Con.Close();
        }

        private void GetCriminals()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CriminalTable", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CrCode", typeof(int));
            dt.Load(Rdr);
            CriminalCb.ValueMember = "CrCode";
            CriminalCb.DataSource = dt;
            Con.Close();
        }
        private void Reset()
        {
            caseheadTb.Text = "";
            CaseDetailsTb.Text = "";
            TypeCb.SelectedIndex = -1;
            PlaceTb.Text = "";
            CrimNameTb.Text = "";
            Key = 0;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (caseheadTb.Text == "" || CaseDetailsTb.Text == "" || TypeCb.SelectedIndex == -1 || PlaceTb.Text == "" || CaseDetailsTb.Text == "" || CrimNameTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CaseTable(CType, CHeading, CDetails,CPlace,CDate,CPerson,CPersonName,PolName)values(@CT,@CH,@CD,@CP,@CDa,@CPer,@CPerN,@polN)", Con);
                    cmd.Parameters.AddWithValue("@CT", TypeCb.Text);
                    cmd.Parameters.AddWithValue("@CH", caseheadTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CaseDetailsTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PlaceTb.Text);
                    cmd.Parameters.AddWithValue("@CDa", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@CPer", CriminalCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CPerN", CriminalCb.Text);

                    cmd.Parameters.AddWithValue("@polN", OffNameLbl.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Case Recorded!");
                    Con.Close();
                    ShowCases();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CriminalCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCriminalName();
        }
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (caseheadTb.Text == "" || CaseDetailsTb.Text == "" || TypeCb.SelectedIndex == -1 || PlaceTb.Text == "" || CaseDetailsTb.Text == "" || CrimNameTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CaseTable Set CType=@CT, CHeading=@CH, CDetails=@CD,CPlace=@CP,CDate=@CDa,CPerson=@CPer,CPersonName=@CPerN,PolName=@polN where Cnum = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CT", TypeCb.Text);
                    cmd.Parameters.AddWithValue("@CH", caseheadTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CaseDetailsTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PlaceTb.Text);
                    cmd.Parameters.AddWithValue("@CDa", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@CPer", CriminalCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CPerN", CriminalCb.Text);

                    cmd.Parameters.AddWithValue("@polN", OffNameLbl.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Case Updated!");
                    Con.Close();
                    ShowCases();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CaseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CaseDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CaseDGV.Rows[e.RowIndex];

                TypeCb.SelectedItem = selectedRow.Cells[1].Value.ToString();
                caseheadTb.Text = selectedRow.Cells[2].Value.ToString();
                CaseDetailsTb.Text = selectedRow.Cells[3].Value.ToString();
                PlaceTb.Text = selectedRow.Cells[4].Value.ToString();
                Date.Text = selectedRow.Cells[5].Value.ToString();
                CrimNameTb.Text = selectedRow.Cells[6].Value.ToString();
                CriminalCb.SelectedValue = selectedRow.Cells[7].Value.ToString();

                if (caseheadTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a case!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CaseTable where Cnum = @CKey", Con);
                    cmd.Parameters.AddWithValue("@Ckey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Case Deleted!");
                    Con.Close();
                    ShowCases();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Polices Obj = new Polices();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Criminals Obj = new Criminals();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Charges Obj = new Charges();
            Obj.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        private void CountCases()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from CaseTable", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CaseLbl.Text = dt.Rows[0][0].ToString() + " Cases";
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
