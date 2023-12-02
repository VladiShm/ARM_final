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
            textBoxLogin.Location = new Point(31, 51);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(205, 27);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(31, 131);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(205, 27);
            textBoxPass.TabIndex = 1;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Клиент", "Мастер" });
            comboBoxRole.Location = new Point(31, 220);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(205, 28);
            comboBoxRole.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(31, 20);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(72, 28);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(31, 99);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 28);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRole.Location = new Point(31, 178);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(57, 28);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(83, 278);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(153, 35);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // addAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 342);
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
    }
}