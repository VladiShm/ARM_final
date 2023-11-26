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
    public partial class AddMaster : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public AddMaster()
        {
            InitializeComponent();
        }

        private void AddMaster_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int mx_id = 1;
                string command = "insert into master (name, surname, phone, grade, id_account) values (@name, @surname, @phone, @grade, @id_account)";
                sqlCommands.Connection();
                string command2 = "select max(id) from accounts";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    object res = cmd.ExecuteScalar();
                    if (res != DBNull.Value)
                    {
                        mx_id = Convert.ToInt32(res);
                    }
                    
                }
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@grade", Convert.ToInt32(textBoxgrade.Text));
                    cmd.Parameters.AddWithValue("@id_account", mx_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
