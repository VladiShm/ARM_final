using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_final
{
    public partial class addAccounts : Form
    {
        public static int whoIs;
        SqlCommands sqlCommands = new SqlCommands();
        public addAccounts()
        {
            InitializeComponent();
        }

        private void AddClients_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "insert into accounts (login, password, id_role) values (@login, @password, @id_role)";
                sqlCommands.Connection();
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@password", Autorization.GenerateHash(textBoxPass.Text));
                    cmd.Parameters.AddWithValue("@id_role", (comboBoxRole.SelectedIndex + 1));

                    cmd.ExecuteNonQuery();
                }

                whoIs = comboBoxRole.SelectedIndex + 1;
                if (whoIs == 1)
                {

                }
                else
                {
                    AddMaster addMaster = new AddMaster();
                    addMaster.Show();
                    
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении пользователя");
                this.Close();
            }
        }
    }
}
