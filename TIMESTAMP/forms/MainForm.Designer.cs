namespace TIMESTAMP
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnscan_in = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.record = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnabout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_add = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnswitchacc = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.adminpage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnscan_in,
            this.ribbonGalleryBarItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.record,
            this.barButtonItem3,
            this.btnabout,
            this.barButtonItem_add,
            this.barButtonItem4,
            this.btnswitchacc,
            this.btnclose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbon_home,
            this.adminpage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(740, 155);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnscan_in
            // 
            this.btnscan_in.Caption = "IN";
            this.btnscan_in.Glyph = ((System.Drawing.Image)(resources.GetObject("btnscan_in.Glyph")));
            this.btnscan_in.Id = 1;
            this.btnscan_in.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnscan_in.LargeGlyph")));
            this.btnscan_in.Name = "btnscan_in";
            this.btnscan_in.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnscan_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 2;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Record";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // record
            // 
            this.record.ActAsDropDown = true;
            this.record.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.record.Caption = "Records";
            this.record.DropDownControl = this.galleryDropDown1;
            this.record.Glyph = ((System.Drawing.Image)(resources.GetObject("record.Glyph")));
            this.record.Id = 6;
            this.record.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("record.LargeGlyph")));
            this.record.Name = "record";
            this.record.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.record_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Out";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnabout
            // 
            this.btnabout.Caption = "About";
            this.btnabout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnabout.Glyph")));
            this.btnabout.Id = 8;
            this.btnabout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnabout.LargeGlyph")));
            this.btnabout.Name = "btnabout";
            this.btnabout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem_add
            // 
            this.barButtonItem_add.Caption = "Add Role";
            this.barButtonItem_add.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_add.Glyph")));
            this.barButtonItem_add.Id = 9;
            this.barButtonItem_add.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_add.LargeGlyph")));
            this.barButtonItem_add.Name = "barButtonItem_add";
            this.barButtonItem_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_add_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Log out";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnswitchacc
            // 
            this.btnswitchacc.Caption = "Switch Account";
            this.btnswitchacc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnswitchacc.Glyph")));
            this.btnswitchacc.Id = 11;
            this.btnswitchacc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnswitchacc.LargeGlyph")));
            this.btnswitchacc.Name = "btnswitchacc";
            this.btnswitchacc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Exit";
            this.btnclose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnclose.Glyph")));
            this.btnclose.Id = 12;
            this.btnclose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnclose.LargeGlyph")));
            this.btnclose.Name = "btnclose";
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // ribbon_home
            // 
            this.ribbon_home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbon_home.Name = "ribbon_home";
            this.ribbon_home.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnscan_in);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Data";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnabout);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnswitchacc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnclose);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "App Command";
            // 
            // adminpage
            // 
            this.adminpage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.adminpage.Name = "adminpage";
            this.adminpage.Text = "Administrator";
            this.adminpage.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.record);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_add);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Records";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnscan_in);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Adding Data";
            // 
            // Main_Form
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bohol Island State University - Time Stamp Recorder";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnscan_in;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage adminpage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem record;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnabout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_add;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnswitchacc;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

