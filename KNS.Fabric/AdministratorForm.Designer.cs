namespace KNS.Fabric
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btProductList = new System.Windows.Forms.Button();
            this.btFurnitureList = new System.Windows.Forms.Button();
            this.btMaterialList = new System.Windows.Forms.Button();
            this.btOrderList = new System.Windows.Forms.Button();
            this.btUserList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Image = global::KNS.Fabric.Properties.Resources.exit;
            this.btExit.Location = new System.Drawing.Point(12, 375);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(529, 35);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Выход";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KNS.Fabric.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(167, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btProductList
            // 
            this.btProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btProductList.Image = ((System.Drawing.Image)(resources.GetObject("btProductList.Image")));
            this.btProductList.Location = new System.Drawing.Point(12, 334);
            this.btProductList.Name = "btProductList";
            this.btProductList.Size = new System.Drawing.Size(529, 35);
            this.btProductList.TabIndex = 10;
            this.btProductList.Text = "Список изделий";
            this.btProductList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProductList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProductList.UseVisualStyleBackColor = true;
            this.btProductList.Click += new System.EventHandler(this.btProductList_Click);
            // 
            // btFurnitureList
            // 
            this.btFurnitureList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btFurnitureList.Image = ((System.Drawing.Image)(resources.GetObject("btFurnitureList.Image")));
            this.btFurnitureList.Location = new System.Drawing.Point(12, 293);
            this.btFurnitureList.Name = "btFurnitureList";
            this.btFurnitureList.Size = new System.Drawing.Size(529, 35);
            this.btFurnitureList.TabIndex = 9;
            this.btFurnitureList.Text = "Список фурнитуры";
            this.btFurnitureList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFurnitureList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFurnitureList.UseVisualStyleBackColor = true;
            this.btFurnitureList.Click += new System.EventHandler(this.btFurnitureList_Click);
            // 
            // btMaterialList
            // 
            this.btMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaterialList.Image = ((System.Drawing.Image)(resources.GetObject("btMaterialList.Image")));
            this.btMaterialList.Location = new System.Drawing.Point(12, 252);
            this.btMaterialList.Name = "btMaterialList";
            this.btMaterialList.Size = new System.Drawing.Size(529, 35);
            this.btMaterialList.TabIndex = 8;
            this.btMaterialList.Text = "Список тканей";
            this.btMaterialList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMaterialList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMaterialList.UseVisualStyleBackColor = true;
            this.btMaterialList.Click += new System.EventHandler(this.btMaterialList_Click);
            // 
            // btOrderList
            // 
            this.btOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btOrderList.Image = ((System.Drawing.Image)(resources.GetObject("btOrderList.Image")));
            this.btOrderList.Location = new System.Drawing.Point(12, 211);
            this.btOrderList.Name = "btOrderList";
            this.btOrderList.Size = new System.Drawing.Size(529, 35);
            this.btOrderList.TabIndex = 7;
            this.btOrderList.Text = "Управление заказами";
            this.btOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOrderList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrderList.UseVisualStyleBackColor = true;
            this.btOrderList.Click += new System.EventHandler(this.btOrderList_Click);
            // 
            // btUserList
            // 
            this.btUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btUserList.Image = global::KNS.Fabric.Properties.Resources.user_add;
            this.btUserList.Location = new System.Drawing.Point(12, 170);
            this.btUserList.Name = "btUserList";
            this.btUserList.Size = new System.Drawing.Size(529, 35);
            this.btUserList.TabIndex = 6;
            this.btUserList.Text = "Управление пользователями";
            this.btUserList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUserList.UseVisualStyleBackColor = true;
            this.btUserList.Click += new System.EventHandler(this.btUserList_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btProductList);
            this.Controls.Add(this.btFurnitureList);
            this.Controls.Add(this.btMaterialList);
            this.Controls.Add(this.btOrderList);
            this.Controls.Add(this.btUserList);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран администратора (%Имя пользователя%)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btProductList;
        private System.Windows.Forms.Button btFurnitureList;
        private System.Windows.Forms.Button btMaterialList;
        private System.Windows.Forms.Button btOrderList;
        private System.Windows.Forms.Button btUserList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}