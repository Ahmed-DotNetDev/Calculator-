namespace Calculator
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
			this.lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnexit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.btndiv = new Guna.UI2.WinForms.Guna2Button();
			this.btnmulti = new Guna.UI2.WinForms.Guna2Button();
			this.btnplus = new Guna.UI2.WinForms.Guna2Button();
			this.btnminus = new Guna.UI2.WinForms.Guna2Button();
			this.btnthree = new Guna.UI2.WinForms.Guna2Button();
			this.btnsix = new Guna.UI2.WinForms.Guna2Button();
			this.btnnine = new Guna.UI2.WinForms.Guna2Button();
			this.btnmod = new Guna.UI2.WinForms.Guna2Button();
			this.btnone = new Guna.UI2.WinForms.Guna2Button();
			this.btnfour = new Guna.UI2.WinForms.Guna2Button();
			this.btnseven = new Guna.UI2.WinForms.Guna2Button();
			this.btntwo = new Guna.UI2.WinForms.Guna2Button();
			this.btnfive = new Guna.UI2.WinForms.Guna2Button();
			this.btneight = new Guna.UI2.WinForms.Guna2Button();
			this.btndot = new Guna.UI2.WinForms.Guna2Button();
			this.btnzero = new Guna.UI2.WinForms.Guna2Button();
			this.btnequal = new Guna.UI2.WinForms.Guna2Button();
			this.btnclear = new Guna.UI2.WinForms.Guna2Button();
			this.txtstore = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtresult = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.BackColor = System.Drawing.Color.LightSalmon;
			this.lbl.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
			this.lbl.Location = new System.Drawing.Point(12, 12);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(179, 38);
			this.lbl.TabIndex = 1;
			this.lbl.Text = "Calculator APP";
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.Color.Transparent;
			this.btnexit.FillColor = System.Drawing.Color.Transparent;
			this.btnexit.Image = global::Calculator.Properties.Resources.shutdown_icon;
			this.btnexit.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
			this.btnexit.ImageRotate = 0F;
			this.btnexit.Location = new System.Drawing.Point(282, 12);
			this.btnexit.Name = "btnexit";
			this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.btnexit.Size = new System.Drawing.Size(43, 38);
			this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnexit.TabIndex = 0;
			this.btnexit.TabStop = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// btndiv
			// 
			this.btndiv.BackColor = System.Drawing.Color.Transparent;
			this.btndiv.BorderRadius = 15;
			this.btndiv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btndiv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btndiv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btndiv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btndiv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btndiv.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btndiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btndiv.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btndiv.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btndiv.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btndiv.Location = new System.Drawing.Point(232, 195);
			this.btndiv.Name = "btndiv";
			this.btndiv.ShadowDecoration.BorderRadius = 15;
			this.btndiv.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btndiv.ShadowDecoration.Enabled = true;
			this.btndiv.Size = new System.Drawing.Size(43, 40);
			this.btndiv.TabIndex = 2;
			this.btndiv.Text = "/";
			this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
			// 
			// btnmulti
			// 
			this.btnmulti.BackColor = System.Drawing.Color.Transparent;
			this.btnmulti.BorderRadius = 15;
			this.btnmulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnmulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnmulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnmulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnmulti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnmulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnmulti.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnmulti.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnmulti.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnmulti.Location = new System.Drawing.Point(232, 250);
			this.btnmulti.Name = "btnmulti";
			this.btnmulti.ShadowDecoration.BorderRadius = 15;
			this.btnmulti.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnmulti.ShadowDecoration.Enabled = true;
			this.btnmulti.Size = new System.Drawing.Size(43, 40);
			this.btnmulti.TabIndex = 3;
			this.btnmulti.Text = "x";
			this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
			// 
			// btnplus
			// 
			this.btnplus.BackColor = System.Drawing.Color.Transparent;
			this.btnplus.BorderRadius = 15;
			this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnplus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnplus.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnplus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnplus.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnplus.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnplus.Location = new System.Drawing.Point(232, 305);
			this.btnplus.Name = "btnplus";
			this.btnplus.ShadowDecoration.BorderRadius = 15;
			this.btnplus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnplus.ShadowDecoration.Enabled = true;
			this.btnplus.Size = new System.Drawing.Size(43, 40);
			this.btnplus.TabIndex = 4;
			this.btnplus.Text = "+";
			this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
			// 
			// btnminus
			// 
			this.btnminus.BackColor = System.Drawing.Color.Transparent;
			this.btnminus.BorderRadius = 15;
			this.btnminus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnminus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnminus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnminus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnminus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnminus.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnminus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnminus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnminus.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnminus.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnminus.Location = new System.Drawing.Point(232, 361);
			this.btnminus.Name = "btnminus";
			this.btnminus.ShadowDecoration.BorderRadius = 15;
			this.btnminus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnminus.ShadowDecoration.Enabled = true;
			this.btnminus.Size = new System.Drawing.Size(43, 40);
			this.btnminus.TabIndex = 5;
			this.btnminus.Text = "-";
			this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
			// 
			// btnthree
			// 
			this.btnthree.BackColor = System.Drawing.Color.Transparent;
			this.btnthree.BorderRadius = 15;
			this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnthree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnthree.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnthree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnthree.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnthree.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnthree.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnthree.Location = new System.Drawing.Point(173, 361);
			this.btnthree.Name = "btnthree";
			this.btnthree.ShadowDecoration.BorderRadius = 15;
			this.btnthree.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnthree.ShadowDecoration.Enabled = true;
			this.btnthree.Size = new System.Drawing.Size(43, 40);
			this.btnthree.TabIndex = 9;
			this.btnthree.Text = "3";
			this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
			// 
			// btnsix
			// 
			this.btnsix.BackColor = System.Drawing.Color.Transparent;
			this.btnsix.BorderRadius = 15;
			this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnsix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnsix.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnsix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnsix.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnsix.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnsix.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnsix.Location = new System.Drawing.Point(173, 305);
			this.btnsix.Name = "btnsix";
			this.btnsix.ShadowDecoration.BorderRadius = 15;
			this.btnsix.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnsix.ShadowDecoration.Enabled = true;
			this.btnsix.Size = new System.Drawing.Size(43, 40);
			this.btnsix.TabIndex = 8;
			this.btnsix.Text = "6";
			this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
			// 
			// btnnine
			// 
			this.btnnine.BackColor = System.Drawing.Color.Transparent;
			this.btnnine.BorderRadius = 15;
			this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnnine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnnine.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnnine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnnine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnnine.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnnine.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnnine.Location = new System.Drawing.Point(173, 250);
			this.btnnine.Name = "btnnine";
			this.btnnine.ShadowDecoration.BorderRadius = 15;
			this.btnnine.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnnine.ShadowDecoration.Enabled = true;
			this.btnnine.Size = new System.Drawing.Size(43, 40);
			this.btnnine.TabIndex = 7;
			this.btnnine.Text = "9";
			this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
			// 
			// btnmod
			// 
			this.btnmod.BackColor = System.Drawing.Color.Transparent;
			this.btnmod.BorderRadius = 15;
			this.btnmod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnmod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnmod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnmod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnmod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnmod.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnmod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnmod.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnmod.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnmod.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnmod.Location = new System.Drawing.Point(173, 195);
			this.btnmod.Name = "btnmod";
			this.btnmod.ShadowDecoration.BorderRadius = 15;
			this.btnmod.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnmod.ShadowDecoration.Enabled = true;
			this.btnmod.Size = new System.Drawing.Size(43, 40);
			this.btnmod.TabIndex = 6;
			this.btnmod.Text = "%";
			this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
			// 
			// btnone
			// 
			this.btnone.BackColor = System.Drawing.Color.Transparent;
			this.btnone.BorderRadius = 15;
			this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnone.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnone.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnone.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnone.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnone.Location = new System.Drawing.Point(57, 361);
			this.btnone.Name = "btnone";
			this.btnone.ShadowDecoration.BorderRadius = 15;
			this.btnone.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnone.ShadowDecoration.Enabled = true;
			this.btnone.Size = new System.Drawing.Size(43, 40);
			this.btnone.TabIndex = 13;
			this.btnone.Text = "1";
			this.btnone.Click += new System.EventHandler(this.btnone_Click);
			// 
			// btnfour
			// 
			this.btnfour.BackColor = System.Drawing.Color.Transparent;
			this.btnfour.BorderRadius = 15;
			this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnfour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnfour.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnfour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnfour.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnfour.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnfour.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnfour.Location = new System.Drawing.Point(57, 305);
			this.btnfour.Name = "btnfour";
			this.btnfour.ShadowDecoration.BorderRadius = 15;
			this.btnfour.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnfour.ShadowDecoration.Enabled = true;
			this.btnfour.Size = new System.Drawing.Size(43, 40);
			this.btnfour.TabIndex = 12;
			this.btnfour.Text = "4";
			this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
			// 
			// btnseven
			// 
			this.btnseven.BackColor = System.Drawing.Color.Transparent;
			this.btnseven.BorderRadius = 15;
			this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnseven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnseven.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnseven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnseven.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnseven.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnseven.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnseven.Location = new System.Drawing.Point(57, 250);
			this.btnseven.Name = "btnseven";
			this.btnseven.ShadowDecoration.BorderRadius = 15;
			this.btnseven.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnseven.ShadowDecoration.Enabled = true;
			this.btnseven.Size = new System.Drawing.Size(43, 40);
			this.btnseven.TabIndex = 11;
			this.btnseven.Text = "7";
			this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
			// 
			// btntwo
			// 
			this.btntwo.BackColor = System.Drawing.Color.Transparent;
			this.btntwo.BorderRadius = 15;
			this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btntwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btntwo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btntwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btntwo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btntwo.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btntwo.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btntwo.Location = new System.Drawing.Point(115, 361);
			this.btntwo.Name = "btntwo";
			this.btntwo.ShadowDecoration.BorderRadius = 15;
			this.btntwo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btntwo.ShadowDecoration.Enabled = true;
			this.btntwo.Size = new System.Drawing.Size(43, 40);
			this.btntwo.TabIndex = 17;
			this.btntwo.Text = "2";
			this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
			// 
			// btnfive
			// 
			this.btnfive.BackColor = System.Drawing.Color.Transparent;
			this.btnfive.BorderRadius = 15;
			this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnfive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnfive.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnfive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnfive.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnfive.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnfive.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnfive.Location = new System.Drawing.Point(115, 305);
			this.btnfive.Name = "btnfive";
			this.btnfive.ShadowDecoration.BorderRadius = 15;
			this.btnfive.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnfive.ShadowDecoration.Enabled = true;
			this.btnfive.Size = new System.Drawing.Size(43, 40);
			this.btnfive.TabIndex = 16;
			this.btnfive.Text = "5";
			this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
			// 
			// btneight
			// 
			this.btneight.BackColor = System.Drawing.Color.Transparent;
			this.btneight.BorderRadius = 15;
			this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btneight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btneight.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btneight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btneight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btneight.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btneight.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btneight.Location = new System.Drawing.Point(115, 250);
			this.btneight.Name = "btneight";
			this.btneight.ShadowDecoration.BorderRadius = 15;
			this.btneight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btneight.ShadowDecoration.Enabled = true;
			this.btneight.Size = new System.Drawing.Size(43, 40);
			this.btneight.TabIndex = 15;
			this.btneight.Text = "8";
			this.btneight.Click += new System.EventHandler(this.btneight_Click);
			// 
			// btndot
			// 
			this.btndot.BackColor = System.Drawing.Color.Transparent;
			this.btndot.BorderRadius = 15;
			this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btndot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btndot.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btndot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btndot.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btndot.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btndot.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btndot.Location = new System.Drawing.Point(115, 416);
			this.btndot.Name = "btndot";
			this.btndot.ShadowDecoration.BorderRadius = 15;
			this.btndot.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btndot.ShadowDecoration.Enabled = true;
			this.btndot.Size = new System.Drawing.Size(43, 40);
			this.btndot.TabIndex = 21;
			this.btndot.Text = ".";
			this.btndot.Click += new System.EventHandler(this.btndot_Click);
			// 
			// btnzero
			// 
			this.btnzero.BackColor = System.Drawing.Color.Transparent;
			this.btnzero.BorderRadius = 15;
			this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnzero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnzero.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnzero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnzero.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnzero.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnzero.Location = new System.Drawing.Point(57, 416);
			this.btnzero.Name = "btnzero";
			this.btnzero.ShadowDecoration.BorderRadius = 15;
			this.btnzero.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnzero.ShadowDecoration.Enabled = true;
			this.btnzero.Size = new System.Drawing.Size(43, 40);
			this.btnzero.TabIndex = 20;
			this.btnzero.Text = "0";
			this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
			// 
			// btnequal
			// 
			this.btnequal.BackColor = System.Drawing.Color.Transparent;
			this.btnequal.BorderRadius = 15;
			this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnequal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnequal.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnequal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnequal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnequal.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnequal.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnequal.Location = new System.Drawing.Point(173, 416);
			this.btnequal.Name = "btnequal";
			this.btnequal.ShadowDecoration.BorderRadius = 15;
			this.btnequal.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnequal.ShadowDecoration.Enabled = true;
			this.btnequal.Size = new System.Drawing.Size(102, 40);
			this.btnequal.TabIndex = 19;
			this.btnequal.Text = "=";
			this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
			// 
			// btnclear
			// 
			this.btnclear.BackColor = System.Drawing.Color.Transparent;
			this.btnclear.BorderRadius = 15;
			this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnclear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnclear.HoverState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnclear.HoverState.ForeColor = System.Drawing.Color.Black;
			this.btnclear.Location = new System.Drawing.Point(57, 195);
			this.btnclear.Name = "btnclear";
			this.btnclear.ShadowDecoration.BorderRadius = 15;
			this.btnclear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnclear.ShadowDecoration.Enabled = true;
			this.btnclear.Size = new System.Drawing.Size(101, 40);
			this.btnclear.TabIndex = 10;
			this.btnclear.Text = "C";
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// txtstore
			// 
			this.txtstore.BorderThickness = 0;
			this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtstore.DefaultText = "";
			this.txtstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtstore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.txtstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtstore.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.txtstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtstore.Location = new System.Drawing.Point(57, 138);
			this.txtstore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtstore.Name = "txtstore";
			this.txtstore.PasswordChar = '\0';
			this.txtstore.PlaceholderText = "";
			this.txtstore.SelectedText = "";
			this.txtstore.Size = new System.Drawing.Size(224, 34);
			this.txtstore.TabIndex = 22;
			this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtresult
			// 
			this.txtresult.BorderThickness = 0;
			this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtresult.DefaultText = "";
			this.txtresult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtresult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtresult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtresult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtresult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.txtresult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtresult.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.txtresult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtresult.Location = new System.Drawing.Point(57, 77);
			this.txtresult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtresult.Name = "txtresult";
			this.txtresult.PasswordChar = '\0';
			this.txtresult.PlaceholderText = "0";
			this.txtresult.SelectedText = "";
			this.txtresult.Size = new System.Drawing.Size(224, 49);
			this.txtresult.TabIndex = 23;
			this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(337, 509);
			this.Controls.Add(this.txtresult);
			this.Controls.Add(this.txtstore);
			this.Controls.Add(this.btndot);
			this.Controls.Add(this.btnzero);
			this.Controls.Add(this.btnequal);
			this.Controls.Add(this.btntwo);
			this.Controls.Add(this.btnfive);
			this.Controls.Add(this.btneight);
			this.Controls.Add(this.btnone);
			this.Controls.Add(this.btnfour);
			this.Controls.Add(this.btnseven);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.btnthree);
			this.Controls.Add(this.btnsix);
			this.Controls.Add(this.btnnine);
			this.Controls.Add(this.btnmod);
			this.Controls.Add(this.btnminus);
			this.Controls.Add(this.btnplus);
			this.Controls.Add(this.btnmulti);
			this.Controls.Add(this.btndiv);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.btnexit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2CirclePictureBox btnexit;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl;
		private Guna.UI2.WinForms.Guna2Button btndiv;
		private Guna.UI2.WinForms.Guna2Button btnmulti;
		private Guna.UI2.WinForms.Guna2Button btnplus;
		private Guna.UI2.WinForms.Guna2Button btnminus;
		private Guna.UI2.WinForms.Guna2Button btnthree;
		private Guna.UI2.WinForms.Guna2Button btnsix;
		private Guna.UI2.WinForms.Guna2Button btnnine;
		private Guna.UI2.WinForms.Guna2Button btnmod;
		private Guna.UI2.WinForms.Guna2Button btnone;
		private Guna.UI2.WinForms.Guna2Button btnfour;
		private Guna.UI2.WinForms.Guna2Button btnseven;
		private Guna.UI2.WinForms.Guna2Button btntwo;
		private Guna.UI2.WinForms.Guna2Button btnfive;
		private Guna.UI2.WinForms.Guna2Button btneight;
		private Guna.UI2.WinForms.Guna2Button btndot;
		private Guna.UI2.WinForms.Guna2Button btnzero;
		private Guna.UI2.WinForms.Guna2Button btnequal;
		private Guna.UI2.WinForms.Guna2Button btnclear;
		private Guna.UI2.WinForms.Guna2TextBox txtstore;
		private Guna.UI2.WinForms.Guna2TextBox txtresult;
	}
}

