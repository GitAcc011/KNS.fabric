namespace KNS.Fabric
{
    partial class ManagerForm
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
            this.btExit = new System.Windows.Forms.Button();
            this.btOrderManage = new System.Windows.Forms.Button();
            this.btNewOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Image = global::KNS.Fabric.Properties.Resources.exit;
            this.btExit.Location = new System.Drawing.Point(11, 242);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(481, 35);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Выход";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btOrderManage
            // 
            this.btOrderManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btOrderManage.Image = global::KNS.Fabric.Properties.Resources.form_edit;
            this.btOrderManage.Location = new System.Drawing.Point(11, 201);
            this.btOrderManage.Name = "btOrderManage";
            this.btOrderManage.Size = new System.Drawing.Size(481, 35);
            this.btOrderManage.TabIndex = 5;
            this.btOrderManage.Text = "Управление заказами";
            this.btOrderManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOrderManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrderManage.UseVisualStyleBackColor = true;
            this.btOrderManage.Click += new System.EventHandler(this.btOrderManage_Click);
            // 
            // btNewOrder
            // 
            this.btNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNewOrder.Image = global::KNS.Fabric.Properties.Resources.add;
            this.btNewOrder.Location = new System.Drawing.Point(12, 160);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(481, 35);
            this.btNewOrder.TabIndex = 4;
            this.btNewOrder.Text = "Новый заказ";
            this.btNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNewOrder.UseVisualStyleBackColor = true;
            this.btNewOrder.Click += new System.EventHandler(this.btNewOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KNS.Fabric.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(167, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOrderManage);
            this.Controls.Add(this.btNewOrder);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран менеджера (%Имя пользователя%)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btOrderManage;
        private System.Windows.Forms.Button btNewOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}