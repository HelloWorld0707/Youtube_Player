namespace player
{
    partial class Form3
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
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.ForeColor = System.Drawing.Color.Maroon;
            this.btn_add.Location = new System.Drawing.Point(350, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 21);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "수정";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 21);
            this.textBox1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 44);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBox1;
    }
}