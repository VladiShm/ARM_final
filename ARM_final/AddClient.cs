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
    public partial class AddClient : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public AddClient()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int mx_id = 1;
                string command = "insert into client (name, surname, phone, id_account) values (@name, @surname, @phone,@id_account)";
                sqlCommands.Connection();
                string command2 = "select max(id) from accounts";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    object res = cmd.ExecuteScalar();
                    mx_id = (res != DBNull.Value) ? Convert.ToInt32(res) : mx_id;
                }

                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@id_account", mx_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            CenterToParent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
    }
}
