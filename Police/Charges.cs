using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police
{
    public partial class Charges : Form
    {
        public Charges()
        {
            InitializeComponent();
            ShowCharges();
            GetCase();
            CountCases();
            OffNameLbl.Text = Login.OffName;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCharges()
        {
            Con.Open();
            string Query = "Select * from ChargesTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ChargeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void GetCaseName()
        {
            Con.Open();
            string Query = "select * from CaseTable where Cnum=" + CaseCb.SelectedValue.ToString() + "";
            SqlCommand cdm = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cdm);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                CaseHeadingTb.Text = dr["CHeading"].ToString();

            }
            Con.Close();
        }

        private void GetCase()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CaseTable", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Cnum", typeof(int));
            dt.Load(Rdr);
            CaseCb.ValueMember = "Cnum";
            CaseCb.DataSource = dt;
            Con.Close();
        }
        int Key = 0;
        private void Reset()
        {
            CaseHeadingTb.Text = "";
            ChargeSheetTb.Text = "";
            RemarksTb.Text = "";
            CaseCb.SelectedIndex = -1;
            Key = 0;
        }
        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (CaseHeadingTb.Text == "" || ChargeSheetTb.Text == "" || RemarksTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ChargesTable(CaseCode, CaseHeading, ChargeSheet,Remarks,PolName)values(@CC,@CH,@CS,@Rem,@polN)", Con);
                    cmd.Parameters.AddWithValue("@CC", CaseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CH", CaseHeadingTb.Text);
                    cmd.Parameters.AddWithValue("@CS", ChargeSheetTb.Text);
                    cmd.Parameters.AddWithValue("@Rem", RemarksTb.Text);
                    cmd.Parameters.AddWithValue("@polN", OffNameLbl.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Charge Recorded!");
                    Con.Close();
                    ShowCharges();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CaseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCaseName();
        }

        private void ChargeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ChargeDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = ChargeDGV.Rows[e.RowIndex];

                CaseCb.SelectedValue = selectedRow.Cells[1].Value.ToString();
                CaseHeadingTb.Text = selectedRow.Cells[2].Value.ToString();
                ChargeSheetTb.Text = selectedRow.Cells[3].Value.ToString();
                RemarksTb.Text = selectedRow.Cells[4].Value.ToString();


                if (CaseHeadingTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CaseHeadingTb.Text == "" || ChargeSheetTb.Text == "" || RemarksTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ChargesTable set CaseCode=@CC, CaseHeading=@CH, ChargeSheet=@CS,Remarks=@Rem,PolName=@polN where ChNum=@ChKey", Con);
                    cmd.Parameters.AddWithValue("@CC", CaseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CH", CaseHeadingTb.Text);
                    cmd.Parameters.AddWithValue("@CS", ChargeSheetTb.Text);
                    cmd.Parameters.AddWithValue("@Rem", RemarksTb.Text);
                    cmd.Parameters.AddWithValue("@polN", OffNameLbl.Text);
                    cmd.Parameters.AddWithValue("@ChKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Charge Updated!");
                    Con.Close();
                    ShowCharges();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Charge!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ChargesTable where ChNum = @Ckey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Charge Deleted!");
                    Con.Close();
                    ShowCharges();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Cases Obj = new Cases();
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
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
