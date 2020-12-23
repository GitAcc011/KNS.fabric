namespace KNS.Fabric
{
    partial class StockmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockmanForm));
            this.btMaterialList = new System.Windows.Forms.Button();
            this.btFurnitureList = new System.Windows.Forms.Button();
            this.btProductList = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btMaterialList
            // 
            this.btMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaterialList.Image = ((System.Drawing.Image)(resources.GetObject("btMaterialList.Image")));
            this.btMaterialList.Location = new System.Drawing.Point(12, 173);
            this.btMaterialList.Name = "btMaterialList";
            this.btMaterialList.Size = new System.Drawing.Size(487, 35);
            this.btMaterialList.TabIndex = 0;
            this.btMaterialList.Text = "Список тканей";
            this.btMaterialList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMaterialList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMaterialList.UseVisualStyleBackColor = true;
            this.btMaterialList.Click += new System.EventHandler(this.btMaterialList_Click);
            // 
            // btFurnitureList
            // 
            this.btFurnitureList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btFurnitureList.Image = ((System.Drawing.Image)(resources.GetObject("btFurnitureList.Image")));
            this.btFurnitureList.Location = new System.Drawing.Point(12, 214);
            this.btFurnitureList.Name = "btFurnitureList";
            this.btFurnitureList.Size = new System.Drawing.Size(487, 35);
            this.btFurnitureList.TabIndex = 1;
            this.btFurnitureList.Text = "Список фурнитуры";
            this.btFurnitureList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFurnitureList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFurnitureList.UseVisualStyleBackColor = true;
            this.btFurnitureList.Click += new System.EventHandler(this.btFurnitureList_Click);
            // 
            // btProductList
            // 
            this.btProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btProductList.Image = ((System.Drawing.Image)(resources.GetObject("btProductList.Image")));
            this.btProductList.Location = new System.Drawing.Point(12, 255);
            this.btProductList.Name = "btProductList";
            this.btProductList.Size = new System.Drawing.Size(487, 35);
            this.btProductList.TabIndex = 2;
            this.btProductList.Text = "Список изделий";
            this.btProductList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProductList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProductList.UseVisualStyleBackColor = true;
            this.btProductList.Click += new System.EventHandler(this.btProductList_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Image = global::KNS.Fabric.Properties.Resources.exit;
            this.btExit.Location = new System.Drawing.Point(12, 296);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(487, 35);
            this.btExit.TabIndex = 3;
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StockmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btProductList);
            this.Controls.Add(this.btFurnitureList);
            this.Controls.Add(this.btMaterialList);
            this.Name = "StockmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран кладовщика (%Имя пользователя%)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockmanForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMaterialList;
        private System.Windows.Forms.Button btFurnitureList;
        private System.Windows.Forms.Button btProductList;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}