namespace FindJobApplication.Utils
{
    partial class DialogBox
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
            this.pbState = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pblButtonGroup = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            this.SuspendLayout();
            // 
            // pbState
            // 
            this.pbState.Location = new System.Drawing.Point(1, 1);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(223, 100);
            this.pbState.TabIndex = 0;
            this.pbState.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.Location = new System.Drawing.Point(6, 133);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(218, 51);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // pblButtonGroup
            // 
            this.pblButtonGroup.Location = new System.Drawing.Point(1, 187);
            this.pblButtonGroup.Name = "pblButtonGroup";
            this.pblButtonGroup.Size = new System.Drawing.Size(223, 48);
            this.pblButtonGroup.TabIndex = 3;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 234);
            this.Controls.Add(this.pblButtonGroup);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbState);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pblButtonGroup;
    }
}