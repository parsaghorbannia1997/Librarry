namespace Library
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.tab_ketab = new System.Windows.Forms.TabControl();
            this.tab_sabt_ketab = new System.Windows.Forms.TabPage();
            this.t_isbn_1 = new System.Windows.Forms.TextBox();
            this.l_isbn_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_publisher_1 = new System.Windows.Forms.TextBox();
            this.t_authors_1 = new System.Windows.Forms.TextBox();
            this.t_count = new System.Windows.Forms.TextBox();
            this.t_copyright_1 = new System.Windows.Forms.TextBox();
            this.l_gheymat_1 = new System.Windows.Forms.Label();
            this.l_sale_enteshar_1 = new System.Windows.Forms.Label();
            this.l_entesharat_1 = new System.Windows.Forms.Label();
            this.l_nevisande_1 = new System.Windows.Forms.Label();
            this.t_title_1 = new System.Windows.Forms.TextBox();
            this.l_onvan_1 = new System.Windows.Forms.Label();
            this.tab_gozareshgiri = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.t_entesharat_2 = new System.Windows.Forms.TextBox();
            this.t_nevisande_2 = new System.Windows.Forms.TextBox();
            this.t_ketab_2 = new System.Windows.Forms.TextBox();
            this.c_entesharat_2 = new System.Windows.Forms.ComboBox();
            this.c_nevisande_2 = new System.Windows.Forms.ComboBox();
            this.c_ketab_2 = new System.Windows.Forms.ComboBox();
            this.r_entesharat_2 = new System.Windows.Forms.RadioButton();
            this.r_nevisande_2 = new System.Windows.Forms.RadioButton();
            this.r_onvane_ketab_2 = new System.Windows.Forms.RadioButton();
            this.l_search_2 = new System.Windows.Forms.Label();
            this.dgv1_2 = new System.Windows.Forms.DataGridView();
            this.b_sabt = new System.Windows.Forms.Button();
            this.b_virayesh = new System.Windows.Forms.Button();
            this.b_hazf = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.b_print = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.tab_ketab.SuspendLayout();
            this.tab_sabt_ketab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_gozareshgiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ketab
            // 
            this.tab_ketab.Controls.Add(this.tab_sabt_ketab);
            this.tab_ketab.Controls.Add(this.tab_gozareshgiri);
            this.tab_ketab.Location = new System.Drawing.Point(12, 12);
            this.tab_ketab.Name = "tab_ketab";
            this.tab_ketab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_ketab.RightToLeftLayout = true;
            this.tab_ketab.SelectedIndex = 0;
            this.tab_ketab.Size = new System.Drawing.Size(532, 240);
            this.tab_ketab.TabIndex = 0;
            this.tab_ketab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_ketab_Selecting);
            // 
            // tab_sabt_ketab
            // 
            this.tab_sabt_ketab.Controls.Add(this.t_isbn_1);
            this.tab_sabt_ketab.Controls.Add(this.l_isbn_1);
            this.tab_sabt_ketab.Controls.Add(this.pictureBox1);
            this.tab_sabt_ketab.Controls.Add(this.t_publisher_1);
            this.tab_sabt_ketab.Controls.Add(this.t_authors_1);
            this.tab_sabt_ketab.Controls.Add(this.t_count);
            this.tab_sabt_ketab.Controls.Add(this.t_copyright_1);
            this.tab_sabt_ketab.Controls.Add(this.l_gheymat_1);
            this.tab_sabt_ketab.Controls.Add(this.l_sale_enteshar_1);
            this.tab_sabt_ketab.Controls.Add(this.l_entesharat_1);
            this.tab_sabt_ketab.Controls.Add(this.l_nevisande_1);
            this.tab_sabt_ketab.Controls.Add(this.t_title_1);
            this.tab_sabt_ketab.Controls.Add(this.l_onvan_1);
            this.tab_sabt_ketab.Location = new System.Drawing.Point(4, 22);
            this.tab_sabt_ketab.Name = "tab_sabt_ketab";
            this.tab_sabt_ketab.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sabt_ketab.Size = new System.Drawing.Size(524, 214);
            this.tab_sabt_ketab.TabIndex = 0;
            this.tab_sabt_ketab.Text = "ثبت کتاب";
            this.tab_sabt_ketab.UseVisualStyleBackColor = true;
            // 
            // t_isbn_1
            // 
            this.t_isbn_1.Location = new System.Drawing.Point(326, 21);
            this.t_isbn_1.Name = "t_isbn_1";
            this.t_isbn_1.Size = new System.Drawing.Size(106, 20);
            this.t_isbn_1.TabIndex = 14;
            // 
            // l_isbn_1
            // 
            this.l_isbn_1.AutoSize = true;
            this.l_isbn_1.Location = new System.Drawing.Point(438, 22);
            this.l_isbn_1.Name = "l_isbn_1";
            this.l_isbn_1.Size = new System.Drawing.Size(68, 13);
            this.l_isbn_1.TabIndex = 13;
            this.l_isbn_1.Text = "شماره کتاب :";
            this.l_isbn_1.Click += new System.EventHandler(this.l_isbn_1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 125);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // t_publisher_1
            // 
            this.t_publisher_1.Location = new System.Drawing.Point(326, 86);
            this.t_publisher_1.Name = "t_publisher_1";
            this.t_publisher_1.Size = new System.Drawing.Size(106, 20);
            this.t_publisher_1.TabIndex = 9;
            // 
            // t_authors_1
            // 
            this.t_authors_1.Location = new System.Drawing.Point(326, 57);
            this.t_authors_1.Name = "t_authors_1";
            this.t_authors_1.Size = new System.Drawing.Size(106, 20);
            this.t_authors_1.TabIndex = 8;
            // 
            // t_count
            // 
            this.t_count.Location = new System.Drawing.Point(326, 157);
            this.t_count.Name = "t_count";
            this.t_count.Size = new System.Drawing.Size(106, 20);
            this.t_count.TabIndex = 7;
            // 
            // t_copyright_1
            // 
            this.t_copyright_1.Location = new System.Drawing.Point(326, 120);
            this.t_copyright_1.Name = "t_copyright_1";
            this.t_copyright_1.Size = new System.Drawing.Size(106, 20);
            this.t_copyright_1.TabIndex = 6;
            // 
            // l_gheymat_1
            // 
            this.l_gheymat_1.AutoSize = true;
            this.l_gheymat_1.Location = new System.Drawing.Point(468, 160);
            this.l_gheymat_1.Name = "l_gheymat_1";
            this.l_gheymat_1.Size = new System.Drawing.Size(36, 13);
            this.l_gheymat_1.TabIndex = 5;
            this.l_gheymat_1.Text = "تعداد :";
            // 
            // l_sale_enteshar_1
            // 
            this.l_sale_enteshar_1.AutoSize = true;
            this.l_sale_enteshar_1.Location = new System.Drawing.Point(441, 120);
            this.l_sale_enteshar_1.Name = "l_sale_enteshar_1";
            this.l_sale_enteshar_1.Size = new System.Drawing.Size(65, 13);
            this.l_sale_enteshar_1.TabIndex = 4;
            this.l_sale_enteshar_1.Text = "سال انتشار :";
            // 
            // l_entesharat_1
            // 
            this.l_entesharat_1.AutoSize = true;
            this.l_entesharat_1.Location = new System.Drawing.Point(451, 86);
            this.l_entesharat_1.Name = "l_entesharat_1";
            this.l_entesharat_1.Size = new System.Drawing.Size(53, 13);
            this.l_entesharat_1.TabIndex = 3;
            this.l_entesharat_1.Text = "انتشارات :";
            // 
            // l_nevisande_1
            // 
            this.l_nevisande_1.AutoSize = true;
            this.l_nevisande_1.Location = new System.Drawing.Point(453, 60);
            this.l_nevisande_1.Name = "l_nevisande_1";
            this.l_nevisande_1.Size = new System.Drawing.Size(51, 13);
            this.l_nevisande_1.TabIndex = 2;
            this.l_nevisande_1.Text = "نویسنده :";
            // 
            // t_title_1
            // 
            this.t_title_1.Location = new System.Drawing.Point(6, 6);
            this.t_title_1.Multiline = true;
            this.t_title_1.Name = "t_title_1";
            this.t_title_1.Size = new System.Drawing.Size(234, 53);
            this.t_title_1.TabIndex = 1;
            // 
            // l_onvan_1
            // 
            this.l_onvan_1.AutoSize = true;
            this.l_onvan_1.Location = new System.Drawing.Point(244, 24);
            this.l_onvan_1.Name = "l_onvan_1";
            this.l_onvan_1.Size = new System.Drawing.Size(66, 13);
            this.l_onvan_1.TabIndex = 0;
            this.l_onvan_1.Text = "عنوان کتاب :";
            // 
            // tab_gozareshgiri
            // 
            this.tab_gozareshgiri.Controls.Add(this.pictureBox2);
            this.tab_gozareshgiri.Controls.Add(this.t_entesharat_2);
            this.tab_gozareshgiri.Controls.Add(this.t_nevisande_2);
            this.tab_gozareshgiri.Controls.Add(this.t_ketab_2);
            this.tab_gozareshgiri.Controls.Add(this.c_entesharat_2);
            this.tab_gozareshgiri.Controls.Add(this.c_nevisande_2);
            this.tab_gozareshgiri.Controls.Add(this.c_ketab_2);
            this.tab_gozareshgiri.Controls.Add(this.r_entesharat_2);
            this.tab_gozareshgiri.Controls.Add(this.r_nevisande_2);
            this.tab_gozareshgiri.Controls.Add(this.r_onvane_ketab_2);
            this.tab_gozareshgiri.Controls.Add(this.l_search_2);
            this.tab_gozareshgiri.Location = new System.Drawing.Point(4, 22);
            this.tab_gozareshgiri.Name = "tab_gozareshgiri";
            this.tab_gozareshgiri.Padding = new System.Windows.Forms.Padding(3);
            this.tab_gozareshgiri.Size = new System.Drawing.Size(524, 214);
            this.tab_gozareshgiri.TabIndex = 1;
            this.tab_gozareshgiri.Text = "گزارشگیری";
            this.tab_gozareshgiri.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 135);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // t_entesharat_2
            // 
            this.t_entesharat_2.Enabled = false;
            this.t_entesharat_2.Location = new System.Drawing.Point(161, 155);
            this.t_entesharat_2.Name = "t_entesharat_2";
            this.t_entesharat_2.Size = new System.Drawing.Size(100, 20);
            this.t_entesharat_2.TabIndex = 9;
            // 
            // t_nevisande_2
            // 
            this.t_nevisande_2.Enabled = false;
            this.t_nevisande_2.Location = new System.Drawing.Point(161, 96);
            this.t_nevisande_2.Name = "t_nevisande_2";
            this.t_nevisande_2.Size = new System.Drawing.Size(100, 20);
            this.t_nevisande_2.TabIndex = 8;
            // 
            // t_ketab_2
            // 
            this.t_ketab_2.Enabled = false;
            this.t_ketab_2.Location = new System.Drawing.Point(161, 49);
            this.t_ketab_2.Name = "t_ketab_2";
            this.t_ketab_2.Size = new System.Drawing.Size(100, 20);
            this.t_ketab_2.TabIndex = 7;
            // 
            // c_entesharat_2
            // 
            this.c_entesharat_2.Enabled = false;
            this.c_entesharat_2.FormattingEnabled = true;
            this.c_entesharat_2.Items.AddRange(new object[] {
            "--انتخاب کنید--",
            "نام انتشارات"});
            this.c_entesharat_2.Location = new System.Drawing.Point(284, 155);
            this.c_entesharat_2.Name = "c_entesharat_2";
            this.c_entesharat_2.Size = new System.Drawing.Size(121, 21);
            this.c_entesharat_2.TabIndex = 6;
            // 
            // c_nevisande_2
            // 
            this.c_nevisande_2.Enabled = false;
            this.c_nevisande_2.FormattingEnabled = true;
            this.c_nevisande_2.Items.AddRange(new object[] {
            "--انتخاب کنید--",
            "نام و نام خانوادگی"});
            this.c_nevisande_2.Location = new System.Drawing.Point(284, 96);
            this.c_nevisande_2.Name = "c_nevisande_2";
            this.c_nevisande_2.Size = new System.Drawing.Size(121, 21);
            this.c_nevisande_2.TabIndex = 5;
            // 
            // c_ketab_2
            // 
            this.c_ketab_2.Enabled = false;
            this.c_ketab_2.FormattingEnabled = true;
            this.c_ketab_2.Items.AddRange(new object[] {
            "--انتخاب کنید--",
            "شماره کتاب",
            "عنوان کتاب",
            "سال انتشار",
            "همه"});
            this.c_ketab_2.Location = new System.Drawing.Point(284, 48);
            this.c_ketab_2.Name = "c_ketab_2";
            this.c_ketab_2.Size = new System.Drawing.Size(121, 21);
            this.c_ketab_2.TabIndex = 4;
            // 
            // r_entesharat_2
            // 
            this.r_entesharat_2.AutoSize = true;
            this.r_entesharat_2.Location = new System.Drawing.Point(409, 159);
            this.r_entesharat_2.Name = "r_entesharat_2";
            this.r_entesharat_2.Size = new System.Drawing.Size(71, 17);
            this.r_entesharat_2.TabIndex = 3;
            this.r_entesharat_2.TabStop = true;
            this.r_entesharat_2.Text = "انتشارات :";
            this.r_entesharat_2.UseVisualStyleBackColor = true;
            this.r_entesharat_2.CheckedChanged += new System.EventHandler(this.r_entesharat_2_CheckedChanged);
            // 
            // r_nevisande_2
            // 
            this.r_nevisande_2.AutoSize = true;
            this.r_nevisande_2.Location = new System.Drawing.Point(411, 100);
            this.r_nevisande_2.Name = "r_nevisande_2";
            this.r_nevisande_2.Size = new System.Drawing.Size(69, 17);
            this.r_nevisande_2.TabIndex = 2;
            this.r_nevisande_2.TabStop = true;
            this.r_nevisande_2.Text = "نویسنده :";
            this.r_nevisande_2.UseVisualStyleBackColor = true;
            this.r_nevisande_2.CheckedChanged += new System.EventHandler(this.r_nevisande_2_CheckedChanged);
            // 
            // r_onvane_ketab_2
            // 
            this.r_onvane_ketab_2.AutoSize = true;
            this.r_onvane_ketab_2.Location = new System.Drawing.Point(426, 48);
            this.r_onvane_ketab_2.Name = "r_onvane_ketab_2";
            this.r_onvane_ketab_2.Size = new System.Drawing.Size(54, 17);
            this.r_onvane_ketab_2.TabIndex = 1;
            this.r_onvane_ketab_2.TabStop = true;
            this.r_onvane_ketab_2.Text = "کتاب :";
            this.r_onvane_ketab_2.UseVisualStyleBackColor = true;
            this.r_onvane_ketab_2.CheckedChanged += new System.EventHandler(this.r_onvane_ketab_2_CheckedChanged);
            this.r_onvane_ketab_2.Click += new System.EventHandler(this.r_onvane_ketab_2_Click);
            // 
            // l_search_2
            // 
            this.l_search_2.AutoSize = true;
            this.l_search_2.Location = new System.Drawing.Point(426, 22);
            this.l_search_2.Name = "l_search_2";
            this.l_search_2.Size = new System.Drawing.Size(83, 13);
            this.l_search_2.TabIndex = 0;
            this.l_search_2.Text = "جستجو براساس :";
            // 
            // dgv1_2
            // 
            this.dgv1_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_2.Location = new System.Drawing.Point(16, 258);
            this.dgv1_2.Name = "dgv1_2";
            this.dgv1_2.Size = new System.Drawing.Size(524, 206);
            this.dgv1_2.TabIndex = 1;
            this.dgv1_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_2_CellClick);
            // 
            // b_sabt
            // 
            this.b_sabt.Location = new System.Drawing.Point(16, 479);
            this.b_sabt.Name = "b_sabt";
            this.b_sabt.Size = new System.Drawing.Size(75, 23);
            this.b_sabt.TabIndex = 2;
            this.b_sabt.Text = "ثبت";
            this.b_sabt.UseVisualStyleBackColor = true;
            this.b_sabt.Click += new System.EventHandler(this.b_sabt_Click_1);
            // 
            // b_virayesh
            // 
            this.b_virayesh.Location = new System.Drawing.Point(97, 479);
            this.b_virayesh.Name = "b_virayesh";
            this.b_virayesh.Size = new System.Drawing.Size(75, 23);
            this.b_virayesh.TabIndex = 3;
            this.b_virayesh.Text = "ویرایش";
            this.b_virayesh.UseVisualStyleBackColor = true;
            this.b_virayesh.Click += new System.EventHandler(this.b_virayesh_Click);
            // 
            // b_hazf
            // 
            this.b_hazf.Location = new System.Drawing.Point(178, 479);
            this.b_hazf.Name = "b_hazf";
            this.b_hazf.Size = new System.Drawing.Size(75, 23);
            this.b_hazf.TabIndex = 4;
            this.b_hazf.Text = "حذف";
            this.b_hazf.UseVisualStyleBackColor = true;
            this.b_hazf.Click += new System.EventHandler(this.b_hazf_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(259, 479);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 5;
            this.b_refresh.Text = "تازه سازی";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // b_print
            // 
            this.b_print.Location = new System.Drawing.Point(465, 479);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(75, 23);
            this.b_print.TabIndex = 6;
            this.b_print.Text = "چاپ";
            this.b_print.UseVisualStyleBackColor = true;
            this.b_print.Visible = false;
            this.b_print.Click += new System.EventHandler(this.b_print_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(384, 479);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 23);
            this.b_search.TabIndex = 7;
            this.b_search.Text = "جستجو";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Visible = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 514);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.b_print);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.b_hazf);
            this.Controls.Add(this.b_virayesh);
            this.Controls.Add(this.b_sabt);
            this.Controls.Add(this.dgv1_2);
            this.Controls.Add(this.tab_ketab);
            this.Name = "main_page";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت کتاب";
            this.Load += new System.EventHandler(this.main_page_Load);
            this.tab_ketab.ResumeLayout(false);
            this.tab_sabt_ketab.ResumeLayout(false);
            this.tab_sabt_ketab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_gozareshgiri.ResumeLayout(false);
            this.tab_gozareshgiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ketab;
        private System.Windows.Forms.TabPage tab_sabt_ketab;
        private System.Windows.Forms.Label l_gheymat_1;
        private System.Windows.Forms.Label l_sale_enteshar_1;
        private System.Windows.Forms.Label l_entesharat_1;
        private System.Windows.Forms.Label l_nevisande_1;
        private System.Windows.Forms.TextBox t_title_1;
        private System.Windows.Forms.Label l_onvan_1;
        private System.Windows.Forms.TabPage tab_gozareshgiri;
        private System.Windows.Forms.TextBox t_publisher_1;
        private System.Windows.Forms.TextBox t_authors_1;
        private System.Windows.Forms.TextBox t_count;
        private System.Windows.Forms.TextBox t_copyright_1;
        private System.Windows.Forms.DataGridView dgv1_2;
        private System.Windows.Forms.TextBox t_entesharat_2;
        private System.Windows.Forms.TextBox t_nevisande_2;
        private System.Windows.Forms.TextBox t_ketab_2;
        private System.Windows.Forms.ComboBox c_entesharat_2;
        private System.Windows.Forms.ComboBox c_nevisande_2;
        private System.Windows.Forms.ComboBox c_ketab_2;
        private System.Windows.Forms.RadioButton r_entesharat_2;
        private System.Windows.Forms.RadioButton r_nevisande_2;
        private System.Windows.Forms.RadioButton r_onvane_ketab_2;
        private System.Windows.Forms.Label l_search_2;
        private System.Windows.Forms.Button b_sabt;
        private System.Windows.Forms.Button b_virayesh;
        private System.Windows.Forms.Button b_hazf;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_print;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox t_isbn_1;
        private System.Windows.Forms.Label l_isbn_1;
    }
}

