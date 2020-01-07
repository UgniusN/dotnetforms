namespace formApp1
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
            this.mgtk = new System.Windows.Forms.Button();
            this.tekstoDezute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mgtk
            // 
            this.mgtk.Location = new System.Drawing.Point(96, 128);
            this.mgtk.Name = "mgtk";
            this.mgtk.Size = new System.Drawing.Size(102, 31);
            this.mgtk.TabIndex = 0;
            this.mgtk.Text = "Paspausk mane";
            this.mgtk.UseVisualStyleBackColor = true;
            this.mgtk.Click += new System.EventHandler(this.mgtk_Click);
            // 
            // tekstoDezute
            // 
            this.tekstoDezute.Location = new System.Drawing.Point(71, 165);
            this.tekstoDezute.Multiline = true;
            this.tekstoDezute.Name = "tekstoDezute";
            this.tekstoDezute.Size = new System.Drawing.Size(156, 178);
            this.tekstoDezute.TabIndex = 1;
            this.tekstoDezute.TextChanged += new System.EventHandler(this.tekstoDezute_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.tekstoDezute);
            this.Controls.Add(this.mgtk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mgtk;
        private System.Windows.Forms.TextBox tekstoDezute;
    }
}

