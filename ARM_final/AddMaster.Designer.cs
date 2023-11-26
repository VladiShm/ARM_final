namespace ARM_final
{
    partial class AddMaster
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhone = new TextBox();
            textBoxgrade = new TextBox();
            name = new Label();
            surname = new Label();
            phone = new Label();
            grade = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(236, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(192, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(236, 154);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(192, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(236, 210);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(192, 27);
            textBoxPhone.TabIndex = 2;
            // 
            // textBoxgrade
            // 
            textBoxgrade.Location = new Point(236, 266);
            textBoxgrade.Name = "textBoxgrade";
            textBoxgrade.Size = new Size(192, 27);
            textBoxgrade.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(91, 101);
            name.Name = "name";
            name.Size = new Size(39, 20);
            name.TabIndex = 4;
            name.Text = "Имя";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(91, 154);
            surname.Name = "surname";
            surname.Size = new Size(73, 20);
            surname.TabIndex = 5;
            surname.Text = "Фамилия";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(91, 217);
            phone.Name = "phone";
            phone.Size = new Size(69, 20);
            phone.TabIndex = 6;
            phone.Text = "Телефон";
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(91, 273);
            grade.Name = "grade";
            grade.Size = new Size(61, 20);
            grade.TabIndex = 7;
            grade.Text = "Оценка";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(462, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 448);
            Controls.Add(btnAdd);
            Controls.Add(grade);
            Controls.Add(phone);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(textBoxgrade);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "AddMaster";
            Text = "AddMaster";
            Load += AddMaster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhone;
        private TextBox textBoxgrade;
        private Label name;
        private Label surname;
        private Label phone;
        private Label grade;
        private Button btnAdd;
    }
}