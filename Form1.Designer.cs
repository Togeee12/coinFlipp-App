namespace CoinToss_App
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
            this.btnFlip = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblTails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlip
            // 
            this.btnFlip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFlip.Location = new System.Drawing.Point(88, 197);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(145, 49);
            this.btnFlip.TabIndex = 0;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(88, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(145, 37);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Tail";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(-1, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(245, 151);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // lblHeads
            // 
            this.lblHeads.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeads.Location = new System.Drawing.Point(-1, 160);
            this.lblHeads.Name = "lblHeads";
            this.lblHeads.Size = new System.Drawing.Size(65, 37);
            this.lblHeads.TabIndex = 3;
            this.lblHeads.Text = "Heads:";
            this.lblHeads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTails
            // 
            this.lblTails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTails.Location = new System.Drawing.Point(-1, 197);
            this.lblTails.Name = "lblTails";
            this.lblTails.Size = new System.Drawing.Size(65, 35);
            this.lblTails.TabIndex = 4;
            this.lblTails.Text = "Tails:";
            this.lblTails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 258);
            this.Controls.Add(this.lblTails);
            this.Controls.Add(this.lblHeads);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnFlip);
            this.Name = "Form1";
            this.Text = "coinFlip App";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFlip;
        private Label lblResult;
        private PictureBox picBox;
        private Label lblHeads;
        private Label lblTails;
    }
}