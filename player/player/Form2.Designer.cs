namespace player
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(102, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 308);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 54);
            this.panel2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "감춤 시 음소거";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_save.Location = new System.Drawing.Point(2, 26);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 28);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "저장하기";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_load.ForeColor = System.Drawing.Color.Maroon;
            this.btn_load.Location = new System.Drawing.Point(78, 26);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(72, 28);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "불러오기";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_play.ForeColor = System.Drawing.Color.Maroon;
            this.btn_play.Location = new System.Drawing.Point(2, 1);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(72, 28);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "재생";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.ForeColor = System.Drawing.Color.Maroon;
            this.btn_delete.Location = new System.Drawing.Point(78, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 28);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(233, 221);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(102, 308);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 308);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "회피만랩";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ClientSizeChanged += new System.EventHandler(this.Form2_ClientSizeChanged);
            this.Move += new System.EventHandler(this.Form2_Move_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;

    }
}