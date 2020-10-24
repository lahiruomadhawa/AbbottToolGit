namespace AbbottTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.SoursePath_textBox = new System.Windows.Forms.TextBox();
            this.SourcePathBrowse_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path";
            // 
            // SoursePath_textBox
            // 
            this.SoursePath_textBox.Location = new System.Drawing.Point(95, 22);
            this.SoursePath_textBox.Name = "SoursePath_textBox";
            this.SoursePath_textBox.Size = new System.Drawing.Size(567, 20);
            this.SoursePath_textBox.TabIndex = 1;
            // 
            // SourcePathBrowse_btn
            // 
            this.SourcePathBrowse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourcePathBrowse_btn.Location = new System.Drawing.Point(668, 20);
            this.SourcePathBrowse_btn.Name = "SourcePathBrowse_btn";
            this.SourcePathBrowse_btn.Size = new System.Drawing.Size(61, 23);
            this.SourcePathBrowse_btn.TabIndex = 2;
            this.SourcePathBrowse_btn.Text = "Browse";
            this.SourcePathBrowse_btn.UseVisualStyleBackColor = true;
            this.SourcePathBrowse_btn.Click += new System.EventHandler(this.SourcePathBrowse_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(567, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SourcePathBrowse_btn);
            this.Controls.Add(this.SoursePath_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abbott files separator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoursePath_textBox;
        private System.Windows.Forms.Button SourcePathBrowse_btn;
        private System.Windows.Forms.Button button1;
    }
}

