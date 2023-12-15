namespace ARM_final
{
    partial class PersonalArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalArea));
            pictureBoxAva = new PictureBox();
            btnSaveChange = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva
            // 
            pictureBoxAva.BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            pictureBoxAva.Image = (Image)resources.GetObject("pictureBoxAva.Image");
            pictureBoxAva.Location = new Point(3, 12);
            pictureBoxAva.Name = "pictureBoxAva";
            pictureBoxAva.Size = new Size(193, 209);
            pictureBoxAva.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAva.TabIndex = 0;
            pictureBoxAva.TabStop = false;
            // 
            // btnSaveChange
            // 
            btnSaveChange.BackgroundImage = (Image)resources.GetObject("btnSaveChange.BackgroundImage");
            btnSaveChange.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveChange.Location = new Point(505, 339);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(58, 61);
            btnSaveChange.TabIndex = 1;
            btnSaveChange.UseVisualStyleBackColor = true;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(271, 41);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(258, 38);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(271, 141);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(258, 38);
            textBoxSurname.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(271, 231);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(259, 41);
            textBoxPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 31);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(272, 107);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(270, 197);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 8;
            label3.Text = "Телефон";
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete.Location = new Point(435, 339);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(64, 61);
            buttonDelete.TabIndex = 9;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // PersonalArea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(588, 412);
            Controls.Add(buttonDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(btnSaveChange);
            Controls.Add(pictureBoxAva);
            Name = "PersonalArea";
            Text = "PersonalArea";
            Load += PersonalArea_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAva;
        private Button btnSaveChange;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonDelete;
    }
}