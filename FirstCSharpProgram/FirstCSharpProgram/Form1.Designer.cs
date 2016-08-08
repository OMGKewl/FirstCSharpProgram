namespace FirstCSharpProgram
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
            this.btn_console = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_console
            // 
            this.btn_console.Location = new System.Drawing.Point(197, 226);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(75, 23);
            this.btn_console.TabIndex = 0;
            this.btn_console.Text = "Console";
            this.btn_console.UseVisualStyleBackColor = true;
            this.btn_console.Click += new System.EventHandler(this.btn_console_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_console);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_console;
    }
}

