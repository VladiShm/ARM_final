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
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(211, 48);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(205, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(211, 102);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(205, 27);
            textBoxPass.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Клиент", "Мастер" });
            comboBoxRole.Location = new Point(214, 161);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(202, 28);
            comboBoxRole.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(56, 51);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 20);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(56, 109);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(66, 161);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(42, 20);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(162, 240);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(153, 28);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 280);
            Controls.Add(buttonAdd);
            Controls.Add(labelRole);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Name = "AddClients";
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
    }
}