using DocumentFormat.OpenXml.Office2010.CustomUI;
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
    public partial class AddServices : Form
    {
        SqlCommands commands = new SqlCommands();
        public AddServices()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string command1 = "select max(id) + 1 from services";
            try
            {
                commands.Connection();
                string command2 = "insert into services (name) values (@name)";
                using (var cmd = new NpgsqlCommand(command2, commands.strCon))
                {
                   // cmd.Parameters.AddWithValue("@id", new_id);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
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
