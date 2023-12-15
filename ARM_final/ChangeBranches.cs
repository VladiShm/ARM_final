using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_final
{
    public partial class ChangeBranches : Form
    {
        SqlCommands commands = new SqlCommands();
        string old_name;
        public ChangeBranches()
        {
            InitializeComponent();
            Reload();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"UPDATE branches SET name = @name, address = @address, phone = @phone WHERE name = @old_name";
                commands.Connection();
                using (var cmd = new NpgsqlCommand(sql, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("old_name", old_name);

                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reload()
        {
            try
            {
                string comm = "select address, phone from branches where name = @name";
                DataTable dt = new DataTable();
                commands.Connection();
                using (var cmd = new NpgsqlCommand(comm, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("name", DeleteReloadForm.name);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow item in dt.Rows)
                    {
                        textBoxAddress.Text = item["address"].ToString();
                        textBoxName.Text = DeleteReloadForm.name;
                        textBoxPhone.Text = item["phone"].ToString();
                    }
                    old_name = textBoxName.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeBranches_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
    }
}
