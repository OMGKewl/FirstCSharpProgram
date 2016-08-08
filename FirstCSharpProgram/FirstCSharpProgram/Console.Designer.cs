namespace FirstCSharpProgram
{
    partial class Console
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
            this.btn_console_save = new System.Windows.Forms.Button();
            this.btn_console_cancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_console_save
            // 
            this.btn_console_save.Location = new System.Drawing.Point(674, 12);
            this.btn_console_save.Name = "btn_console_save";
            this.btn_console_save.Size = new System.Drawing.Size(75, 23);
            this.btn_console_save.TabIndex = 0;
            this.btn_console_save.Text = "Save";
            this.btn_console_save.UseVisualStyleBackColor = true;
            this.btn_console_save.Click += new System.EventHandler(this.btn_console_save_Click);
            // 
            // btn_console_cancel
            // 
            this.btn_console_cancel.Location = new System.Drawing.Point(674, 41);
            this.btn_console_cancel.Name = "btn_console_cancel";
            this.btn_console_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_console_cancel.TabIndex = 1;
            this.btn_console_cancel.Text = "Cancel";
            this.btn_console_cancel.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(656, 363);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 387);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_console_cancel);
            this.Controls.Add(this.btn_console_save);
            this.Name = "Console";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_console_save;
        private System.Windows.Forms.Button btn_console_cancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}