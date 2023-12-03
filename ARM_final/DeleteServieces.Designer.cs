namespace ARM_final
{
    partial class DeleteServieces
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
            comboBox1 = new ComboBox();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 0;
            label1.Text = "Услуга";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(176, 165);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 43);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DeleteServieces
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 230);
            Controls.Add(buttonDelete);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "DeleteServieces";
            Text = "DeleteServieces";
            Load += DeleteServieces_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button buttonDelete;
    }
}