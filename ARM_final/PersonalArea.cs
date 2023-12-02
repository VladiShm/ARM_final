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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ARM_final
{
    public partial class PersonalArea : Form
    {
        string tableName = StartForm.whoIs;
        SqlCommands commands = new SqlCommands();
        public PersonalArea()
        {
            InitializeComponent();
        }

        private void PersonalArea_Load(object sender, EventArgs e)
        {
            CenterToParent();
            LoadInfo();
        }

        public void LoadInfo()
        {
            try
            {
                string sql = $"SELECT name, surname, phone from {tableName} as t join accounts a on " +
                    $"a.id = t.id_account where login = @login and password = @password";
                DataTable dt = new DataTable();
                commands.Connection();
                using (var cmd = new NpgsqlCommand(sql, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("login", StartForm.log);
                    cmd.Parameters.AddWithValue("password", StartForm.pass);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    textBoxName.Text = dr["name"].ToString();
                    textBoxSurname.Text = dr["surname"].ToString();
                    textBoxPhone.Text = dr["phone"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            string old_name = textBoxName.Text;
            string old_surname = textBoxSurname.Text;
            string old_phone = textBoxPhone.Text;
            string sql = $"UPDATE {tableName} SET name = @name, surname = @surname, phone = @phone WHERE id_account = @id";
            commands.Connection();
            using (var cmd = new NpgsqlCommand(sql, commands.strCon))
            {
                cmd.Parameters.AddWithValue("name", textBoxName.Text);
                cmd.Parameters.AddWithValue("surname", textBoxSurname.Text);
                cmd.Parameters.AddWithValue("phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("id", Autorization.acc_id);

                cmd.ExecuteNonQuery();
                this.Close();
            }

        }
    }
}
