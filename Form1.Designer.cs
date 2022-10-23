namespace Vrijeme
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusTrenutnoVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusProtekloVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTrenutnoVrijeme,
            this.toolStripStatusProtekloVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(383, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusTrenutnoVrijeme
            // 
            this.toolStripStatusTrenutnoVrijeme.Name = "toolStripStatusTrenutnoVrijeme";
            this.toolStripStatusTrenutnoVrijeme.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusTrenutnoVrijeme.Text = "s";
            // 
            // toolStripStatusProtekloVrijeme
            // 
            this.toolStripStatusProtekloVrijeme.Name = "toolStripStatusProtekloVrijeme";
            this.toolStripStatusProtekloVrijeme.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusProtekloVrijeme.Text = "f";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 222);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusTrenutnoVrijeme;
        private ToolStripStatusLabel toolStripStatusProtekloVrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}