namespace KNS.Fabric
{
    partial class OrderListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.btNewOrder = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btAddPosition = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.customer,
            this.manager,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Location = new System.Drawing.Point(12, 53);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvOrders.RowTemplate.Height = 35;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(969, 250);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrders_CellFormatting);
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Дата заказа";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // customer
            // 
            this.customer.DataPropertyName = "client";
            this.customer.HeaderText = "Заказчик";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customer.Width = 150;
            // 
            // manager
            // 
            this.manager.DataPropertyName = "manager";
            this.manager.HeaderText = "Менеджер";
            this.manager.MinimumWidth = 6;
            this.manager.Name = "manager";
            this.manager.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manager.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Items.AddRange(new object[] {
            "Новый",
            "Обрабатывается",
            "Отменен"});
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 150;
            // 
            // btSave
            // 
            this.btSave.Image = global::KNS.Fabric.Properties.Resources.accept;
            this.btSave.Location = new System.Drawing.Point(12, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(128, 35);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btNewOrder
            // 
            this.btNewOrder.Image = global::KNS.Fabric.Properties.Resources.add;
            this.btNewOrder.Location = new System.Drawing.Point(146, 12);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(166, 35);
            this.btNewOrder.TabIndex = 2;
            this.btNewOrder.Text = "Новый заказ";
            this.btNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNewOrder.UseVisualStyleBackColor = true;
            this.btNewOrder.Click += new System.EventHandler(this.btNewOrder_Click);
            // 
            // btExit
            // 
            this.btExit.Image = global::KNS.Fabric.Properties.Resources.exit;
            this.btExit.Location = new System.Drawing.Point(318, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(117, 35);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAddPosition
            // 
            this.btAddPosition.Image = global::KNS.Fabric.Properties.Resources.add;
            this.btAddPosition.Location = new System.Drawing.Point(12, 309);
            this.btAddPosition.Name = "btAddPosition";
            this.btAddPosition.Size = new System.Drawing.Size(201, 35);
            this.btAddPosition.TabIndex = 4;
            this.btAddPosition.Text = "Добавить позицию";
            this.btAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddPosition.UseVisualStyleBackColor = true;
            this.btAddPosition.Click += new System.EventHandler(this.btAddPosition_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Location = new System.Drawing.Point(12, 350);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvProducts.RowTemplate.Height = 35;
            this.dgvProducts.Size = new System.Drawing.Size(969, 171);
            this.dgvProducts.TabIndex = 5;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Изделие";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 533);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btAddPosition);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btNewOrder);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvOrders);
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление заказами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderListForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNewOrder;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAddPosition;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewComboBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn customer;
        private System.Windows.Forms.DataGridViewComboBoxColumn manager;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
    }
}