namespace ARM_final
{
    partial class AddVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisits));
            comboBoxClient = new ComboBox();
            comboBoxServ = new ComboBox();
            comboBoxAdress = new ComboBox();
            comboBoxMaster = new ComboBox();
            labelClient = new Label();
            labelMaster = new Label();
            labelAdress = new Label();
            labelServices = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelDate = new Label();
            buttonAdd = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(271, 74);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(221, 28);
            comboBoxClient.TabIndex = 4;
            comboBoxClient.SelectedIndexChanged += comboBoxClient_SelectedIndexChanged;
            // 
            // comboBoxServ
            // 
            comboBoxServ.FormattingEnabled = true;
            comboBoxServ.Location = new Point(271, 254);
            comboBoxServ.Name = "comboBoxServ";
            comboBoxServ.Size = new Size(221, 28);
            comboBoxServ.TabIndex = 5;
            comboBoxServ.SelectedIndexChanged += comboBoxServ_SelectedIndexChanged;
            // 
            // comboBoxAdress
            // 
            comboBoxAdress.FormattingEnabled = true;
            comboBoxAdress.Location = new Point(271, 198);
            comboBoxAdress.Name = "comboBoxAdress";
            comboBoxAdress.Size = new Size(221, 28);
            comboBoxAdress.TabIndex = 7;
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(271, 136);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(221, 28);
            comboBoxMaster.TabIndex = 8;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.Location = new Point(116, 71);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(82, 28);
            labelClient.TabIndex = 9;
            labelClient.Text = "Клиент";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMaster.Location = new Point(116, 136);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(81, 28);
            labelMaster.TabIndex = 11;
            labelMaster.Text = "Мастер";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(116, 195);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(80, 28);
            labelAdress.TabIndex = 12;
            labelAdress.Text = "Адресс";
            // 
            // labelServices
            // 
            labelServices.AutoSize = true;
            labelServices.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelServices.Location = new Point(116, 251);
            labelServices.Name = "labelServices";
            labelServices.Size = new Size(77, 28);
            labelServices.TabIndex = 13;
            labelServices.Text = "Услуга";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 314);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(125, 313);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(56, 28);
            labelDate.TabIndex = 16;
            labelDate.Text = "Дата";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(281, 375);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 46);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // AddVisits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(515, 474);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAdd);
            Controls.Add(labelDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelServices);
            Controls.Add(labelAdress);
            Controls.Add(labelMaster);
            Controls.Add(labelClient);
            Controls.Add(comboBoxMaster);
            Controls.Add(comboBoxAdress);
            Controls.Add(comboBoxServ);
            Controls.Add(comboBoxClient);
            Name = "AddVisits";
            Text = "AddVisits";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxClient;
        private ComboBox comboBoxServ;
        private ComboBox comboBoxAdress;
        private ComboBox comboBoxMaster;
        private Label labelClient;
        private Label labelMaster;
        private Label labelAdress;
        private Label labelServices;
        private DateTimePicker dateTimePicker1;
        private Label labelDate;
        private Button buttonAdd;
        private PictureBox pictureBox1;
    }
}