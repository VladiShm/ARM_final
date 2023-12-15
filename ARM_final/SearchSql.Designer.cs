namespace ARM_final
{
    partial class SearchSql
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
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            comboBox4 = new ComboBox();
            buttonStart = new Button();
            buttonAdd = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            tabPage1 = new TabPage();
            buttonManyFieldsLeft = new Button();
            buttonOneFieldLeft = new Button();
            buttonManyFieldsRight = new Button();
            buttonOneFieldRight = new Button();
            listBoxFieldsRes = new ListBox();
            listBoxFields = new ListBox();
            tabControl1 = new TabControl();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(811, 442);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Результат";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(788, 430);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(811, 442);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SQL запрос";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(797, 408);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(buttonStart);
            tabPage2.Controls.Add(buttonAdd);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(811, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Условия";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Имя поля";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "and", "or" });
            comboBox4.Location = new Point(569, 39);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(56, 28);
            comboBox4.TabIndex = 6;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(664, 393);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(108, 32);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Выполнить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(653, 39);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(108, 28);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(22, 94);
            listView1.Name = "listView1";
            listView1.Size = new Size(750, 284);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Поле";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Условие";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Значение";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Соединение";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(364, 39);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(189, 28);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonManyFieldsLeft);
            tabPage1.Controls.Add(buttonOneFieldLeft);
            tabPage1.Controls.Add(buttonManyFieldsRight);
            tabPage1.Controls.Add(buttonOneFieldRight);
            tabPage1.Controls.Add(listBoxFieldsRes);
            tabPage1.Controls.Add(listBoxFields);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(811, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поля";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // buttonManyFieldsLeft
            // 
            buttonManyFieldsLeft.Location = new Point(375, 289);
            buttonManyFieldsLeft.Name = "buttonManyFieldsLeft";
            buttonManyFieldsLeft.Size = new Size(60, 36);
            buttonManyFieldsLeft.TabIndex = 5;
            buttonManyFieldsLeft.Text = "<<";
            buttonManyFieldsLeft.UseVisualStyleBackColor = true;
            buttonManyFieldsLeft.Click += buttonManyFieldsLeft_Click;
            // 
            // buttonOneFieldLeft
            // 
            buttonOneFieldLeft.Location = new Point(375, 252);
            buttonOneFieldLeft.Name = "buttonOneFieldLeft";
            buttonOneFieldLeft.Size = new Size(60, 31);
            buttonOneFieldLeft.TabIndex = 4;
            buttonOneFieldLeft.Text = "<";
            buttonOneFieldLeft.UseVisualStyleBackColor = true;
            buttonOneFieldLeft.Click += buttonOneFieldLeft_Click;
            // 
            // buttonManyFieldsRight
            // 
            buttonManyFieldsRight.Location = new Point(375, 163);
            buttonManyFieldsRight.Name = "buttonManyFieldsRight";
            buttonManyFieldsRight.Size = new Size(60, 33);
            buttonManyFieldsRight.TabIndex = 3;
            buttonManyFieldsRight.Text = ">>";
            buttonManyFieldsRight.UseVisualStyleBackColor = true;
            buttonManyFieldsRight.Click += buttonManyFieldsRight_Click;
            // 
            // buttonOneFieldRight
            // 
            buttonOneFieldRight.Location = new Point(375, 124);
            buttonOneFieldRight.Name = "buttonOneFieldRight";
            buttonOneFieldRight.Size = new Size(60, 33);
            buttonOneFieldRight.TabIndex = 2;
            buttonOneFieldRight.Text = ">";
            buttonOneFieldRight.UseVisualStyleBackColor = true;
            buttonOneFieldRight.Click += buttonOneFieldRight_Click;
            // 
            // listBoxFieldsRes
            // 
            listBoxFieldsRes.FormattingEnabled = true;
            listBoxFieldsRes.ItemHeight = 20;
            listBoxFieldsRes.Location = new Point(505, 18);
            listBoxFieldsRes.Name = "listBoxFieldsRes";
            listBoxFieldsRes.Size = new Size(296, 404);
            listBoxFieldsRes.TabIndex = 1;
            listBoxFieldsRes.SelectedIndexChanged += listBoxFieldsRes_SelectedIndexChanged;
            // 
            // listBoxFields
            // 
            listBoxFields.FormattingEnabled = true;
            listBoxFields.ItemHeight = 20;
            listBoxFields.Location = new Point(6, 18);
            listBoxFields.Name = "listBoxFields";
            listBoxFields.Size = new Size(286, 404);
            listBoxFields.TabIndex = 0;
            listBoxFields.SelectedIndexChanged += listBoxFields_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(4, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(819, 475);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // SearchSql
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 476);
            Controls.Add(tabControl1);
            Name = "SearchSql";
            Text = "SearchSql";
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        public DataGridView dataGridView1;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Label label1;
        private ComboBox comboBox4;
        private Button buttonStart;
        private Button buttonAdd;
        public ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TabPage tabPage1;
        private Button buttonManyFieldsLeft;
        private Button buttonOneFieldLeft;
        private Button buttonManyFieldsRight;
        private Button buttonOneFieldRight;
        private ListBox listBoxFieldsRes;
        private ListBox listBoxFields;
        public TabControl tabControl1;
        private TextBox textBox1;
    }
}