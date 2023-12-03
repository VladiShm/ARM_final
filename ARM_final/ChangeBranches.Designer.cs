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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 152);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 13;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 101);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 12;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 11;
            label1.Text = "Адрес";
            // 
            // button1
            // 
            button1.Location = new Point(299, 232);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 10;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(200, 155);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(212, 27);
            textBoxPhone.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(200, 104);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 27);
            textBoxName.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(200, 48);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(212, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // ChangeBranches
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 288);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAddress);
            Name = "ChangeBranches";
            Text = "ChangeBranches";
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
    }
}