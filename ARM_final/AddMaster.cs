using Npgsql;


namespace ARM_final
{
    public partial class AddMaster : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public AddMaster()
        {
            InitializeComponent();
        }

        private void AddMaster_Load(object sender, EventArgs e)
        {
            CenterToParent();
            label1.BackColor = Color.Transparent;
            name.BackColor = Color.Transparent;
            surname.BackColor = Color.Transparent;
            grade.BackColor = Color.Transparent;
            phone.BackColor = Color.Transparent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int mx_id = 1;
                string command = "insert into master (name, surname, phone, grade, id_account) values (@name, @surname, @phone, @grade, @id_account)";
                sqlCommands.Connection();
                string command2 = "select max(id) from accounts";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    object res = cmd.ExecuteScalar();
                    mx_id = (res != DBNull.Value) ? Convert.ToInt32(res) : mx_id;
                }

                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@grade", Convert.ToInt32(textBoxgrade.Text));
                    cmd.Parameters.AddWithValue("@id_account", mx_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void textBoxgrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
