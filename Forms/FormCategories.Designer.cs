namespace SmartPOS.Forms
{
    partial class FormCategories
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sBtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sBtnNew = new System.Windows.Forms.ToolStripButton();
            this.sBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.sBtnBack = new System.Windows.Forms.ToolStripButton();
            this.sBtnNext = new System.Windows.Forms.ToolStripButton();
            this.sBtnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sBtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sBtnSelect,
            this.toolStripSeparator1,
            this.sBtnNew,
            this.sBtnSave,
            this.toolStripSeparator2,
            this.sBtnFirst,
            this.sBtnBack,
            this.sBtnNext,
            this.sBtnLast,
            this.toolStripSeparator3,
            this.sBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 73);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sBtnSelect
            // 
            this.sBtnSelect.Image = global::SmartPOS.Properties.Resources.frequency;
            this.sBtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnSelect.Name = "sBtnSelect";
            this.sBtnSelect.Size = new System.Drawing.Size(53, 70);
            this.sBtnSelect.Text = "Select";
            this.sBtnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnSelect.Click += new System.EventHandler(this.sBtnSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // sBtnNew
            // 
            this.sBtnNew.Image = global::SmartPOS.Properties.Resources.add_file;
            this.sBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnNew.Name = "sBtnNew";
            this.sBtnNew.Size = new System.Drawing.Size(50, 70);
            this.sBtnNew.Text = "New";
            this.sBtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnNew.Click += new System.EventHandler(this.sBtnNew_Click);
            // 
            // sBtnSave
            // 
            this.sBtnSave.Image = global::SmartPOS.Properties.Resources.floppy_disk2;
            this.sBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnSave.Name = "sBtnSave";
            this.sBtnSave.Size = new System.Drawing.Size(50, 70);
            this.sBtnSave.Text = "Save";
            this.sBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnSave.Click += new System.EventHandler(this.sBtnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // sBtnFirst
            // 
            this.sBtnFirst.Image = global::SmartPOS.Properties.Resources.previous;
            this.sBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnFirst.Name = "sBtnFirst";
            this.sBtnFirst.Size = new System.Drawing.Size(50, 70);
            this.sBtnFirst.Text = "First";
            this.sBtnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnFirst.Click += new System.EventHandler(this.sBtnFirst_Click);
            // 
            // sBtnBack
            // 
            this.sBtnBack.Image = global::SmartPOS.Properties.Resources.back;
            this.sBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnBack.Name = "sBtnBack";
            this.sBtnBack.Size = new System.Drawing.Size(50, 70);
            this.sBtnBack.Text = "Back";
            this.sBtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnBack.Click += new System.EventHandler(this.sBtnBack_Click);
            // 
            // sBtnNext
            // 
            this.sBtnNext.Image = global::SmartPOS.Properties.Resources.play;
            this.sBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnNext.Name = "sBtnNext";
            this.sBtnNext.Size = new System.Drawing.Size(50, 70);
            this.sBtnNext.Text = "Next";
            this.sBtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnNext.Click += new System.EventHandler(this.sBtnNext_Click);
            // 
            // sBtnLast
            // 
            this.sBtnLast.Image = global::SmartPOS.Properties.Resources.next;
            this.sBtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnLast.Name = "sBtnLast";
            this.sBtnLast.Size = new System.Drawing.Size(50, 70);
            this.sBtnLast.Text = "Last";
            this.sBtnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnLast.Click += new System.EventHandler(this.sBtnLast_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // sBtnExit
            // 
            this.sBtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sBtnExit.Image = global::SmartPOS.Properties.Resources.log_out2;
            this.sBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sBtnExit.Name = "sBtnExit";
            this.sBtnExit.Size = new System.Drawing.Size(50, 70);
            this.sBtnExit.Text = "Exit";
            this.sBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(49, 119);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(271, 22);
            this.txtDes.TabIndex = 37;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(9, 119);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(32, 16);
            this.lblDes.TabIndex = 36;
            this.lblDes.Text = "Des";
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 272);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormCategories";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategories";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sBtnSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sBtnNew;
        private System.Windows.Forms.ToolStripButton sBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton sBtnFirst;
        private System.Windows.Forms.ToolStripButton sBtnBack;
        private System.Windows.Forms.ToolStripButton sBtnNext;
        private System.Windows.Forms.ToolStripButton sBtnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton sBtnExit;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDes;
    }
}