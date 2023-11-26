namespace ARM_final
{

    //форма авторизации
    public partial class Form1 : Form
    {
        SqlCommands commands = new SqlCommands();
        MainForm mainForm = new MainForm();
        public Form1()
        {
            InitializeComponent();
            //this.FormClosing += Form1_FormClosing;
            tbPassword.PasswordChar = '*';
            tbPassword.UseSystemPasswordChar = true;
        }
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Close();
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            commands.Connection();
            CenterToScreen();
            cbPassword.Checked = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                
                Autorization.AutorizationMethod(login, password);
                switch (Autorization.role)
                {
                    case null:
                        MessageBox.Show("Пользователь не найден!");
                        break;
                    case string role when role.Equals("master", StringComparison.OrdinalIgnoreCase):
                        if (login == Autorization.login_a && Autorization.GenerateHash(password) == Autorization.password_a)
                        {
                            mainForm.клиентыToolStripMenuItem.Visible = true;
                            mainForm.Show();                     }
                        break;
                    case "client":
                        if (login == Autorization.login_a && Autorization.GenerateHash(password) == Autorization.password_a)
                        {
                            mainForm.клиентыToolStripMenuItem.Visible = false;
                            mainForm.Show();
 
                        }
                        break;
                }
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.CheckState == CheckState.Checked)
            {
                tbPassword.PasswordChar = '*';
                tbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

    }
}