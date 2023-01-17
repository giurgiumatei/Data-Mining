namespace EdgeDetectionComparison
{
    partial class SobelParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericXOrder = new System.Windows.Forms.NumericUpDown();
            this.numericYOrder = new System.Windows.Forms.NumericUpDown();
            this.numericAperture = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericXOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAperture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericAperture);
            this.groupBox1.Controls.Add(this.numericYOrder);
            this.groupBox1.Controls.Add(this.numericXOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aperture: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Order: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Order: ";
            // 
            // numericXOrder
            // 
            this.numericXOrder.Location = new System.Drawing.Point(176, 57);
            this.numericXOrder.Name = "numericXOrder";
            this.numericXOrder.Size = new System.Drawing.Size(150, 27);
            this.numericXOrder.TabIndex = 3;
            this.numericXOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericYOrder
            // 
            this.numericYOrder.Location = new System.Drawing.Point(176, 135);
            this.numericYOrder.Name = "numericYOrder";
            this.numericYOrder.Size = new System.Drawing.Size(150, 27);
            this.numericYOrder.TabIndex = 4;
            this.numericYOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericAperture
            // 
            this.numericAperture.Location = new System.Drawing.Point(176, 212);
            this.numericAperture.Name = "numericAperture";
            this.numericAperture.Size = new System.Drawing.Size(150, 27);
            this.numericAperture.TabIndex = 5;
            this.numericAperture.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SobelParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SobelParameters";
            this.Text = "SobelParameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericXOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAperture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericAperture;
        private NumericUpDown numericYOrder;
        private NumericUpDown numericXOrder;
        private Button button2;
        private Button button1;
    }
}