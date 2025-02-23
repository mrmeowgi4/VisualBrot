namespace VisualBrot
{
    partial class VisualBrot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualBrot));
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(394, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 393);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 146);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(376, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Number of iterations";
            label1.Click += label1_Click;
            // 
            // VisualBrot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1078, 681);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualBrot";
            Text = "VisualBrot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TrackBar trackBar1;
        private Label label1;
    }
}
