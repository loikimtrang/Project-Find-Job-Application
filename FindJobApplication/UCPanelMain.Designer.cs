namespace FindJobApplication
{
    partial class UCPanelMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 16;
            this.pnlMain.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnlMain.CustomizableEdges.BottomLeft = false;
            this.pnlMain.CustomizableEdges.BottomRight = false;
            this.pnlMain.CustomizableEdges.TopRight = false;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1776, 1438);
            this.pnlMain.TabIndex = 37;
            // 
            // UCPanelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPanelMain";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.Size = new System.Drawing.Size(1776, 1438);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMain;
    }
}
