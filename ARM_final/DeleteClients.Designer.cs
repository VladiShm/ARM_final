namespace arm_rental
{
    partial class DeleteClients
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
            label1 = new Label();
            comboBoxClient = new ComboBox();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 76);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 0;
            label1.Text = "Удалить клиента";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(62, 141);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(270, 28);
            comboBoxClient.TabIndex = 1;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(231, 261);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(155, 51);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // DeleteClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ARM_final.Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(398, 335);
            Controls.Add(buttonDel);
            Controls.Add(comboBoxClient);
            Controls.Add(label1);
            Name = "DeleteClients";
            Text = "DeleteClients";
            Load += DeleteClients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxClient;
        private Button buttonDel;
    }
}