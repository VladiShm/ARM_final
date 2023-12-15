namespace ARM_final
{
    partial class addAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            comboBoxRole = new ComboBox();
            labelLogin = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            buttonAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(101, 108);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(235, 27);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(101, 196);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(235, 27);
            textBoxPass.TabIndex = 1;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Клиент", "Мастер" });
            comboBoxRole.Location = new Point(101, 277);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(235, 28);
            comboBoxRole.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(101, 77);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(72, 28);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(101, 165);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 28);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRole.Location = new Point(101, 246);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(57, 28);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(241, 350);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(153, 47);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 23);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 7;
            label1.Text = "Новый аккаунт";
            // 
            // addAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(431, 420);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(labelRole);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Name = "addAccounts";
            Text = "AddClients";
            Load += AddClients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private ComboBox comboBoxRole;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelRole;
        private Button buttonAdd;
        private Label label1;
    }
}