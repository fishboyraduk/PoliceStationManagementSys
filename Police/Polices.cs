using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Police
{
    public partial class Polices : Form
    {
        public Polices()
        {
            InitializeComponent();
            ShowPolice();
            CountCases();
            OffNameLbl.Text = Login.OffName;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowPolice()
        {
            Con.Open();
            string Query = "Select * from PoliceTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PolicesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            AddressTb.Text = "";
            PhoneTb.Text = "";
            DesignationCb.SelectedIndex = -1;
            PasswordTb.Text = "";
            NameTb.Text = "";
            Key = 0;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || PasswordTb.Text == "" || NameTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into PoliceTable(EmpName, EmpAddress, EmpPhone,EmpDes,EmpPas)values(@EN,@EA,@EP,@ED,@EPa)", Con);
                    cmd.Parameters.AddWithValue("@EN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Recorded!");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int Key = 0;
        private void PoliciesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < PolicesDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = PolicesDGV.Rows[e.RowIndex];

                NameTb.Text = selectedRow.Cells[1].Value.ToString();
                AddressTb.Text = selectedRow.Cells[2].Value.ToString();
                PhoneTb.Text = selectedRow.Cells[3].Value.ToString();
                DesignationCb.SelectedItem = selectedRow.Cells[4].Value.ToString();
                PasswordTb.Text = selectedRow.Cells[5].Value.ToString();
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an officer!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PoliceTable where EmpCode = @PKey", Con);
                    cmd.Parameters.AddWithValue("@Pkey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Deleted!");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || PasswordTb.Text == "" || NameTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update PoliceTable Set EmpName=@EN,EmpAddress=@EA,EmpPhone=@EP,EmpDes=@ED,EmpPas=@EPa where EmpCode =@Pkey", Con);
                    cmd.Parameters.AddWithValue("@Pkey", Key);
                    cmd.Parameters.AddWithValue("@EN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Recorded!");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Charges Obj = new Charges();
            Obj.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
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
    }
}
