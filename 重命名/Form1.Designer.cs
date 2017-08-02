namespace 重命名
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
            this.Path_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.suffix_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuffix_after = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Path_text
            // 
            this.Path_text.Location = new System.Drawing.Point(54, 58);
            this.Path_text.Name = "Path_text";
            this.Path_text.Size = new System.Drawing.Size(218, 21);
            this.Path_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suffix_text
            // 
            this.suffix_text.Location = new System.Drawing.Point(56, 83);
            this.suffix_text.Name = "suffix_text";
            this.suffix_text.Size = new System.Drawing.Size(100, 21);
            this.suffix_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suffix";
            // 
            // stuffix_after
            // 
            this.stuffix_after.Location = new System.Drawing.Point(172, 83);
            this.stuffix_after.Name = "stuffix_after";
            this.stuffix_after.Size = new System.Drawing.Size(100, 21);
            this.stuffix_after.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stuffix_after);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suffix_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_text);
            this.Name = "Form1";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox suffix_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuffix_after;
    }
}

