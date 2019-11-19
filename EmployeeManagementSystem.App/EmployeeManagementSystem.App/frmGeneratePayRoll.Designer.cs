namespace EmployeeManagementSystem.App
{
    partial class frmGeneratePayRoll
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
            this.btnClose = new System.Windows.Forms.Button();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSort = new System.Windows.Forms.PictureBox();
            this.picBocLogo = new System.Windows.Forms.PictureBox();
            this.btnNameDescending = new System.Windows.Forms.Button();
            this.btnNameAscending = new System.Windows.Forms.Button();
            this.btnTotalWageDesc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.sortPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(898, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.btnTotalWageDesc);
            this.sideBarPanel.Controls.Add(this.btnNameAscending);
            this.sideBarPanel.Controls.Add(this.btnNameDescending);
            this.sideBarPanel.Controls.Add(this.sortPanel);
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Controls.Add(this.button1);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(176, 516);
            this.sideBarPanel.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Controls.Add(this.picBocLogo);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(176, 53);
            this.logoPanel.TabIndex = 0;
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.sortPanel.Controls.Add(this.label2);
            this.sortPanel.Controls.Add(this.picSort);
            this.sortPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortPanel.Location = new System.Drawing.Point(0, 53);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(176, 46);
            this.sortPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Location = new System.Drawing.Point(176, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1046, 53);
            this.headerPanel.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.btnClose);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(176, 416);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1030, 100);
            this.footerPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total Wage Asc";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort By";
            // 
            // picSort
            // 
            this.picSort.Image = global::EmployeeManagementSystem.App.Properties.Resources.sort;
            this.picSort.Location = new System.Drawing.Point(3, 4);
            this.picSort.Name = "picSort";
            this.picSort.Size = new System.Drawing.Size(43, 39);
            this.picSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSort.TabIndex = 0;
            this.picSort.TabStop = false;
            // 
            // picBocLogo
            // 
            this.picBocLogo.Image = global::EmployeeManagementSystem.App.Properties.Resources.user_white;
            this.picBocLogo.Location = new System.Drawing.Point(3, 1);
            this.picBocLogo.Name = "picBocLogo";
            this.picBocLogo.Size = new System.Drawing.Size(60, 50);
            this.picBocLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBocLogo.TabIndex = 0;
            this.picBocLogo.TabStop = false;
            // 
            // btnNameDescending
            // 
            this.btnNameDescending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNameDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameDescending.ForeColor = System.Drawing.Color.White;
            this.btnNameDescending.Location = new System.Drawing.Point(3, 239);
            this.btnNameDescending.Name = "btnNameDescending";
            this.btnNameDescending.Size = new System.Drawing.Size(173, 40);
            this.btnNameDescending.TabIndex = 1;
            this.btnNameDescending.Text = "Name Descending";
            this.btnNameDescending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameDescending.UseVisualStyleBackColor = true;
            // 
            // btnNameAscending
            // 
            this.btnNameAscending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNameAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameAscending.ForeColor = System.Drawing.Color.White;
            this.btnNameAscending.Location = new System.Drawing.Point(3, 197);
            this.btnNameAscending.Name = "btnNameAscending";
            this.btnNameAscending.Size = new System.Drawing.Size(173, 40);
            this.btnNameAscending.TabIndex = 2;
            this.btnNameAscending.Text = "Name Ascending";
            this.btnNameAscending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameAscending.UseVisualStyleBackColor = true;
            // 
            // btnTotalWageDesc
            // 
            this.btnTotalWageDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTotalWageDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalWageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalWageDesc.ForeColor = System.Drawing.Color.White;
            this.btnTotalWageDesc.Location = new System.Drawing.Point(3, 151);
            this.btnTotalWageDesc.Name = "btnTotalWageDesc";
            this.btnTotalWageDesc.Size = new System.Drawing.Size(173, 40);
            this.btnTotalWageDesc.TabIndex = 3;
            this.btnTotalWageDesc.Text = "Total Wage Desc";
            this.btnTotalWageDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalWageDesc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(684, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Management System (Payroll Report)";
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayroll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPayroll.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvPayroll.Location = new System.Drawing.Point(176, 0);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPayroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPayroll.Size = new System.Drawing.Size(1030, 416);
            this.dgvPayroll.TabIndex = 5;
            // 
            // frmGeneratePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 516);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneratePayRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate PayRoll";
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.sortPanel.ResumeLayout(false);
            this.sortPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel sortPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBocLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSort;
        private System.Windows.Forms.Button btnTotalWageDesc;
        private System.Windows.Forms.Button btnNameAscending;
        private System.Windows.Forms.Button btnNameDescending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPayroll;
    }
}