namespace ARM_final
{
    partial class AddClient
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(58, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(209, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(58, 193);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(210, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(58, 282);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(211, 27);
            textBoxPhone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 70);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 162);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 6;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 247);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 7;
            label3.Text = "Телефон";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(205, 342);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 41);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 19);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 10;
            label4.Text = "Личные данные";
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(348, 411);
            Controls.Add(label4);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "AddClient";
            Text = "AddClient";
            Load += AddClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Label label4;
    }
}