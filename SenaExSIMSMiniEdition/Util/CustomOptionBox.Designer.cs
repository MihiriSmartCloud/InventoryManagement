namespace SenaExSIMSMiniEdition.Util
{

    internal partial class CustomOptionBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomOptionBox));
            this.btnOp2 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOp2
            // 
            this.btnOp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOp2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnOp2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnOp2.FlatAppearance.BorderSize = 2;
            this.btnOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOp2.ForeColor = System.Drawing.Color.Transparent;
            this.btnOp2.Location = new System.Drawing.Point(95, 71);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(229, 28);
            this.btnOp2.TabIndex = 2;
            this.btnOp2.Text = "Print Op. 2";
            this.btnOp2.UseVisualStyleBackColor = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(92, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(268, 18);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "You can choose following options.";
            // 
            // btnOp1
            // 
            this.btnOp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOp1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOp1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnOp1.FlatAppearance.BorderSize = 2;
            this.btnOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnOp1.ForeColor = System.Drawing.Color.Transparent;
            this.btnOp1.Location = new System.Drawing.Point(95, 37);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(229, 28);
            this.btnOp1.TabIndex = 1;
            this.btnOp1.Text = "Print Op. 1";
            this.btnOp1.UseVisualStyleBackColor = false;
            // 
            // imgIcon
            // 
            this.imgIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.Image = global::SenaExSIMSMiniEdition.Properties.Resources.PrintBig;
            this.imgIcon.Location = new System.Drawing.Point(12, 12);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(73, 87);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 5;
            this.imgIcon.TabStop = false;
            // 
            // CustomOptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 111);
            this.Controls.Add(this.btnOp1);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.imgIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomOptionBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing Options";
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.Button btnOp1;
    }
}