namespace 批量修改
{
	internal partial class MYForm : global::System.Windows.Forms.Form
	{
		private void InitializeComponent()
		{
            this.diname = new System.Windows.Forms.TextBox();
            this.jp = new System.Windows.Forms.Button();
            this.u8 = new System.Windows.Forms.Button();
            this.strinput = new System.Windows.Forms.TextBox();
            this.pattern = new System.Windows.Forms.TextBox();
            this.self = new System.Windows.Forms.Button();
            this.pat = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.fang = new System.Windows.Forms.Button();
            this.yuan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diname
            // 
            this.diname.Dock = System.Windows.Forms.DockStyle.Top;
            this.diname.Font = new System.Drawing.Font("仿宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diname.Location = new System.Drawing.Point(0, 0);
            this.diname.Name = "diname";
            this.diname.Size = new System.Drawing.Size(710, 32);
            this.diname.TabIndex = 0;
            // 
            // jp
            // 
            this.jp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jp.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jp.Location = new System.Drawing.Point(598, 40);
            this.jp.Name = "jp";
            this.jp.Size = new System.Drawing.Size(100, 37);
            this.jp.TabIndex = 1;
            this.jp.Text = "jp";
            this.jp.UseVisualStyleBackColor = true;
            this.jp.Click += new System.EventHandler(this.jp_Click);
            // 
            // u8
            // 
            this.u8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.u8.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.u8.Location = new System.Drawing.Point(492, 40);
            this.u8.Name = "u8";
            this.u8.Size = new System.Drawing.Size(100, 37);
            this.u8.TabIndex = 2;
            this.u8.Text = "u8";
            this.u8.UseVisualStyleBackColor = true;
            this.u8.Click += new System.EventHandler(this.u8_Click);
            // 
            // strinput
            // 
            this.strinput.Font = new System.Drawing.Font("仿宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strinput.Location = new System.Drawing.Point(0, 41);
            this.strinput.Name = "strinput";
            this.strinput.Size = new System.Drawing.Size(486, 32);
            this.strinput.TabIndex = 3;
            // 
            // pattern
            // 
            this.pattern.Font = new System.Drawing.Font("仿宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pattern.Location = new System.Drawing.Point(0, 84);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(228, 32);
            this.pattern.TabIndex = 5;
            // 
            // self
            // 
            this.self.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.self.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.self.Location = new System.Drawing.Point(492, 83);
            this.self.Name = "self";
            this.self.Size = new System.Drawing.Size(100, 37);
            this.self.TabIndex = 6;
            this.self.Text = "[del]";
            this.self.UseVisualStyleBackColor = true;
            this.self.Click += new System.EventHandler(this.self_Click);
            // 
            // pat
            // 
            this.pat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pat.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pat.Location = new System.Drawing.Point(598, 83);
            this.pat.Name = "pat";
            this.pat.Size = new System.Drawing.Size(100, 37);
            this.pat.TabIndex = 7;
            this.pat.Text = "[\\\\]";
            this.pat.UseVisualStyleBackColor = true;
            this.pat.Click += new System.EventHandler(this.pat_Click);
            // 
            // re
            // 
            this.re.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.re.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.re.Location = new System.Drawing.Point(386, 83);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(100, 37);
            this.re.TabIndex = 8;
            this.re.Text = "return";
            this.re.UseVisualStyleBackColor = true;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // fang
            // 
            this.fang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fang.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fang.Location = new System.Drawing.Point(325, 84);
            this.fang.Name = "fang";
            this.fang.Size = new System.Drawing.Size(55, 37);
            this.fang.TabIndex = 10;
            this.fang.Text = "[]";
            this.fang.UseVisualStyleBackColor = true;
            this.fang.Click += new System.EventHandler(this.fang_Click);
            // 
            // yuan
            // 
            this.yuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yuan.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yuan.Location = new System.Drawing.Point(264, 84);
            this.yuan.Name = "yuan";
            this.yuan.Size = new System.Drawing.Size(55, 37);
            this.yuan.TabIndex = 11;
            this.yuan.Text = "()";
            this.yuan.UseVisualStyleBackColor = true;
            this.yuan.Click += new System.EventHandler(this.yuan_Click);
            // 
            // MYForm
            // 
            this.AllowDrop = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(710, 177);
            this.Controls.Add(this.yuan);
            this.Controls.Add(this.fang);
            this.Controls.Add(this.re);
            this.Controls.Add(this.pat);
            this.Controls.Add(this.self);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.strinput);
            this.Controls.Add(this.u8);
            this.Controls.Add(this.jp);
            this.Controls.Add(this.diname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MYForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MYForm_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MYForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.Windows.Forms.Button jp;

		private global::System.Windows.Forms.Button u8;

		private global::System.Windows.Forms.TextBox strinput;

		private global::System.Windows.Forms.TextBox pattern;

		private global::System.Windows.Forms.Button self;

		private global::System.Windows.Forms.Button pat;

		private global::System.Windows.Forms.Button re;

		private global::System.Windows.Forms.Button fang;

		private global::System.Windows.Forms.Button yuan;

		private global::System.Windows.Forms.TextBox diname;
    }
}
