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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Название услуги";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(29, 68);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(264, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(188, 237);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 39);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(29, 134);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(136, 28);
            labelPrice.TabIndex = 3;
            labelPrice.Text = " Цена услуги";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(29, 174);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(264, 27);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // AddServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 308);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "AddServices";
            Text = "AddServices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Label labelPrice;
        private TextBox textBoxPrice;
    }
}