using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
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
    public partial class AddBranch : Form
    {
        SqlCommands commands = new SqlCommands();
        public AddBranch()
        {
            CenterToParent();
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            commands.Connection();
            string command = "insert into branches (address, name, phone) values (@address, @name, @phone)";
            using (var cmd = new NpgsqlCommand(command, commands.strCon))
            {
                cmd.Parameters.AddWithValue("address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("name", textBoxName.Text);
                cmd.Parameters.AddWithValue("phone", textBoxPhone.Text);
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;

        }
    }
}
