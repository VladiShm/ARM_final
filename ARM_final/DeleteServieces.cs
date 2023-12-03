using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Wordprocessing;
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
using System.Xml.Linq;

namespace ARM_final
{
    public partial class DeleteServieces : Form
    {
        static string name;
        SqlCommands commands = new SqlCommands();
        public DeleteServieces()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            commands.Connection();
            try
            {
                string comm = "delete from services where name = @name";
                using (var cmd = new NpgsqlCommand(comm, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("name", comboBox1.SelectedItem);
                    name = comboBox1.SelectedItem.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox1.SelectedItem.ToString();
        }

        private void DeleteServieces_Load(object sender, EventArgs e)
        {
            commands.Connection();
            try
            {
                string comm = "select name from services";
                DataTable dt = new DataTable();
                using (var cmd = new NpgsqlCommand(comm, commands.strCon))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow item in dt.Rows)
                    {
                        comboBox1.Items.Add(item["name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
