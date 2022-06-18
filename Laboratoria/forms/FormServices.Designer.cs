namespace Laboratoria.forms
{
    partial class FormServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonAdd);
            this.groupBoxButtons.Controls.Add(this.buttonEdit);
            this.groupBoxButtons.Controls.Add(this.buttonDelete);
            this.groupBoxButtons.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBoxButtons.Location = new System.Drawing.Point(327, 12);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Size = new System.Drawing.Size(188, 123);
            this.groupBoxButtons.TabIndex = 15;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Действия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonAdd.Location = new System.Drawing.Point(9, 18);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 26);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonEdit.Location = new System.Drawing.Point(9, 50);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 26);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonDelete.Location = new System.Drawing.Point(9, 82);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 26);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Controls.Add(this.labelDeadline);
            this.groupBoxFields.Controls.Add(this.labelPrice);
            this.groupBoxFields.Controls.Add(this.labelName);
            this.groupBoxFields.Controls.Add(this.labelCode);
            this.groupBoxFields.Controls.Add(this.textBoxDeadline);
            this.groupBoxFields.Controls.Add(this.textBoxPrice);
            this.groupBoxFields.Controls.Add(this.textBoxName);
            this.groupBoxFields.Controls.Add(this.textBoxCode);
            this.groupBoxFields.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBoxFields.Location = new System.Drawing.Point(13, 12);
            this.groupBoxFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFields.Size = new System.Drawing.Size(306, 123);
            this.groupBoxFields.TabIndex = 14;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Информация";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelDeadline.Location = new System.Drawing.Point(150, 68);
            this.labelDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(102, 15);
            this.labelDeadline.TabIndex = 9;
            this.labelDeadline.Text = "Срок выполнения";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPrice.Location = new System.Drawing.Point(7, 68);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 15);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Цена";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelName.Location = new System.Drawing.Point(150, 18);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 15);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Наименование";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelCode.Location = new System.Drawing.Point(7, 18);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(28, 15);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Код";
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxDeadline.Location = new System.Drawing.Point(154, 88);
            this.textBoxDeadline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.Size = new System.Drawing.Size(136, 23);
            this.textBoxDeadline.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxPrice.Location = new System.Drawing.Point(10, 88);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(136, 23);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxName.Location = new System.Drawing.Point(154, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 23);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.textBoxCode.Location = new System.Drawing.Point(10, 38);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(136, 23);
            this.textBoxCode.TabIndex = 10;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Laboratoria.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(523, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(117, 108);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 13;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewServices
            // 
            this.listViewServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Nickname,
            this.Price,
            this.Deadline});
            this.listViewServices.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.listViewServices.FullRowSelect = true;
            this.listViewServices.GridLines = true;
            this.listViewServices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(11, 141);
            this.listViewServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewServices.MultiSelect = false;
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(630, 448);
            this.listViewServices.TabIndex = 16;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            this.listViewServices.SelectedIndexChanged += new System.EventHandler(this.listViewServices_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Код";
            // 
            // Nickname
            // 
            this.Nickname.Text = "Наименование";
            this.Nickname.Width = 104;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 104;
            // 
            // Deadline
            // 
            this.Deadline.Text = "Срок выполнения, дней";
            this.Deadline.Width = 145;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 601);
            this.Controls.Add(this.listViewServices);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxFields);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(665, 640);
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServices_FormClosed);
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxFields.ResumeLayout(false);
            this.groupBoxFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxFields;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Nickname;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Deadline;
    }
}