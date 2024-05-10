namespace FindJobApplication
{
    partial class FPostSocial
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbSkill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rtxtStatus = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.skillDataSet = new FindJobApplication.SkillDataSet();
            this.skillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skillTableAdapter = new FindJobApplication.SkillDataSetTableAdapters.SkillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gunaLabel1.Location = new System.Drawing.Point(28, 446);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 21);
            this.gunaLabel1.TabIndex = 68;
            this.gunaLabel1.Text = "Hashtag:";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnCancel.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(380, 643);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 45);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPost
            // 
            this.btnPost.BorderRadius = 6;
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.OrangeRed;
            this.btnPost.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.HoverState.FillColor = System.Drawing.Color.Chocolate;
            this.btnPost.Location = new System.Drawing.Point(528, 643);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(126, 45);
            this.btnPost.TabIndex = 66;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(14, 28);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 34);
            this.gunaLabel2.TabIndex = 65;
            this.gunaLabel2.Text = "Social";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(8, 612);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator3.TabIndex = 64;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Location = new System.Drawing.Point(8, 89);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator4.TabIndex = 63;
            // 
            // pnlSkill
            // 
            this.pnlSkill.Location = new System.Drawing.Point(31, 547);
            this.pnlSkill.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(623, 48);
            this.pnlSkill.TabIndex = 62;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(241, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSkill
            // 
            this.cbSkill.BackColor = System.Drawing.Color.Transparent;
            this.cbSkill.BorderRadius = 10;
            this.cbSkill.DataSource = this.skillBindingSource;
            this.cbSkill.DisplayMember = "Name";
            this.cbSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSkill.DropDownHeight = 312;
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSkill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSkill.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbSkill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSkill.IntegralHeight = false;
            this.cbSkill.ItemHeight = 39;
            this.cbSkill.Location = new System.Drawing.Point(32, 482);
            this.cbSkill.Margin = new System.Windows.Forms.Padding(2);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(205, 45);
            this.cbSkill.TabIndex = 60;
            this.cbSkill.ValueMember = "Id";
            // 
            // rtxtStatus
            // 
            this.rtxtStatus.BackColor = System.Drawing.Color.White;
            this.rtxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStatus.Location = new System.Drawing.Point(31, 251);
            this.rtxtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtStatus.Name = "rtxtStatus";
            this.rtxtStatus.Size = new System.Drawing.Size(623, 154);
            this.rtxtStatus.TabIndex = 59;
            this.rtxtStatus.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.Location = new System.Drawing.Point(28, 202);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 21);
            this.lblStatus.TabIndex = 58;
            this.lblStatus.Text = "Status:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(28, 140);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 21);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 10;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(107, 130);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(547, 43);
            this.txtTitle.TabIndex = 56;
            // 
            // skillDataSet
            // 
            this.skillDataSet.DataSetName = "SkillDataSet";
            this.skillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skillBindingSource
            // 
            this.skillBindingSource.DataMember = "Skill";
            this.skillBindingSource.DataSource = this.skillDataSet;
            // 
            // skillTableAdapter
            // 
            this.skillTableAdapter.ClearBeforeFill = true;
            // 
            // FPostSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 717);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.pnlSkill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.rtxtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPostSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social";
            this.Load += new System.EventHandler(this.FPostSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnPost;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.FlowLayoutPanel pnlSkill;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbSkill;
        private System.Windows.Forms.RichTextBox rtxtStatus;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private SkillDataSet skillDataSet;
        private System.Windows.Forms.BindingSource skillBindingSource;
        private SkillDataSetTableAdapters.SkillTableAdapter skillTableAdapter;
    }
}