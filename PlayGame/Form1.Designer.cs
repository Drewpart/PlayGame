namespace PlayGame
{
    partial class PlayGame
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.strtButton = new System.Windows.Forms.Button();
            this.backGround = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(22, 130);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(217, 26);
            this.outputLabel.TabIndex = 0;
            // 
            // strtButton
            // 
            this.strtButton.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtButton.ForeColor = System.Drawing.Color.White;
            this.strtButton.Location = new System.Drawing.Point(95, 27);
            this.strtButton.Name = "strtButton";
            this.strtButton.Size = new System.Drawing.Size(89, 56);
            this.strtButton.TabIndex = 1;
            this.strtButton.Text = "START";
            this.strtButton.UseVisualStyleBackColor = true;
            this.strtButton.Click += new System.EventHandler(this.strtButton_Click);
            // 
            // backGround
            // 
            this.backGround.BackColor = System.Drawing.Color.Transparent;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(309, 298);
            this.backGround.TabIndex = 2;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 227);
            this.Controls.Add(this.strtButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.backGround);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "PlayGame";
            this.Text = "Play Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button strtButton;
        private System.Windows.Forms.Label backGround;
    }
}

