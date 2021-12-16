
namespace LoginForm
{
    partial class TipOfDay
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
            this.tipOfDay1 = new System.Windows.Forms.Label();
            this.nextTip = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tipOfDay1
            // 
            this.tipOfDay1.AutoSize = true;
            this.tipOfDay1.Font = new System.Drawing.Font("Segoe UI Emoji", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipOfDay1.Location = new System.Drawing.Point(14, 11);
            this.tipOfDay1.Name = "tipOfDay1";
            this.tipOfDay1.Size = new System.Drawing.Size(0, 12);
            this.tipOfDay1.TabIndex = 0;
            // 
            // nextTip
            // 
            this.nextTip.Location = new System.Drawing.Point(79, 229);
            this.nextTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextTip.Name = "nextTip";
            this.nextTip.Size = new System.Drawing.Size(94, 29);
            this.nextTip.TabIndex = 1;
            this.nextTip.Text = "Next Tip";
            this.nextTip.UseVisualStyleBackColor = true;
            this.nextTip.Click += new System.EventHandler(this.nextTip_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextTip);
            this.Controls.Add(this.tipOfDay1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipOfDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipOfDay";
            this.Load += new System.EventHandler(this.TipOfDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipOfDay1;
        private System.Windows.Forms.Button nextTip;
        private System.Windows.Forms.Button button1;
    }
}