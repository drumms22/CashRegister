namespace CashRegister
{
    partial class PriceChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReasonForChange = new System.Windows.Forms.ListBox();
            this.slItemPrice = new System.Windows.Forms.NumericUpDown();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Change";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reason For Change: ";
            // 
            // lstReasonForChange
            // 
            this.lstReasonForChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReasonForChange.FormattingEnabled = true;
            this.lstReasonForChange.ItemHeight = 31;
            this.lstReasonForChange.Location = new System.Drawing.Point(900, 549);
            this.lstReasonForChange.Name = "lstReasonForChange";
            this.lstReasonForChange.Size = new System.Drawing.Size(677, 159);
            this.lstReasonForChange.TabIndex = 5;
            // 
            // slItemPrice
            // 
            this.slItemPrice.DecimalPlaces = 2;
            this.slItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slItemPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.slItemPrice.Location = new System.Drawing.Point(900, 462);
            this.slItemPrice.Name = "slItemPrice";
            this.slItemPrice.Size = new System.Drawing.Size(215, 44);
            this.slItemPrice.TabIndex = 6;
            this.slItemPrice.ThousandsSeparator = true;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(893, 306);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(108, 37);
            this.lblItemNumber.TabIndex = 7;
            this.lblItemNumber.Text = "label6";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(893, 384);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(108, 37);
            this.lblItemName.TabIndex = 8;
            this.lblItemName.Text = "label6";
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.DarkBlue;
            this.btnChangePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePrice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePrice.FlatAppearance.BorderSize = 2;
            this.btnChangePrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePrice.Location = new System.Drawing.Point(765, 796);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(441, 116);
            this.btnChangePrice.TabIndex = 9;
            this.btnChangePrice.Text = "Change Price";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Firebrick;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.Location = new System.Drawing.Point(791, 187);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new System.Windows.Forms.Padding(10);
            this.lblError.Size = new System.Drawing.Size(106, 51);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "label7";
            this.lblError.Visible = false;
            // 
            // PriceChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1909, 1109);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.slItemPrice);
            this.Controls.Add(this.lstReasonForChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PriceChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriceChange";
            this.Load += new System.EventHandler(this.PriceChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slItemPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstReasonForChange;
        private System.Windows.Forms.NumericUpDown slItemPrice;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label lblError;
    }
}