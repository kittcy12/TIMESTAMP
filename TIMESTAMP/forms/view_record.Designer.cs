namespace TIMESTAMP
{
    partial class view_record
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
            this.txtstud_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.col_guard_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_guard_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_log_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.log_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_guard_id_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_guard_id_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.log_date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstud_id
            // 
            this.txtstud_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstud_id.Location = new System.Drawing.Point(39, 56);
            this.txtstud_id.Name = "txtstud_id";
            this.txtstud_id.Size = new System.Drawing.Size(241, 30);
            this.txtstud_id.TabIndex = 1;
            this.txtstud_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENT NAME OR ID:";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(693, 59);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 30);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // col_guard_out
            // 
            this.col_guard_out.HeaderText = "Guard on Duty - OUT";
            this.col_guard_out.Name = "col_guard_out";
            // 
            // col_guard_in
            // 
            this.col_guard_in.HeaderText = "Guard on Duty - IN";
            this.col_guard_in.Name = "col_guard_in";
            // 
            // col_date
            // 
            this.col_date.HeaderText = "Date";
            this.col_date.Name = "col_date";
            // 
            // col_out
            // 
            this.col_out.HeaderText = "Time Out";
            this.col_out.Name = "col_out";
            // 
            // col_in
            // 
            this.col_in.HeaderText = "Time In";
            this.col_in.Name = "col_in";
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Student ID";
            this.col_id.Name = "col_id";
            // 
            // col_log_no
            // 
            this.col_log_no.HeaderText = "Log No.";
            this.col_log_no.Name = "col_log_no";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_log_no,
            this.col_id,
            this.col_in,
            this.col_out,
            this.col_date,
            this.col_guard_in,
            this.col_guard_out});
            this.dataGridView1.Location = new System.Drawing.Point(39, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 348);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(808, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(499, 348);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.log_no,
            this.log_id,
            this.log_in,
            this.log_out,
            this.log_date,
            this.log_guard_id_in,
            this.log_guard_id_out});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // log_no
            // 
            this.log_no.Caption = "Log No.";
            this.log_no.Name = "log_no";
            this.log_no.Visible = true;
            this.log_no.VisibleIndex = 0;
            // 
            // log_id
            // 
            this.log_id.Caption = "Student ID";
            this.log_id.Name = "log_id";
            this.log_id.Visible = true;
            this.log_id.VisibleIndex = 1;
            // 
            // log_in
            // 
            this.log_in.Caption = "Time In";
            this.log_in.Name = "log_in";
            this.log_in.Visible = true;
            this.log_in.VisibleIndex = 2;
            // 
            // log_out
            // 
            this.log_out.Caption = "Time Out";
            this.log_out.Name = "log_out";
            this.log_out.Visible = true;
            this.log_out.VisibleIndex = 4;
            // 
            // log_guard_id_in
            // 
            this.log_guard_id_in.Caption = "Entrance Guard";
            this.log_guard_id_in.Name = "log_guard_id_in";
            this.log_guard_id_in.Visible = true;
            this.log_guard_id_in.VisibleIndex = 5;
            // 
            // log_guard_id_out
            // 
            this.log_guard_id_out.Caption = "Exit Guard";
            this.log_guard_id_out.Name = "log_guard_id_out";
            this.log_guard_id_out.Visible = true;
            this.log_guard_id_out.VisibleIndex = 6;
            // 
            // log_date
            // 
            this.log_date.Caption = "Date";
            this.log_date.Name = "log_date";
            this.log_date.Visible = true;
            this.log_date.VisibleIndex = 3;
            // 
            // view_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 479);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstud_id);
            this.Name = "view_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "view_record";
            this.Load += new System.EventHandler(this.view_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstud_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_guard_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_guard_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_log_no;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn log_no;
        private DevExpress.XtraGrid.Columns.GridColumn log_id;
        private DevExpress.XtraGrid.Columns.GridColumn log_in;
        private DevExpress.XtraGrid.Columns.GridColumn log_out;
        private DevExpress.XtraGrid.Columns.GridColumn log_date;
        private DevExpress.XtraGrid.Columns.GridColumn log_guard_id_in;
        private DevExpress.XtraGrid.Columns.GridColumn log_guard_id_out;
    }
}