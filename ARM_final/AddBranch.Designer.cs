namespace ARM_final
{
    partial class AddBranch
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
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(217, 119);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(212, 27);
            textBoxAddress.TabIndex = 0;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(217, 175);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox2_TextChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(217, 226);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(212, 27);
            textBoxPhone.TabIndex = 2;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(304, 298);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 116);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 4;
            label1.Text = "Адрес";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 172);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 5;
            label2.Text = "Название";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 223);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 6;
            label3.Text = "Телефон";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(150, 34);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 7;
            label4.Text = "Новый салон";
            // 
            // AddBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(497, 368);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAddress);
            Name = "AddBranch";
            Text = "AddBranch";
            Load += AddBranch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}