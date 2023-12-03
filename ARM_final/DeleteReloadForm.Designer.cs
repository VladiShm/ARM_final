namespace ARM_final
{
    partial class DeleteReloadForm
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
            comboBox1 = new ComboBox();
            buttonDelete = new Button();
            buttonReload = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(59, 227);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 46);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(249, 227);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(136, 46);
            buttonReload.TabIndex = 2;
            buttonReload.Text = "Редактировать";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // DeleteReloadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 329);
            Controls.Add(buttonReload);
            Controls.Add(buttonDelete);
            Controls.Add(comboBox1);
            Name = "DeleteReloadForm";
            Text = "DeleteReloadForm";
            Load += DeleteReloadForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonDelete;
        private Button buttonReload;
    }
}