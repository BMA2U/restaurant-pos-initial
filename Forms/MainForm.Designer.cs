namespace SmartPOS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlV = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblVe = new System.Windows.Forms.Label();
            this.lblNameOfApp = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnExitAll = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPointOfSale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlV.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlMenu.Controls.Add(this.pnlV);
            this.pnlMenu.Controls.Add(this.btnOptions);
            this.pnlMenu.Controls.Add(this.btnReporting);
            this.pnlMenu.Controls.Add(this.btnSetup);
            this.pnlMenu.Controls.Add(this.btnPointOfSale);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(294, 719);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlV
            // 
            this.pnlV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlV.Controls.Add(this.linkLabel1);
            this.pnlV.Controls.Add(this.lblVe);
            this.pnlV.Controls.Add(this.lblNameOfApp);
            this.pnlV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlV.Location = new System.Drawing.Point(0, 623);
            this.pnlV.Name = "pnlV";
            this.pnlV.Size = new System.Drawing.Size(294, 96);
            this.pnlV.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(32, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 26);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bassem Al-Taheri";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblVe
            // 
            this.lblVe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVe.AutoSize = true;
            this.lblVe.BackColor = System.Drawing.Color.Transparent;
            this.lblVe.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVe.ForeColor = System.Drawing.Color.White;
            this.lblVe.Location = new System.Drawing.Point(89, 31);
            this.lblVe.Name = "lblVe";
            this.lblVe.Size = new System.Drawing.Size(57, 29);
            this.lblVe.TabIndex = 1;
            this.lblVe.Text = "v0.1";
            this.lblVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameOfApp
            // 
            this.lblNameOfApp.AutoSize = true;
            this.lblNameOfApp.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOfApp.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfApp.ForeColor = System.Drawing.Color.White;
            this.lblNameOfApp.Location = new System.Drawing.Point(12, 2);
            this.lblNameOfApp.Name = "lblNameOfApp";
            this.lblNameOfApp.Size = new System.Drawing.Size(228, 29);
            this.lblNameOfApp.TabIndex = 0;
            this.lblNameOfApp.Text = "The Culinary Haven";
            this.lblNameOfApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(294, 95);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(839, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 27);
            this.lblTime.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Gray;
            this.pnlTitle.Controls.Add(this.btnExitAll);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblTime);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(294, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1138, 95);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Point Of Sale";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(294, 95);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1138, 624);
            this.pnlMain.TabIndex = 2;
            // 
            // btnExitAll
            // 
            this.btnExitAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAll.BackColor = System.Drawing.Color.Silver;
            this.btnExitAll.BackgroundImage = global::SmartPOS.Properties.Resources.exit;
            this.btnExitAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitAll.Location = new System.Drawing.Point(1028, 28);
            this.btnExitAll.Name = "btnExitAll";
            this.btnExitAll.Size = new System.Drawing.Size(98, 67);
            this.btnExitAll.TabIndex = 2;
            this.btnExitAll.UseVisualStyleBackColor = false;
            this.btnExitAll.Click += new System.EventHandler(this.btnExitAll_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = global::SmartPOS.Properties.Resources.gear;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(0, 290);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(294, 65);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 225);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(294, 65);
            this.btnReporting.TabIndex = 3;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ForeColor = System.Drawing.Color.White;
            this.btnSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetup.Image")));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 160);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(294, 65);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPointOfSale
            // 
            this.btnPointOfSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPointOfSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPointOfSale.FlatAppearance.BorderSize = 0;
            this.btnPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointOfSale.ForeColor = System.Drawing.Color.White;
            this.btnPointOfSale.Image = ((System.Drawing.Image)(resources.GetObject("btnPointOfSale.Image")));
            this.btnPointOfSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPointOfSale.Location = new System.Drawing.Point(0, 95);
            this.btnPointOfSale.Name = "btnPointOfSale";
            this.btnPointOfSale.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPointOfSale.Size = new System.Drawing.Size(294, 65);
            this.btnPointOfSale.TabIndex = 1;
            this.btnPointOfSale.Text = "Point Of Sale";
            this.btnPointOfSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPointOfSale.UseVisualStyleBackColor = true;
            this.btnPointOfSale.Click += new System.EventHandler(this.btnPointOfSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SmartPOS.Properties.Resources.Gemini_Generated_Image_xt7bj7xt7bj7xt7b__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1432, 719);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1450, 766);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Emerald Oasis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlV.ResumeLayout(false);
            this.pnlV.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnPointOfSale;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlV;
        private System.Windows.Forms.Label lblNameOfApp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblVe;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnExitAll;
    }
}

