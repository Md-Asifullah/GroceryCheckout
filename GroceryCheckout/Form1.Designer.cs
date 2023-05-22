
namespace GroceryCheckout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputItem = new System.Windows.Forms.TextBox();
            this.inputUnit = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.inputType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(422, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grocery Checkout App";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputItem
            // 
            this.inputItem.Location = new System.Drawing.Point(106, 206);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(195, 27);
            this.inputItem.TabIndex = 4;
            // 
            // inputUnit
            // 
            this.inputUnit.Location = new System.Drawing.Point(106, 258);
            this.inputUnit.Name = "inputUnit";
            this.inputUnit.Size = new System.Drawing.Size(195, 27);
            this.inputUnit.TabIndex = 5;
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(106, 310);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(195, 27);
            this.inputPrice.TabIndex = 6;
            // 
            // display
            // 
            this.display.AllowUserToAddRows = false;
            this.display.AllowUserToDeleteRows = false;
            this.display.AllowUserToResizeColumns = false;
            this.display.AllowUserToResizeRows = false;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(351, 101);
            this.display.MultiSelect = false;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RowHeadersWidth = 51;
            this.display.RowTemplate.Height = 29;
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display.ShowCellErrors = false;
            this.display.ShowCellToolTips = false;
            this.display.ShowEditingIcon = false;
            this.display.ShowRowErrors = false;
            this.display.Size = new System.Drawing.Size(673, 236);
            this.display.TabIndex = 7;
            this.display.TabStop = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(72, 364);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 29);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(537, 386);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(134, 29);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(693, 386);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(94, 29);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(106, 155);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(195, 27);
            this.inputType.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type:";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(106, 101);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(195, 27);
            this.inputId.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grocery Checkout App v 1.0";
            // 
            // statusMsg
            // 
            this.statusMsg.AutoSize = true;
            this.statusMsg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.statusMsg.Location = new System.Drawing.Point(422, 54);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(111, 20);
            this.statusMsg.TabIndex = 18;
            this.statusMsg.Text = "Status Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Price:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPrice.Location = new System.Drawing.Point(693, 352);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(43, 20);
            this.totalPrice.TabIndex = 20;
            this.totalPrice.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.display);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputUnit);
            this.Controls.Add(this.inputItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grocery Checkout App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputItem;
        private System.Windows.Forms.TextBox inputUnit;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.DataGridView display;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox inputType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalPrice;
    }
}

