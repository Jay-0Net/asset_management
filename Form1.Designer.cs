namespace Asset_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.greeting = new System.Windows.Forms.Label();
            this.prompt = new System.Windows.Forms.Label();
            this.dpt = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.Deptf = new System.Windows.Forms.TextBox();
            this.Nameef = new System.Windows.Forms.TextBox();
            this.Passf = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.err = new System.Windows.Forms.Label();
            this.PNmae = new System.Windows.Forms.Label();
            this.PWarrant = new System.Windows.Forms.Label();
            this.PManufacture = new System.Windows.Forms.Label();
            this.PType = new System.Windows.Forms.Label();
            this.PBrand = new System.Windows.Forms.Label();
            this.PNmaef = new System.Windows.Forms.TextBox();
            this.PBrandf = new System.Windows.Forms.TextBox();
            this.PManufacturef = new System.Windows.Forms.TextBox();
            this.PConditionF = new System.Windows.Forms.TextBox();
            this.PTypef = new System.Windows.Forms.TextBox();
            this.PWarrantf = new System.Windows.Forms.TextBox();
            this.PCondition = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.greeting.Location = new System.Drawing.Point(178, 237);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(143, 36);
            this.greeting.TabIndex = 2;
            this.greeting.Text = "Welcome";
            this.greeting.Click += new System.EventHandler(this.prompt1);
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prompt.Location = new System.Drawing.Point(79, 293);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(375, 26);
            this.prompt.TabIndex = 3;
            this.prompt.Text = "Please Login Into your Admin account";
            this.prompt.Click += new System.EventHandler(this.com1);
            // 
            // dpt
            // 
            this.dpt.AutoSize = true;
            this.dpt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dpt.Location = new System.Drawing.Point(84, 365);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(86, 18);
            this.dpt.TabIndex = 4;
            this.dpt.Text = "Department";
            this.dpt.Click += new System.EventHandler(this.Dep);
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Uname.Location = new System.Drawing.Point(82, 401);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(77, 18);
            this.Uname.TabIndex = 6;
            this.Uname.Text = "UserName";
            this.Uname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Uname.Click += new System.EventHandler(this.UserN);
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pwd.Location = new System.Drawing.Point(84, 454);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(69, 18);
            this.pwd.TabIndex = 7;
            this.pwd.Text = "Password";
            this.pwd.Click += new System.EventHandler(this.Pass);
            // 
            // Deptf
            // 
            this.Deptf.BackColor = System.Drawing.Color.White;
            this.Deptf.ForeColor = System.Drawing.Color.Black;
            this.Deptf.Location = new System.Drawing.Point(184, 363);
            this.Deptf.Name = "Deptf";
            this.Deptf.Size = new System.Drawing.Size(141, 20);
            this.Deptf.TabIndex = 9;
            this.Deptf.TextChanged += new System.EventHandler(this.DepEN);
            // 
            // Nameef
            // 
            this.Nameef.BackColor = System.Drawing.Color.White;
            this.Nameef.Location = new System.Drawing.Point(184, 408);
            this.Nameef.Name = "Nameef";
            this.Nameef.Size = new System.Drawing.Size(141, 20);
            this.Nameef.TabIndex = 10;
            this.Nameef.TextChanged += new System.EventHandler(this.UserNEN);
            // 
            // Passf
            // 
            this.Passf.BackColor = System.Drawing.Color.White;
            this.Passf.Location = new System.Drawing.Point(184, 455);
            this.Passf.Name = "Passf";
            this.Passf.Size = new System.Drawing.Size(141, 20);
            this.Passf.TabIndex = 11;
            this.Passf.TextChanged += new System.EventHandler(this.PassEn);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(158, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "No account ? Click to contact Developer";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Con);
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.Location = new System.Drawing.Point(203, 534);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(89, 39);
            this.Login.TabIndex = 13;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.login);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 186);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(293, 386);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(227, 13);
            this.err.TabIndex = 14;
            this.err.Text = "Erro Login, Please enter the correct credintials ";
            this.err.Visible = false;
            this.err.Click += new System.EventHandler(this.err_Click);
            // 
            // PNmae
            // 
            this.PNmae.AutoSize = true;
            this.PNmae.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNmae.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PNmae.Location = new System.Drawing.Point(81, 255);
            this.PNmae.Name = "PNmae";
            this.PNmae.Size = new System.Drawing.Size(47, 18);
            this.PNmae.TabIndex = 16;
            this.PNmae.Text = "Name";
            this.PNmae.Visible = false;
            // 
            // PWarrant
            // 
            this.PWarrant.AutoSize = true;
            this.PWarrant.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWarrant.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PWarrant.Location = new System.Drawing.Point(84, 497);
            this.PWarrant.Name = "PWarrant";
            this.PWarrant.Size = new System.Drawing.Size(147, 18);
            this.PWarrant.TabIndex = 17;
            this.PWarrant.Text = "Warranty or ExpDate";
            this.PWarrant.Visible = false;
            // 
            // PManufacture
            // 
            this.PManufacture.AutoSize = true;
            this.PManufacture.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PManufacture.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PManufacture.Location = new System.Drawing.Point(81, 410);
            this.PManufacture.Name = "PManufacture";
            this.PManufacture.Size = new System.Drawing.Size(82, 18);
            this.PManufacture.TabIndex = 18;
            this.PManufacture.Text = "Manufactor";
            this.PManufacture.Visible = false;
            this.PManufacture.Click += new System.EventHandler(this.PManufacture_Click);
            // 
            // PType
            // 
            this.PType.AutoSize = true;
            this.PType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PType.Location = new System.Drawing.Point(82, 349);
            this.PType.Name = "PType";
            this.PType.Size = new System.Drawing.Size(42, 18);
            this.PType.TabIndex = 19;
            this.PType.Text = "Type";
            this.PType.Visible = false;
            this.PType.Click += new System.EventHandler(this.label10_Click);
            // 
            // PBrand
            // 
            this.PBrand.AutoSize = true;
            this.PBrand.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PBrand.Location = new System.Drawing.Point(82, 299);
            this.PBrand.Name = "PBrand";
            this.PBrand.Size = new System.Drawing.Size(46, 18);
            this.PBrand.TabIndex = 20;
            this.PBrand.Text = "Brand";
            this.PBrand.Visible = false;
            this.PBrand.Click += new System.EventHandler(this.label11_Click);
            // 
            // PNmaef
            // 
            this.PNmaef.BackColor = System.Drawing.Color.White;
            this.PNmaef.ForeColor = System.Drawing.Color.Black;
            this.PNmaef.Location = new System.Drawing.Point(237, 256);
            this.PNmaef.Name = "PNmaef";
            this.PNmaef.Size = new System.Drawing.Size(141, 20);
            this.PNmaef.TabIndex = 21;
            this.PNmaef.Visible = false;
            // 
            // PBrandf
            // 
            this.PBrandf.BackColor = System.Drawing.Color.White;
            this.PBrandf.ForeColor = System.Drawing.Color.Black;
            this.PBrandf.Location = new System.Drawing.Point(237, 299);
            this.PBrandf.Name = "PBrandf";
            this.PBrandf.Size = new System.Drawing.Size(141, 20);
            this.PBrandf.TabIndex = 22;
            this.PBrandf.Visible = false;
            // 
            // PManufacturef
            // 
            this.PManufacturef.BackColor = System.Drawing.Color.White;
            this.PManufacturef.ForeColor = System.Drawing.Color.Black;
            this.PManufacturef.Location = new System.Drawing.Point(237, 402);
            this.PManufacturef.Name = "PManufacturef";
            this.PManufacturef.Size = new System.Drawing.Size(141, 20);
            this.PManufacturef.TabIndex = 23;
            this.PManufacturef.Visible = false;
            // 
            // PConditionF
            // 
            this.PConditionF.BackColor = System.Drawing.Color.White;
            this.PConditionF.ForeColor = System.Drawing.Color.Black;
            this.PConditionF.Location = new System.Drawing.Point(237, 451);
            this.PConditionF.Name = "PConditionF";
            this.PConditionF.Size = new System.Drawing.Size(141, 20);
            this.PConditionF.TabIndex = 24;
            this.PConditionF.Visible = false;
            // 
            // PTypef
            // 
            this.PTypef.BackColor = System.Drawing.Color.White;
            this.PTypef.ForeColor = System.Drawing.Color.Black;
            this.PTypef.Location = new System.Drawing.Point(237, 347);
            this.PTypef.Name = "PTypef";
            this.PTypef.Size = new System.Drawing.Size(141, 20);
            this.PTypef.TabIndex = 25;
            this.PTypef.Visible = false;
            // 
            // PWarrantf
            // 
            this.PWarrantf.BackColor = System.Drawing.Color.White;
            this.PWarrantf.ForeColor = System.Drawing.Color.Black;
            this.PWarrantf.Location = new System.Drawing.Point(237, 498);
            this.PWarrantf.Name = "PWarrantf";
            this.PWarrantf.Size = new System.Drawing.Size(141, 20);
            this.PWarrantf.TabIndex = 26;
            this.PWarrantf.Visible = false;
            // 
            // PCondition
            // 
            this.PCondition.AutoSize = true;
            this.PCondition.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCondition.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PCondition.Location = new System.Drawing.Point(81, 453);
            this.PCondition.Name = "PCondition";
            this.PCondition.Size = new System.Drawing.Size(66, 18);
            this.PCondition.TabIndex = 27;
            this.PCondition.Text = "Condition";
            this.PCondition.Visible = false;
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.Location = new System.Drawing.Point(237, 534);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 53);
            this.Back.TabIndex = 28;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.UseWaitCursor = true;
            this.Back.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(518, 585);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PCondition);
            this.Controls.Add(this.PWarrantf);
            this.Controls.Add(this.PTypef);
            this.Controls.Add(this.PConditionF);
            this.Controls.Add(this.PManufacturef);
            this.Controls.Add(this.PBrandf);
            this.Controls.Add(this.PNmaef);
            this.Controls.Add(this.PBrand);
            this.Controls.Add(this.PType);
            this.Controls.Add(this.PManufacture);
            this.Controls.Add(this.PWarrant);
            this.Controls.Add(this.PNmae);
            this.Controls.Add(this.err);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Passf);
            this.Controls.Add(this.Nameef);
            this.Controls.Add(this.Deptf);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.dpt);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.Label dpt;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox Deptf;
        private System.Windows.Forms.TextBox Nameef;
        private System.Windows.Forms.TextBox Passf;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.Label PNmae;
        private System.Windows.Forms.Label PWarrant;
        private System.Windows.Forms.Label PManufacture;
        private System.Windows.Forms.Label PType;
        private System.Windows.Forms.Label PBrand;
        private System.Windows.Forms.TextBox PNmaef;
        private System.Windows.Forms.TextBox PBrandf;
        private System.Windows.Forms.TextBox PManufacturef;
        private System.Windows.Forms.TextBox PConditionF;
        private System.Windows.Forms.TextBox PTypef;
        private System.Windows.Forms.TextBox PWarrantf;
        private System.Windows.Forms.Label PCondition;
        private System.Windows.Forms.Button Back;
    }
}

