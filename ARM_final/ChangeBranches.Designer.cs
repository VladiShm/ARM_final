namespace ARM_final
{
    partial class ChangeBranches
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 206);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 13;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 155);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 12;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 99);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 11;
            label1.Text = "Адрес";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(380, 283);
            button1.Name = "button1";
            button1.Size = new Size(137, 51);
            button1.TabIndex = 10;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(241, 209);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(212, 27);
            textBoxPhone.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(241, 158);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 27);
            textBoxName.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(241, 102);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(212, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(102, 23);
            label4.Name = "label4";
            label4.Size = new Size(351, 32);
            label4.TabIndex = 14;
            label4.Text = "Новая информация о салоне";
            // 
            // ChangeBranches
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(529, 346);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAddress);
            Name = "ChangeBranches";
            Text = "ChangeBranches";
            Load += ChangeBranches_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private Label label4;
    }
}