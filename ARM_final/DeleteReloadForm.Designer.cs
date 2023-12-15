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
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(29, 235);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(154, 46);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReload.Location = new Point(238, 235);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(151, 46);
            buttonReload.TabIndex = 2;
            buttonReload.Text = "Редактировать";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 3;
            label1.Text = "Корректирование информации о салоне";
            // 
            // DeleteReloadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1670037622_1_kartinkin_net_p_fioletovo_sirenevii_fon_pinterest_2;
            ClientSize = new Size(428, 323);
            Controls.Add(label1);
            Controls.Add(buttonReload);
            Controls.Add(buttonDelete);
            Controls.Add(comboBox1);
            Name = "DeleteReloadForm";
            Text = "DeleteReloadForm";
            Load += DeleteReloadForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonDelete;
        private Button buttonReload;
        private Label label1;
    }
}