namespace KNS.Fabric
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtLoginReg = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.Label();
            this.txtFioReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassCheckReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtErrors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Image = global::KNS.Fabric.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(129, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Выход";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Image = global::KNS.Fabric.Properties.Resources.accept;
            this.btnLogin.Location = new System.Drawing.Point(12, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 35);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "OK";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassReg
            // 
            this.txtPassReg.Location = new System.Drawing.Point(12, 140);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(373, 22);
            this.txtPassReg.TabIndex = 11;
            this.txtPassReg.TextChanged += new System.EventHandler(this.txtPassReg_TextChanged);
            this.txtPassReg.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassReg_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(12, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(65, 18);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Пароль:";
            // 
            // txtLoginReg
            // 
            this.txtLoginReg.Location = new System.Drawing.Point(12, 90);
            this.txtLoginReg.Name = "txtLoginReg";
            this.txtLoginReg.Size = new System.Drawing.Size(373, 22);
            this.txtLoginReg.TabIndex = 9;
            this.txtLoginReg.TextChanged += new System.EventHandler(this.txtLoginReg_TextChanged);
            this.txtLoginReg.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginReg_Validating);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(12, 69);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(145, 18);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.Text = "Имя пользователя:";
            // 
            // txtFioReg
            // 
            this.txtFioReg.Location = new System.Drawing.Point(12, 38);
            this.txtFioReg.Name = "txtFioReg";
            this.txtFioReg.Size = new System.Drawing.Size(373, 22);
            this.txtFioReg.TabIndex = 16;
            this.txtFioReg.TextChanged += new System.EventHandler(this.txtFioReg_TextChanged);
            this.txtFioReg.Validating += new System.ComponentModel.CancelEventHandler(this.txtFioReg_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО:";
            // 
            // txtPassCheckReg
            // 
            this.txtPassCheckReg.Location = new System.Drawing.Point(12, 193);
            this.txtPassCheckReg.Name = "txtPassCheckReg";
            this.txtPassCheckReg.Size = new System.Drawing.Size(373, 22);
            this.txtPassCheckReg.TabIndex = 18;
            this.txtPassCheckReg.TextChanged += new System.EventHandler(this.txtPassCheckReg_TextChanged);
            this.txtPassCheckReg.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassCheckReg_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Повторите пароль:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtErrors
            // 
            this.txtErrors.AutoSize = true;
            this.txtErrors.Location = new System.Drawing.Point(12, 276);
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(0, 17);
            this.txtErrors.TabIndex = 19;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 348);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.txtPassCheckReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFioReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassReg);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginReg);
            this.Controls.Add(this.txtLogin);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtLoginReg;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.TextBox txtFioReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassCheckReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txtErrors;
    }
}