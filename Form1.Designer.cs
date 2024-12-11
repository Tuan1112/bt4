namespace bt4
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(602, 83);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(602, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(602, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(602, 255);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssvDataGridViewTextBoxColumn,
            this.tennvDataGridViewTextBoxColumn,
            this.luongcbDataGridViewTextBoxColumn,
            this.mSNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn1,
            this.luongCBDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.nVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(481, 291);
            this.dataGridView1.TabIndex = 5;
            // 
            // mssvDataGridViewTextBoxColumn
            // 
            this.mssvDataGridViewTextBoxColumn.HeaderText = "MSNV";
            this.mssvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mssvDataGridViewTextBoxColumn.Name = "mssvDataGridViewTextBoxColumn";
            this.mssvDataGridViewTextBoxColumn.Width = 125;
            // 
            // tennvDataGridViewTextBoxColumn
            // 
            this.tennvDataGridViewTextBoxColumn.HeaderText = "Ten NV";
            this.tennvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tennvDataGridViewTextBoxColumn.Name = "tennvDataGridViewTextBoxColumn";
            this.tennvDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongcbDataGridViewTextBoxColumn
            // 
            this.luongcbDataGridViewTextBoxColumn.HeaderText = "Luong CB";
            this.luongcbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongcbDataGridViewTextBoxColumn.Name = "luongcbDataGridViewTextBoxColumn";
            this.luongcbDataGridViewTextBoxColumn.Width = 125;
            // 
            // nVBindingSource
            // 
            this.nVBindingSource.DataSource = typeof(bt4.NV);
            // 
            // mSNVDataGridViewTextBoxColumn
            // 
            this.mSNVDataGridViewTextBoxColumn.DataPropertyName = "MSNV";
            this.mSNVDataGridViewTextBoxColumn.HeaderText = "MSNV";
            this.mSNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSNVDataGridViewTextBoxColumn.Name = "mSNVDataGridViewTextBoxColumn";
            this.mSNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn1
            // 
            this.tenNVDataGridViewTextBoxColumn1.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn1.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn1.Name = "tenNVDataGridViewTextBoxColumn1";
            this.tenNVDataGridViewTextBoxColumn1.Width = 125;
            // 
            // luongCBDataGridViewTextBoxColumn1
            // 
            this.luongCBDataGridViewTextBoxColumn1.DataPropertyName = "LuongCB";
            this.luongCBDataGridViewTextBoxColumn1.HeaderText = "LuongCB";
            this.luongCBDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.luongCBDataGridViewTextBoxColumn1.Name = "luongCBDataGridViewTextBoxColumn1";
            this.luongCBDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource nVBindingSource;
    }
}

