namespace ARM_final
{

    //ÙÓÏ‡ ‡‚ÚÓËÁ‡ˆËË
    public partial class StartForm : Form
    {
        static public string pass, log, whoIs;
        SqlCommands commands = new SqlCommands();
        MainForm mainForm = new MainForm();
        public StartForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = 'ï';
            tbPassword.UseSystemPasswordChar = cbPassword.Checked;
        }

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
            var p = Autorization.NewHash(Autorization.GenerateHash(password));
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                Autorization.AutorizationMethod(login, password);
                switch (Autorization.role)
                {
                    case null:
                        MessageBox.Show("œÓÎ¸ÁÓ‚‡ÚÂÎ¸ ÌÂ Ì‡È‰ÂÌ!");
                        break;
                    case "master":
                        if (login == Autorization.login_a && Autorization.NewHash(Autorization.GenerateHash(password)) == Autorization.password_a)
                        {
                            whoIs = "master";
                            pass = Autorization.password_a;
                            log = Autorization.login_a;
                            mainForm.listBoxVisits.Visible = false;
                            mainForm.btnSignUp.Visible = false;
                            mainForm.labelFreeVisits.Visible = false;
                            mainForm.Show();
                            mainForm.Visits();
                            this.Hide();
                        }
                        break;
                    case "client":
                        if (login == Autorization.login_a && Autorization.NewHash(Autorization.GenerateHash(password)) == Autorization.password_a)
                        {
                            whoIs = "client";
                            pass = Autorization.password_a;
                            log = Autorization.login_a;
                            mainForm.listBoxAddVisits.Visible = false;
                            mainForm.buttonAddVisits.Visible = false;
                            mainForm.FreeVisits();
                            mainForm.Ò‡ÎÓÌ˚ToolStripMenuItem.Visible = false;
                            mainForm.ÛÒÎÛ„ËToolStripMenuItem.Visible = false;
                            mainForm.labelCurrVisits.Visible = false;
                            mainForm.ÍÎËÂÌÚ˚ToolStripMenuItem.Visible = false;
                            mainForm.Show();
                            this.Hide();
                        }
                        break;
                }
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = ((CheckBox)sender).Checked;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}