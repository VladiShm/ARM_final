﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ARM_final
{
    public partial class MainForm : Form
    {

        string master, branch, time;
        List<int> idFreeVisits = new List<int>();

        SqlCommands commands = new SqlCommands();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            commands.Connection();
            LoadBranches();
            CenterToParent();
            //FreeVisits();
        }
        private void LoadBranches()
        {
            treeView.Nodes.Clear();
            DataTable dt = commands.GetData(@"select name, id from branches");
            foreach (DataRow dr in dt.Rows)
            {
                string branchName = dr["name"].ToString();
                var node = new TreeNode(branchName, 0, 0);
                treeView.Nodes.Add(node);
                node.Tag = dr["id"].ToString();
                LoadVisits(node, (int)dr["id"]);
            }
        }

        private void LoadVisits(TreeNode parent, int branch_id)
        {
            try
            {
                DataTable dt = commands.GetData(@"select v.id, m.name, m.surname from visits as v join master as m on m.id = v.master_id where branch_id = @branch_id; ", branch_id, "@branch_id");
                foreach (DataRow dr in dt.Rows)
                {
                    string visitDate = $"Мастер: {dr["name"].ToString()} {dr["surname"].ToString()}";
                    var node = new TreeNode(visitDate, 1, 1);
                    parent.Nodes.Add(node);
                    node.Tag = dr["id"].ToString();
                    LoadServices(node, (int)dr["id"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadServices(TreeNode parent, int visit_id)
        {
            try
            {
                DataTable dt = commands.GetData(@"select id, name from services where visit_id = @visit_id", visit_id, "visit_id");
                foreach (DataRow dr in dt.Rows)
                {
                    string service = dr["name"].ToString();
                    var node = new TreeNode(service, 2, 2);
                    parent.Nodes.Add(node);
                    node.Tag = dr["id"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //добавление новых клиентов/мастеров
        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addAccounts addClients = new addAccounts();
            addClients.Show();
        }

        //редактирование новых клиентов/мастеров


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void FreeVisits()
        {
            try
            {
                DataTable dt = commands.GetData(@"select v.id, m.name, m.surname, address, date from visits as v join master as m on 
                                            m.id = v.master_id join branches as b on b.id = v.branch_id 
                                            where v.client_id is null");
                foreach (DataRow dr in dt.Rows)
                {
                    idFreeVisits.Add(int.Parse(dr["id"].ToString()));
                    master = $"Мастер: {dr["name"].ToString()} {dr["surname"].ToString()}";
                    branch = $"Арес: {dr["address"].ToString()}\n";
                    time = $"Дата и время: {dr["date"].ToString()}";
                    string info = $"{master}-{branch}-{time}";
                    listBoxVisits.Items.Add(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonalArea pa = new PersonalArea();
            pa.Show();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Отрисовка текста элемента
            e.DrawBackground();
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            using (Brush brush = new SolidBrush(isSelected ? Color.White : Color.Black))
            {
                e.Graphics.DrawString(listBoxVisits.Items[e.Index].ToString(), e.Font, brush, e.Bounds);
            }

            // Отрисовка разделителя
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }

            e.DrawFocusRectangle();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //int selectedId = listBox1.SelectedIndex;
            try
            {
                int id;
                commands.Connection();
                string command2 = "select c.id from client as c join accounts as a on a.id = c.id_account";
                using (var cmd = new NpgsqlCommand(command2, commands.strCon))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string command = "update visits set client_id = @client where id = @id";
                using (var cmd = new NpgsqlCommand(command, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("client", id);
                    cmd.Parameters.AddWithValue("id", idFreeVisits[listBoxVisits.SelectedIndex]);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Вы записаны!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
