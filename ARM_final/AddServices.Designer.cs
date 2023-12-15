namespace ARM_final
{
    partial class AddServices
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
            textBoxName = new TextBox();
            buttonAdd = new Button();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 93);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Название услуги";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(67, 134);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(264, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(238, 306);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(67, 200);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(136, 28);
            labelPrice.TabIndex = 3;
            labelPrice.Text = " Цена услуги";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(67, 240);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(264, 27);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(108, 29);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 5;
            label2.Text = "Новая услуга";
            // 
            // AddServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(389, 364);
            Controls.Add(label2);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "AddServices";
            Text = "AddServices";
            Load += AddServices_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label label2;
    }
}