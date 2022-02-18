namespace CashRegister
{
    partial class ItemsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.slQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnItemsWindowClose = new System.Windows.Forms.Button();
            this.gvAddItemList = new System.Windows.Forms.DataGridView();
            this.item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Item";
            // 
            // slQuantity
            // 
            this.slQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slQuantity.Location = new System.Drawing.Point(558, 922);
            this.slQuantity.Name = "slQuantity";
            this.slQuantity.Size = new System.Drawing.Size(120, 44);
            this.slQuantity.TabIndex = 2;
            this.slQuantity.ValueChanged += new System.EventHandler(this.slQuantity_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 915);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many? ";
            // 
            // btnItemsWindowClose
            // 
            this.btnItemsWindowClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnItemsWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnItemsWindowClose.FlatAppearance.BorderSize = 2;
            this.btnItemsWindowClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnItemsWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsWindowClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsWindowClose.ForeColor = System.Drawing.Color.Snow;
            this.btnItemsWindowClose.Location = new System.Drawing.Point(1313, 871);
            this.btnItemsWindowClose.Name = "btnItemsWindowClose";
            this.btnItemsWindowClose.Size = new System.Drawing.Size(365, 142);
            this.btnItemsWindowClose.TabIndex = 4;
            this.btnItemsWindowClose.Text = "Add Item!";
            this.btnItemsWindowClose.UseVisualStyleBackColor = false;
            this.btnItemsWindowClose.Click += new System.EventHandler(this.btnItemsWindowClose_Click);
            // 
            // gvAddItemList
            // 
            this.gvAddItemList.AllowUserToAddRows = false;
            this.gvAddItemList.AllowUserToDeleteRows = false;
            this.gvAddItemList.AllowUserToResizeColumns = false;
            this.gvAddItemList.AllowUserToResizeRows = false;
            this.gvAddItemList.BackgroundColor = System.Drawing.Color.MintCream;
            this.gvAddItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvAddItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAddItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_number,
            this.item_name,
            this.item_price});
            this.gvAddItemList.Location = new System.Drawing.Point(172, 159);
            this.gvAddItemList.MultiSelect = false;
            this.gvAddItemList.Name = "gvAddItemList";
            this.gvAddItemList.RowHeadersWidth = 82;
            this.gvAddItemList.RowTemplate.Height = 33;
            this.gvAddItemList.Size = new System.Drawing.Size(1506, 605);
            this.gvAddItemList.TabIndex = 11;
            this.gvAddItemList.SelectionChanged += new System.EventHandler(this.gvAddItemList_SelectionChanged);
            // 
            // item_number
            // 
            this.item_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.item_number.HeaderText = "Item Number";
            this.item_number.MinimumWidth = 225;
            this.item_number.Name = "item_number";
            this.item_number.ReadOnly = true;
            this.item_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item_number.Width = 225;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.MinimumWidth = 10;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Width = 230;
            // 
            // item_price
            // 
            this.item_price.HeaderText = "Item Price";
            this.item_price.MinimumWidth = 10;
            this.item_price.Name = "item_price";
            this.item_price.ReadOnly = true;
            this.item_price.Width = 220;
            // 
            // ItemsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1909, 1109);
            this.Controls.Add(this.gvAddItemList);
            this.Controls.Add(this.btnItemsWindowClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slQuantity);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ItemsWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsWindow";
            this.Load += new System.EventHandler(this.ItemsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown slQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnItemsWindowClose;
        private System.Windows.Forms.DataGridView gvAddItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
    }
}