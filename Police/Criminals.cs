using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace Police
{
    public partial class Criminals : Form
    {
        public Criminals()
        {
            InitializeComponent();
            ShowCriminals();
            CountCases();
            OffNameLbl.Text = Login.OffName;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCriminals()
        {
            Con.Open();
            string Query = "Select * from CriminalTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CriminalDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AddressTb.Text == "" || ActivityTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CriminalTable(CrName, CrAdd, CrActivities)values(@CN,@CA,@CrA)", Con);
                    cmd.Parameters.AddWithValue("@CN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@CrA", ActivityTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Recorded!");
                    Con.Close();
                    ShowCriminals();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void CriminalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CriminalDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CriminalDGV.Rows[e.RowIndex];

                NameTb.Text = selectedRow.Cells[1].Value.ToString();
                AddressTb.Text = selectedRow.Cells[2].Value.ToString();
                ActivityTb.Text = selectedRow.Cells[3].Value.ToString();

                if (NameTb.Text == "")
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
            if (NameTb.Text == "" || AddressTb.Text == "" || ActivityTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CriminalTable Set CrName=@CN,CrAdd=@CA,CrActivities=@CrA where CrCode = @Ckey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.Parameters.AddWithValue("@CN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@CrA", ActivityTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Recorded!");
                    Con.Close();
                    ShowCriminals();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            NameTb.Text = "";
            AddressTb.Text = "";
            ActivityTb.Text = "";
            Key = 0;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Criminal!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CriminalTable where CrCode = @Ckey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Deleted!");
                    Con.Close();
                    ShowCriminals();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Cases Obj = new Cases();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Charges Obj = new Charges();
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
