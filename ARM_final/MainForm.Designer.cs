namespace ARM_final
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            редактироватьToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem2 = new ToolStripMenuItem();
            удалитьToolStripMenuItem2 = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            listBoxVisits = new ListBox();
            btnSignUp = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelCurrVisits = new Label();
            labelFreeVisits = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            услугиToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(224, 26);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(224, 26);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(224, 26);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem1
            // 
            добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            добавитьToolStripMenuItem1.Size = new Size(224, 26);
            добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(224, 26);
            удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem1
            // 
            редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            редактироватьToolStripMenuItem1.Size = new Size(224, 26);
            редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, услугиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem2, удалитьToolStripMenuItem2, отчетToolStripMenuItem });
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(78, 24);
            клиентыToolStripMenuItem.Text = "Данные";
            // 
            // добавитьToolStripMenuItem2
            // 
            добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            добавитьToolStripMenuItem2.Size = new Size(159, 26);
            добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem2
            // 
            удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            удалитьToolStripMenuItem2.Size = new Size(159, 26);
            удалитьToolStripMenuItem2.Text = "Удалить";
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(159, 26);
            отчетToolStripMenuItem.Text = "Отчет";
            отчетToolStripMenuItem.Click += отчетToolStripMenuItem_Click;
            // 
            // listBoxVisits
            // 
            listBoxVisits.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxVisits.FormattingEnabled = true;
            listBoxVisits.ItemHeight = 20;
            listBoxVisits.Location = new Point(12, 103);
            listBoxVisits.Name = "listBoxVisits";
            listBoxVisits.Size = new Size(598, 504);
            listBoxVisits.TabIndex = 3;
            listBoxVisits.DrawItem += listBox1_DrawItem;
            listBoxVisits.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(12, 613);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(143, 40);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Записаться";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(632, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // labelCurrVisits
            // 
            labelCurrVisits.AutoSize = true;
            labelCurrVisits.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrVisits.Location = new Point(12, 58);
            labelCurrVisits.Name = "labelCurrVisits";
            labelCurrVisits.Size = new Size(171, 28);
            labelCurrVisits.TabIndex = 7;
            labelCurrVisits.Text = "Текущие записи";
            // 
            // labelFreeVisits
            // 
            labelFreeVisits.AutoSize = true;
            labelFreeVisits.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFreeVisits.Location = new Point(12, 58);
            labelFreeVisits.Name = "labelFreeVisits";
            labelFreeVisits.Size = new Size(193, 28);
            labelFreeVisits.TabIndex = 8;
            labelFreeVisits.Text = "Доступные записи";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_многоугольник_96;
            pictureBox3.Location = new Point(730, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(797, 642);
            button1.Name = "button1";
            button1.Size = new Size(11, 10);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // услугиToolStripMenuItem
            // 
            услугиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem3 });
            услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            услугиToolStripMenuItem.Size = new Size(69, 24);
            услугиToolStripMenuItem.Text = "Услуги";
            // 
            // добавитьToolStripMenuItem3
            // 
            добавитьToolStripMenuItem3.Name = "добавитьToolStripMenuItem3";
            добавитьToolStripMenuItem3.Size = new Size(224, 26);
            добавитьToolStripMenuItem3.Text = "Добавить";
            добавитьToolStripMenuItem3.Click += добавитьToolStripMenuItem3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 665);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(labelFreeVisits);
            Controls.Add(labelCurrVisits);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUp);
            Controls.Add(listBoxVisits);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem menuClients;
        private ToolStripMenuItem добавитьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem2;
        public ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem2;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Button btnSignUp;
        public ListBox listBoxVisits;
        public Label labelCurrVisits;
        public Label labelFreeVisits;
        private PictureBox pictureBox3;
        private Button button1;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem3;
    }
}