using DocumentFormat.OpenXml.Office2010.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ARM_final
{
    public partial class DeleteReloadForm : Form
    {
        public static string phone, name, address;
        SqlCommands commands = new SqlCommands();
        public DeleteReloadForm()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void DeleteReloadForm_Load(object sender, EventArgs e)
        {
            commands.Connection();
            try
            {
                string comm = "select name, phone, address from branches";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            commands.Connection();
            try
            {
                string comm = "delete from branches where name = @name";
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

        private void buttonReload_Click(object sender, EventArgs e)
        {
            ChangeBranches changeBranches = new ChangeBranches();
            changeBranches.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox1.SelectedItem.ToString();
        }
    }
}
