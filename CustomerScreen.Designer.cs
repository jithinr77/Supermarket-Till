namespace CheckOut
{
    partial class CustomerScreen
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
            this.backToLoginScreenButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.productColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proceedToCheckoutButton = new System.Windows.Forms.Button();
            this.finishAndPayButton = new System.Windows.Forms.Button();
            this.totalToPayLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToLoginScreenButton
            // 
            this.backToLoginScreenButton.AutoSize = true;
            this.backToLoginScreenButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backToLoginScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginScreenButton.Location = new System.Drawing.Point(0, 0);
            this.backToLoginScreenButton.Name = "backToLoginScreenButton";
            this.backToLoginScreenButton.Size = new System.Drawing.Size(884, 34);
            this.backToLoginScreenButton.TabIndex = 0;
            this.backToLoginScreenButton.Text = "BackToLoginScreen";
            this.backToLoginScreenButton.UseVisualStyleBackColor = true;
            this.backToLoginScreenButton.Click += new System.EventHandler(this.backToLoginScreenButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customerDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.proceedToCheckoutButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.finishAndPayButton);
            this.splitContainer1.Panel2.Controls.Add(this.totalToPayLabel);
            this.splitContainer1.Panel2.Controls.Add(this.savingsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.subtotalLabel);
            this.splitContainer1.Size = new System.Drawing.Size(884, 527);
            this.splitContainer1.SplitterDistance = 537;
            this.splitContainer1.TabIndex = 1;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productColumn,
            this.priceColumn,
            this.offerColumn,
            this.quantityColumn});
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(537, 493);
            this.customerDataGridView.TabIndex = 1;
            // 
            // productColumn
            // 
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            this.productColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // offerColumn
            // 
            this.offerColumn.HeaderText = "Offer";
            this.offerColumn.Name = "offerColumn";
            this.offerColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityColumn.HeaderText = "Quantity (enter number below)";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // proceedToCheckoutButton
            // 
            this.proceedToCheckoutButton.AutoSize = true;
            this.proceedToCheckoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proceedToCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedToCheckoutButton.Location = new System.Drawing.Point(0, 493);
            this.proceedToCheckoutButton.Name = "proceedToCheckoutButton";
            this.proceedToCheckoutButton.Size = new System.Drawing.Size(537, 34);
            this.proceedToCheckoutButton.TabIndex = 0;
            this.proceedToCheckoutButton.Text = "Proceed To Checkout";
            this.proceedToCheckoutButton.UseVisualStyleBackColor = true;
            this.proceedToCheckoutButton.Click += new System.EventHandler(this.proceedToCheckoutButton_Click);
            // 
            // finishAndPayButton
            // 
            this.finishAndPayButton.AutoSize = true;
            this.finishAndPayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.finishAndPayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishAndPayButton.Location = new System.Drawing.Point(0, 493);
            this.finishAndPayButton.Name = "finishAndPayButton";
            this.finishAndPayButton.Size = new System.Drawing.Size(343, 34);
            this.finishAndPayButton.TabIndex = 3;
            this.finishAndPayButton.Text = "Finish And Pay";
            this.finishAndPayButton.UseVisualStyleBackColor = true;
            this.finishAndPayButton.Click += new System.EventHandler(this.finishAndPayButton_Click);
            // 
            // totalToPayLabel
            // 
            this.totalToPayLabel.AutoSize = true;
            this.totalToPayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalToPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToPayLabel.Location = new System.Drawing.Point(0, 128);
            this.totalToPayLabel.Margin = new System.Windows.Forms.Padding(10);
            this.totalToPayLabel.Name = "totalToPayLabel";
            this.totalToPayLabel.Padding = new System.Windows.Forms.Padding(20);
            this.totalToPayLabel.Size = new System.Drawing.Size(164, 64);
            this.totalToPayLabel.TabIndex = 2;
            this.totalToPayLabel.Text = "Total to pay:";
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.savingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(0, 64);
            this.savingsLabel.Margin = new System.Windows.Forms.Padding(10);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Padding = new System.Windows.Forms.Padding(20);
            this.savingsLabel.Size = new System.Drawing.Size(135, 64);
            this.savingsLabel.TabIndex = 1;
            this.savingsLabel.Text = "Savings: ";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(0, 0);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(10);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Padding = new System.Windows.Forms.Padding(20);
            this.subtotalLabel.Size = new System.Drawing.Size(137, 64);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal: ";
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.backToLoginScreenButton);
            this.Name = "CustomerScreen";
            this.Text = "CustomerScreen";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToLoginScreenButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button proceedToCheckoutButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button finishAndPayButton;
        private System.Windows.Forms.Label totalToPayLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
    }
}