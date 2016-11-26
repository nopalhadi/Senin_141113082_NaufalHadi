namespace Latihan_1_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MaxY = new System.Windows.Forms.Label();
            this.MinY = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.max = new System.Windows.Forms.Label();
            this.sn2 = new System.Windows.Forms.Label();
            this.scroll2 = new System.Windows.Forms.HScrollBar();
            this.sn1 = new System.Windows.Forms.Label();
            this.nmin = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.scroll1 = new System.Windows.Forms.HScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tc1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tc1.CausesValidation = false;
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Controls.Add(this.tabPage2);
            this.tc1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tc1.ImageList = this.imageList1;
            this.tc1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tc1.Location = new System.Drawing.Point(-2, 0);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.ShowToolTips = true;
            this.tc1.Size = new System.Drawing.Size(475, 279);
            this.tc1.TabIndex = 0;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MaxY);
            this.tabPage1.Controls.Add(this.MinY);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.max);
            this.tabPage1.Controls.Add(this.sn2);
            this.tabPage1.Controls.Add(this.scroll2);
            this.tabPage1.Controls.Add(this.sn1);
            this.tabPage1.Controls.Add(this.nmin);
            this.tabPage1.Controls.Add(this.min);
            this.tabPage1.Controls.Add(this.scroll1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab Tugas 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // MaxY
            // 
            this.MaxY.AutoSize = true;
            this.MaxY.Location = new System.Drawing.Point(175, 166);
            this.MaxY.Name = "MaxY";
            this.MaxY.Size = new System.Drawing.Size(97, 13);
            this.MaxY.TabIndex = 10;
            this.MaxY.Text = "Max Tahun = 2016";
            // 
            // MinY
            // 
            this.MinY.AutoSize = true;
            this.MinY.Location = new System.Drawing.Point(33, 166);
            this.MinY.Name = "MinY";
            this.MinY.Size = new System.Drawing.Size(94, 13);
            this.MinY.TabIndex = 9;
            this.MinY.Text = "Min Tahun = 2016";
            this.MinY.Click += new System.EventHandler(this.MinY_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(205, 124);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(45, 13);
            this.max.TabIndex = 6;
            this.max.Text = "Max = 0";
            // 
            // sn2
            // 
            this.sn2.AutoSize = true;
            this.sn2.Location = new System.Drawing.Point(24, 75);
            this.sn2.Name = "sn2";
            this.sn2.Size = new System.Drawing.Size(60, 13);
            this.sn2.TabIndex = 5;
            this.sn2.Text = "Scroll 2 = 0";
            this.sn2.Click += new System.EventHandler(this.sc2_Click);
            // 
            // scroll2
            // 
            this.scroll2.LargeChange = 1;
            this.scroll2.Location = new System.Drawing.Point(20, 88);
            this.scroll2.Maximum = 20;
            this.scroll2.Minimum = 1;
            this.scroll2.Name = "scroll2";
            this.scroll2.Size = new System.Drawing.Size(269, 22);
            this.scroll2.TabIndex = 4;
            this.scroll2.Value = 1;
            this.scroll2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrol2_Scroll);
            // 
            // sn1
            // 
            this.sn1.AutoSize = true;
            this.sn1.Location = new System.Drawing.Point(24, 35);
            this.sn1.Name = "sn1";
            this.sn1.Size = new System.Drawing.Size(60, 13);
            this.sn1.TabIndex = 0;
            this.sn1.Text = "Scroll 1 = 0";
            this.sn1.Click += new System.EventHandler(this.sn1_Click);
            // 
            // nmin
            // 
            this.nmin.AutoSize = true;
            this.nmin.Location = new System.Drawing.Point(94, 106);
            this.nmin.Name = "nmin";
            this.nmin.Size = new System.Drawing.Size(0, 13);
            this.nmin.TabIndex = 2;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(65, 124);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(42, 13);
            this.min.TabIndex = 1;
            this.min.Text = "Min = 0";
            // 
            // scroll1
            // 
            this.scroll1.LargeChange = 1;
            this.scroll1.Location = new System.Drawing.Point(20, 48);
            this.scroll1.Maximum = 20;
            this.scroll1.Minimum = 1;
            this.scroll1.Name = "scroll1";
            this.scroll1.Size = new System.Drawing.Size(269, 22);
            this.scroll1.TabIndex = 3;
            this.scroll1.Value = 1;
            this.scroll1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrol1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab Tugas 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "facebook logo 4.jpg");
            this.imageList1.Images.SetKeyName(1, "twitter-logo.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 273);
            this.Controls.Add(this.tc1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Latihan_1_1";
            this.tc1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label MaxY;
        private System.Windows.Forms.Label MinY;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label sn2;
        private System.Windows.Forms.HScrollBar scroll2;
        private System.Windows.Forms.Label sn1;
        private System.Windows.Forms.Label nmin;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.HScrollBar scroll1;
        private System.Windows.Forms.ImageList imageList2;

    }
}

