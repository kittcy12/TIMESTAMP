namespace TIMESTAMP
{
    partial class Time_OUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time_OUT));
            this.btnlogout = new DevExpress.XtraEditors.SimpleButton();
            this.txtbarcode = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblguard = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblinvalid = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(128, 226);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(164, 76);
            this.btnlogout.TabIndex = 35;
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(32, 165);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Properties.Appearance.Options.UseFont = true;
            this.txtbarcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtbarcode.Size = new System.Drawing.Size(354, 48);
            this.txtbarcode.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "label6";
            // 
            // lblguard
            // 
            this.lblguard.AutoSize = true;
            this.lblguard.Location = new System.Drawing.Point(874, 414);
            this.lblguard.Name = "lblguard";
            this.lblguard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblguard.Size = new System.Drawing.Size(56, 17);
            this.lblguard.TabIndex = 32;
            this.lblguard.Text = "000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 414);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "GUARD ID:";
            // 
            // lblinvalid
            // 
            this.lblinvalid.AutoSize = true;
            this.lblinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvalid.ForeColor = System.Drawing.Color.Red;
            this.lblinvalid.Location = new System.Drawing.Point(123, 362);
            this.lblinvalid.Name = "lblinvalid";
            this.lblinvalid.Size = new System.Drawing.Size(156, 29);
            this.lblinvalid.TabIndex = 30;
            this.lblinvalid.Text = "INVALID ID!!";
            this.lblinvalid.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(361, 260);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Need Help?";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(100, 32);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(192, 48);
            this.lbl_time.TabIndex = 28;
            this.lbl_time.Text = "00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.txtcourse);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(450, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 400);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student\'s Information";
            // 
            // txtYS
            // 
            this.txtYS.Enabled = false;
            this.txtYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYS.Location = new System.Drawing.Point(21, 295);
            this.txtYS.Name = "txtYS";
            this.txtYS.Size = new System.Drawing.Size(283, 30);
            this.txtYS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year and Section:";
            // 
            // txtdept
            // 
            this.txtdept.Enabled = false;
            this.txtdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdept.Location = new System.Drawing.Point(310, 235);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(148, 30);
            this.txtdept.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(18, 216);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 17);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name:";
            // 
            // txtcourse
            // 
            this.txtcourse.Enabled = false;
            this.txtcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(310, 294);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(148, 30);
            this.txtcourse.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(135, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(21, 236);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(283, 30);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arturo Trial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "SCAN YOUR BARCODE";
            // 
            // Time_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 442);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblguard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblinvalid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Time_OUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time OUT";
            this.Load += new System.EventHandler(this.Time_OUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnlogout;
        private DevExpress.XtraEditors.TextEdit txtbarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblguard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblinvalid;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;

    }
}