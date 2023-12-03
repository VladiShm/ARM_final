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
    public partial class AddVisits : Form
    {
        static SqlCommands commands = new SqlCommands();
        List<int> client_id, master_id, branch_id, price, services_id;

        public AddVisits()
        {
            CenterToParent();
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddMonths(1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
            LoadInfo();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadInfo()
        {
            master_id = new List<int>();
            client_id = new List<int>();
            branch_id = new List<int>();
            services_id = new List<int>();
            price = new List<int>();

            string comm1 = "select id, name, surname from client";
            commands.Connection();
            DataTable dt = new DataTable();
            using (var cmd = new NpgsqlCommand(comm1, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    comboBoxClient.Items.Add($"{item["name"].ToString()} {item["surname"].ToString()}");
                    client_id.Add(Convert.ToInt32(item["id"]));
                }
                comboBoxClient.Items.Add("Свободная запись");
            }

            string comm2 = "select id, name, surname from master";
            commands.Connection();
            DataTable dt2 = new DataTable();
            using (var cmd = new NpgsqlCommand(comm2, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt2.Load(dr);

                foreach (DataRow item in dt2.Rows)
                {
                    comboBoxMaster.Items.Add($"{item["name"].ToString()} {item["surname"].ToString()}");
                    master_id.Add(Convert.ToInt32(item["id"]));
                }
            }

            string comm3 = "select id, address from branches";
            commands.Connection();
            DataTable dt3 = new DataTable();
            using (var cmd = new NpgsqlCommand(comm3, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt3.Load(dr);

                foreach (DataRow item in dt3.Rows)
                {
                    comboBoxAdress.Items.Add($"{item["address"].ToString()}");
                    branch_id.Add(Convert.ToInt32(item["id"]));
                }
            }

            string comm4 = "select id, name, price from services";
            commands.Connection();
            DataTable dt4 = new DataTable();
            using (var cmd = new NpgsqlCommand(comm4, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt4.Load(dr);

                foreach (DataRow item in dt4.Rows)
                {
                    comboBoxServ.Items.Add($"{item["name"].ToString()} {item["price"].ToString()}");
                    services_id.Add(Convert.ToInt32(item["id"]));
                    price.Add(Convert.ToInt32(item["price"]));
                }
            }

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int next_id = 1;
                string comm0 = "select max(id) from visits";
                using (var cmd = new NpgsqlCommand(comm0, commands.strCon))
                {
                    if (cmd.ExecuteScalar() != DBNull.Value)
                    {
                        next_id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    }
                }

                string comm;
                if (comboBoxClient.SelectedItem == "Свободная запись")
                {
                    comm = "insert into visits (id, master_id, date, branch_id, servieces_id) values (@id, @master_id, @date, @branch_id, @servieces_id)";
                }
                else
                {
                    comm = "insert into visits (id, client_id, master_id, date, branch_id, servieces_id) values (@id, @client_id, @master_id, @date, @branch_id, @servieces_id)";
                }
                using (var cmd = new NpgsqlCommand(comm, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("id", next_id);
                    if (comboBoxClient.SelectedItem != "Свободная запись")
                    {
                        cmd.Parameters.AddWithValue("client_id", client_id[comboBoxClient.SelectedIndex]);
                    }

                    cmd.Parameters.AddWithValue("master_id", master_id[comboBoxMaster.SelectedIndex]);
                    cmd.Parameters.AddWithValue("date", dateTimePicker1.Value.ToString());
                    cmd.Parameters.AddWithValue("branch_id", branch_id[comboBoxAdress.SelectedIndex]);
                    cmd.Parameters.AddWithValue("servieces_id", services_id[comboBoxServ.SelectedIndex]);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void comboBoxServ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
