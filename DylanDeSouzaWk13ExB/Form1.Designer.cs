namespace DylanDeSouzaWk13ExB
{
    partial class Form1
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblAnswerAverageHeight = new System.Windows.Forms.Label();
            this.lblAverageHeight = new System.Windows.Forms.Label();
            this.lstHeightGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(320, 127);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 13;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAnswerAverageHeight
            // 
            this.lblAnswerAverageHeight.AutoSize = true;
            this.lblAnswerAverageHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswerAverageHeight.Location = new System.Drawing.Point(233, 132);
            this.lblAnswerAverageHeight.Name = "lblAnswerAverageHeight";
            this.lblAnswerAverageHeight.Size = new System.Drawing.Size(2, 15);
            this.lblAnswerAverageHeight.TabIndex = 12;
            // 
            // lblAverageHeight
            // 
            this.lblAverageHeight.AutoSize = true;
            this.lblAverageHeight.Location = new System.Drawing.Point(146, 132);
            this.lblAverageHeight.Name = "lblAverageHeight";
            this.lblAverageHeight.Size = new System.Drawing.Size(81, 13);
            this.lblAverageHeight.TabIndex = 11;
            this.lblAverageHeight.Text = "Average Height";
            // 
            // lstHeightGroups
            // 
            this.lstHeightGroups.FormattingEnabled = true;
            this.lstHeightGroups.Location = new System.Drawing.Point(127, 180);
            this.lstHeightGroups.Name = "lstHeightGroups";
            this.lstHeightGroups.Size = new System.Drawing.Size(543, 95);
            this.lstHeightGroups.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblAnswerAverageHeight);
            this.Controls.Add(this.lblAverageHeight);
            this.Controls.Add(this.lstHeightGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblAnswerAverageHeight;
        private System.Windows.Forms.Label lblAverageHeight;
        private System.Windows.Forms.ListBox lstHeightGroups;
    }
}