namespace WindowsFormsApp1
{
    partial class DataBase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glaciersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataTablesToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.aboutSoftwareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataTablesToolStripMenuItem
            // 
            this.dataTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.researchesToolStripMenuItem,
            this.glaciersToolStripMenuItem,
            this.researchGroupsToolStripMenuItem});
            this.dataTablesToolStripMenuItem.Name = "dataTablesToolStripMenuItem";
            this.dataTablesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.dataTablesToolStripMenuItem.Text = "Data Tables";
            // 
            // researchesToolStripMenuItem
            // 
            this.researchesToolStripMenuItem.Name = "researchesToolStripMenuItem";
            this.researchesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.researchesToolStripMenuItem.Text = "Researches";
            this.researchesToolStripMenuItem.Click += new System.EventHandler(this.researchesToolStripMenuItem_Click);
            // 
            // glaciersToolStripMenuItem
            // 
            this.glaciersToolStripMenuItem.Name = "glaciersToolStripMenuItem";
            this.glaciersToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.glaciersToolStripMenuItem.Text = "Glaciers";
            this.glaciersToolStripMenuItem.Click += new System.EventHandler(this.glaciersToolStripMenuItem_Click);
            // 
            // researchGroupsToolStripMenuItem
            // 
            this.researchGroupsToolStripMenuItem.Name = "researchGroupsToolStripMenuItem";
            this.researchGroupsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.researchGroupsToolStripMenuItem.Text = "Research groups";
            this.researchGroupsToolStripMenuItem.Click += new System.EventHandler(this.researchGroupsToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem1});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.calculatorToolStripMenuItem.Text = "Addons";
            // 
            // calculatorToolStripMenuItem1
            // 
            this.calculatorToolStripMenuItem1.Name = "calculatorToolStripMenuItem1";
            this.calculatorToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.calculatorToolStripMenuItem1.Text = "Calculator";
            // 
            // aboutSoftwareToolStripMenuItem
            // 
            this.aboutSoftwareToolStripMenuItem.Name = "aboutSoftwareToolStripMenuItem";
            this.aboutSoftwareToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.aboutSoftwareToolStripMenuItem.Text = "About software";
            this.aboutSoftwareToolStripMenuItem.Click += new System.EventHandler(this.aboutSoftwareToolStripMenuItem_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataBase";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataBase_FormClosed);
            this.Load += new System.EventHandler(this.DataBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glaciersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftwareToolStripMenuItem;
    }
}