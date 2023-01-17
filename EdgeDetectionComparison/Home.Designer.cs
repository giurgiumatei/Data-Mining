namespace EdgeDetectionComparison
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.laplacianParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.edgeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(128, 26);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 26);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.cannyParametersToolStripMenuItem,
            this.sobelParametersToolStripMenuItem,
            this.laplacianParametersToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // cannyParametersToolStripMenuItem
            // 
            this.cannyParametersToolStripMenuItem.Name = "cannyParametersToolStripMenuItem";
            this.cannyParametersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cannyParametersToolStripMenuItem.Text = "Canny Parameters";
            this.cannyParametersToolStripMenuItem.Click += new System.EventHandler(this.cannyParametersToolStripMenuItem_Click);
            // 
            // sobelParametersToolStripMenuItem
            // 
            this.sobelParametersToolStripMenuItem.Name = "sobelParametersToolStripMenuItem";
            this.sobelParametersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.sobelParametersToolStripMenuItem.Text = "Sobel Parameters";
            this.sobelParametersToolStripMenuItem.Click += new System.EventHandler(this.sobelParametersToolStripMenuItem_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 28);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(800, 422);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // laplacianParametersToolStripMenuItem
            // 
            this.laplacianParametersToolStripMenuItem.Name = "laplacianParametersToolStripMenuItem";
            this.laplacianParametersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.laplacianParametersToolStripMenuItem.Text = "Laplacian Parameters";
            this.laplacianParametersToolStripMenuItem.Click += new System.EventHandler(this.laplacianParametersToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem open;
        private ToolStripMenuItem exit;
        private ToolStripMenuItem edgeToolStripMenuItem;
        private ToolStripMenuItem cannyToolStripMenuItem;
        private ToolStripMenuItem sobelToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imageBox1;
        private ToolStripMenuItem cannyParametersToolStripMenuItem;
        private ToolStripMenuItem sobelParametersToolStripMenuItem;
        private ToolStripMenuItem laplacianParametersToolStripMenuItem;
    }
}