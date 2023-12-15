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
            int price = 0;

            string command1 = "select max(id) + 1 from services";
            try
            {
                commands.Connection();
                price = int.Parse(textBoxPrice.Text);
                string command2 = "insert into services (name, price) values (@name, @price)";
                using (var cmd = new NpgsqlCommand(command2, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректно введена цена за услугу!");

            }
            this.Close();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddServices_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            labelPrice.BackColor = Color.Transparent;
        }
    }
}
