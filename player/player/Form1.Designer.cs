namespace player
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_hide = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 31);
            this.panel4.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.ForeColor = System.Drawing.Color.Maroon;
            this.btn_add.Location = new System.Drawing.Point(343, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 21);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 21);
            this.textBox1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 139);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(204, 161);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_hide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hide.Location = new System.Drawing.Point(569, 0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(15, 312);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = ">";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(417, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(146, 238);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::player.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "회피만랩";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

