namespace Laboratoria.forms
{
    partial class FormPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatients));
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPassport = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelInsurance = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxInsurance = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxFields.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPatients
            // 
            this.listViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this._Name,
            this.Surname,
            this.Birthday,
            this.Phone,
            this.Email});
            this.listViewPatients.FullRowSelect = true;
            this.listViewPatients.GridLines = true;
            this.listViewPatients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPatients.HideSelection = false;
            this.listViewPatients.Location = new System.Drawing.Point(15, 195);
            this.listViewPatients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewPatients.MultiSelect = false;
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(840, 402);
            this.listViewPatients.TabIndex = 0;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            this.listViewPatients.SelectedIndexChanged += new System.EventHandler(this.listViewPatients_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // _Name
            // 
            this._Name.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.Text = "Фамилия";
            this.Surname.Width = 81;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Дата рождения";
            this.Birthday.Width = 104;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 102;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 157;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Laboratoria.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(739, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(117, 108);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonDelete.Location = new System.Drawing.Point(9, 113);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(240, 33);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonEdit.Location = new System.Drawing.Point(9, 73);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(240, 33);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonAdd.Location = new System.Drawing.Point(9, 32);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(240, 33);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelName.Location = new System.Drawing.Point(7, 18);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 15);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxName.Location = new System.Drawing.Point(10, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 23);
            this.textBoxName.TabIndex = 10;
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxFields.Controls.Add(this.maskedTextBoxPassport);
            this.groupBoxFields.Controls.Add(this.dateTimePickerBirthday);
            this.groupBoxFields.Controls.Add(this.labelInsurance);
            this.groupBoxFields.Controls.Add(this.labelPassport);
            this.groupBoxFields.Controls.Add(this.labelEmail);
            this.groupBoxFields.Controls.Add(this.labelPassword);
            this.groupBoxFields.Controls.Add(this.labelPhone);
            this.groupBoxFields.Controls.Add(this.labelSurname);
            this.groupBoxFields.Controls.Add(this.labelBirthday);
            this.groupBoxFields.Controls.Add(this.labelLogin);
            this.groupBoxFields.Controls.Add(this.textBoxInsurance);
            this.groupBoxFields.Controls.Add(this.labelName);
            this.groupBoxFields.Controls.Add(this.textBoxEmail);
            this.groupBoxFields.Controls.Add(this.textBoxPassword);
            this.groupBoxFields.Controls.Add(this.textBoxSurname);
            this.groupBoxFields.Controls.Add(this.textBoxLogin);
            this.groupBoxFields.Controls.Add(this.textBoxName);
            this.groupBoxFields.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBoxFields.Location = new System.Drawing.Point(15, 15);
            this.groupBoxFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFields.Size = new System.Drawing.Size(450, 173);
            this.groupBoxFields.TabIndex = 11;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Информация";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(10, 137);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPhone.Mask = "+7 (999) 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(136, 23);
            this.maskedTextBoxPhone.TabIndex = 14;
            // 
            // maskedTextBoxPassport
            // 
            this.maskedTextBoxPassport.Location = new System.Drawing.Point(298, 88);
            this.maskedTextBoxPassport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPassport.Mask = "0000 999999";
            this.maskedTextBoxPassport.Name = "maskedTextBoxPassport";
            this.maskedTextBoxPassport.Size = new System.Drawing.Size(136, 23);
            this.maskedTextBoxPassport.TabIndex = 13;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(298, 42);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(136, 23);
            this.dateTimePickerBirthday.TabIndex = 11;
            // 
            // labelInsurance
            // 
            this.labelInsurance.AutoSize = true;
            this.labelInsurance.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelInsurance.Location = new System.Drawing.Point(294, 118);
            this.labelInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInsurance.Name = "labelInsurance";
            this.labelInsurance.Size = new System.Drawing.Size(128, 15);
            this.labelInsurance.TabIndex = 9;
            this.labelInsurance.Text = "№ страхового полиса";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPassport.Location = new System.Drawing.Point(294, 68);
            this.labelPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(54, 15);
            this.labelPassport.TabIndex = 9;
            this.labelPassport.Text = "Паспорт";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelEmail.Location = new System.Drawing.Point(150, 118);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = " Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPassword.Location = new System.Drawing.Point(150, 68);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 15);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPhone.Location = new System.Drawing.Point(7, 118);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 15);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Телефон";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelSurname.Location = new System.Drawing.Point(7, 68);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(55, 15);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelBirthday.Location = new System.Drawing.Point(294, 18);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(88, 15);
            this.labelBirthday.TabIndex = 9;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelLogin.Location = new System.Drawing.Point(150, 18);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxInsurance
            // 
            this.textBoxInsurance.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxInsurance.Location = new System.Drawing.Point(298, 137);
            this.textBoxInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInsurance.Name = "textBoxInsurance";
            this.textBoxInsurance.Size = new System.Drawing.Size(136, 23);
            this.textBoxInsurance.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(154, 137);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(136, 23);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(154, 88);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 23);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxSurname.Location = new System.Drawing.Point(10, 88);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(136, 23);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxLogin.Location = new System.Drawing.Point(154, 38);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(136, 23);
            this.textBoxLogin.TabIndex = 10;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonAdd);
            this.groupBoxButtons.Controls.Add(this.buttonEdit);
            this.groupBoxButtons.Controls.Add(this.buttonDelete);
            this.groupBoxButtons.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBoxButtons.Location = new System.Drawing.Point(474, 15);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Size = new System.Drawing.Size(257, 173);
            this.groupBoxButtons.TabIndex = 12;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Действия";
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 606);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxFields);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewPatients);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(880, 645);
            this.Name = "FormPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPatients_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxFields.ResumeLayout(false);
            this.groupBoxFields.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxFields;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelInsurance;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxInsurance;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}