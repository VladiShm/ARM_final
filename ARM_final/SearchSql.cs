using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ARM_final
{
    public partial class SearchSql : Form
    {
        SqlCommands commands = new SqlCommands();
        public SearchSql()
        {
            InitializeComponent();
            try
            {
                DataTable dt = commands.GetData(@"select translate from metadata");
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxFields.Items.Add(dr["translate"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        private void listBoxFieldsRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOneFieldRight_Click(object sender, EventArgs e)
        {
            if (!listBoxFieldsRes.Items.Contains(listBoxFields.SelectedItems[0]))
                listBoxFieldsRes.Items.Add(listBoxFields.SelectedItems[0]);
        }

        private void buttonManyFieldsRight_Click(object sender, EventArgs e)
        {
            foreach (var i in listBoxFields.Items)
            {
                if (!listBoxFieldsRes.Items.Contains(i))
                    listBoxFieldsRes.Items.Add(i);
            }
        }

        private void buttonOneFieldLeft_Click(object sender, EventArgs e)
        {
            listBoxFieldsRes.Items.Remove(listBoxFieldsRes.SelectedItems[0]);
        }

        private void buttonManyFieldsLeft_Click(object sender, EventArgs e)
        {
            listBoxFieldsRes.Items.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var i in listBoxFieldsRes.Items)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com1 = "select column_name, table_name from metadata where translate = @translate";
            string column_name = "";
            string table_name = "";
            DataTable dt = new DataTable();
            commands.Connection();
            using (var cmd = new NpgsqlCommand(com1, commands.strCon))
            {
                cmd.Parameters.AddWithValue("translate", comboBox1.SelectedItem);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    column_name = item["column_name"].ToString();
                    table_name = item["table_name"].ToString();
                }
            }

            string com2 = $"select {column_name} from {table_name}";
            using (var cmd = new NpgsqlCommand(com2, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    if (!comboBox3.Items.Contains(item[$"{column_name}"].ToString()) && !string.IsNullOrEmpty(item[$"{column_name}"].ToString()))
                        comboBox3.Items.Add(item[$"{column_name}"].ToString());
                }
            }



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string> { comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString() };
            listView1.Items.Add(new ListViewItem(fields.ToArray()));

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            foreach (ListViewItem row in listView1.Items)
            {
                string column_name = "";
                string table_name = "";
                string com1 = "select column_name, table_name from metadata where translate = @translate";
                DataTable dt = new DataTable();
                using (var cmd = new NpgsqlCommand(com1, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("translate", row.SubItems[0].Text);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow item in dt.Rows)
                    {
                        column_name = item["column_name"].ToString();
                        table_name = item["table_name"].ToString();
                    }
                }
       
                string com2 = $"select {column_name} from {table_name} where {column_name} {comboBox2.SelectedItem} @param";
                DataTable dt2 = new DataTable();
                using (var cmd = new NpgsqlCommand(com2, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("param", comboBox3.SelectedItem);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt2.Load(dr);
                }
                data.Merge(dt2);
                //foreach (DataRow i in dt2.Rows)
                //{
                //    data.Rows.Add(i.ItemArray[0]);
                //}
            }
            dataGridView1.DataSource = data;

        }
    }
}
