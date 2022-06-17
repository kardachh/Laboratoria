namespace Laboratoria.forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelHello = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.buttonTakeBiomaterial = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelHello.Location = new System.Drawing.Point(13, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(57, 15);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "labelHello";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelRole.Location = new System.Drawing.Point(13, 27);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(53, 15);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "labelRole";
            // 
            // buttonPatients
            // 
            this.buttonPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPatients.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonPatients.Location = new System.Drawing.Point(16, 108);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(321, 44);
            this.buttonPatients.TabIndex = 5;
            this.buttonPatients.Text = "Пациенты";
            this.buttonPatients.UseVisualStyleBackColor = false;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            this.buttonPatients.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonPatients.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonTakeBiomaterial
            // 
            this.buttonTakeBiomaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonTakeBiomaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTakeBiomaterial.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonTakeBiomaterial.Location = new System.Drawing.Point(16, 158);
            this.buttonTakeBiomaterial.Name = "buttonTakeBiomaterial";
            this.buttonTakeBiomaterial.Size = new System.Drawing.Size(321, 44);
            this.buttonTakeBiomaterial.TabIndex = 5;
            this.buttonTakeBiomaterial.Text = "Принять биоматериал";
            this.buttonTakeBiomaterial.UseVisualStyleBackColor = false;
            this.buttonTakeBiomaterial.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonTakeBiomaterial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonServices.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonServices.Location = new System.Drawing.Point(16, 208);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(321, 44);
            this.buttonServices.TabIndex = 5;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonServices.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonLeave
            // 
            this.buttonLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeave.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.buttonLeave.Location = new System.Drawing.Point(12, 311);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(151, 44);
            this.buttonLeave.TabIndex = 5;
            this.buttonLeave.Text = "Выход";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            this.buttonLeave.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonLeave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(239, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 6;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Laboratoria.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(239, 258);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(98, 97);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 367);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonTakeBiomaterial);
            this.Controls.Add(this.buttonPatients);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Button buttonTakeBiomaterial;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}