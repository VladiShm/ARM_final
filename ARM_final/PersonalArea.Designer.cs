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
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva
            // 
            pictureBoxAva.Image = (Image)resources.GetObject("pictureBoxAva.Image");
            pictureBoxAva.Location = new Point(24, 24);
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
            btnSaveChange.Location = new Point(523, 375);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(64, 63);
            btnSaveChange.TabIndex = 1;
            btnSaveChange.UseVisualStyleBackColor = true;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(306, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 27);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(308, 120);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(222, 27);
            textBoxSurname.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(308, 195);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(221, 27);
            textBoxPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(305, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 24);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(305, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(305, 164);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 8;
            label3.Text = "Телефон";
            // 
            // PersonalArea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
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
    }
}