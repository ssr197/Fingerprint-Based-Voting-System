namespace Finger_ATM
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addElectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVotersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caculateResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToolStripMenuItem,
            this.addElectionToolStripMenuItem,
            this.addVotersToolStripMenuItem,
            this.caculateResultToolStripMenuItem,
            this.viewResultToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.addCandidateToolStripMenuItem.Text = "Add Candidate";
            this.addCandidateToolStripMenuItem.Click += new System.EventHandler(this.addCandidateToolStripMenuItem_Click);
            // 
            // addElectionToolStripMenuItem
            // 
            this.addElectionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addElectionToolStripMenuItem.Name = "addElectionToolStripMenuItem";
            this.addElectionToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.addElectionToolStripMenuItem.Text = "Add Election";
            this.addElectionToolStripMenuItem.Click += new System.EventHandler(this.addElectionToolStripMenuItem_Click);
            // 
            // addVotersToolStripMenuItem
            // 
            this.addVotersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addVotersToolStripMenuItem.Name = "addVotersToolStripMenuItem";
            this.addVotersToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.addVotersToolStripMenuItem.Text = "Add Voters";
            this.addVotersToolStripMenuItem.Click += new System.EventHandler(this.addVotersToolStripMenuItem_Click);
            // 
            // viewResultToolStripMenuItem
            // 
            this.viewResultToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewResultToolStripMenuItem.Name = "viewResultToolStripMenuItem";
            this.viewResultToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.viewResultToolStripMenuItem.Text = "View Result";
            this.viewResultToolStripMenuItem.Click += new System.EventHandler(this.viewResultToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // caculateResultToolStripMenuItem
            // 
            this.caculateResultToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.caculateResultToolStripMenuItem.Name = "caculateResultToolStripMenuItem";
            this.caculateResultToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.caculateResultToolStripMenuItem.Text = "Caculate Result";
            this.caculateResultToolStripMenuItem.Click += new System.EventHandler(this.caculateResultToolStripMenuItem_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addElectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVotersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caculateResultToolStripMenuItem;
    }
}