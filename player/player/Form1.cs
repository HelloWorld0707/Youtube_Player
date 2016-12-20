using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace player
{
    public partial class Form1 : Form
    {
        private Form2 child = null;
        private FormUtil formutil = null;
        private bool Silent = false;
        public Form1()
        {
            InitializeComponent();
            child = new Form2(dataGridView1, this, Silent);
            
            // 컨트롤을 맨 위에 //
            this.TopMost = true;

            // 웹 브라우저 설정 //
            webBrowser1.Visible = false;
            webBrowser1.Navigate("about:blank");

            // 여기서 부터 리스트 설정 //
            dataGridView1.Visible = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "title";
            dataGridView1.Columns[1].Name = "url";

            // 텍스트 박스, 버튼 위치 설정 //
            textBox1.SetBounds(textBox1.Location.X, textBox1.Location.Y,
                                panel4.Size.Width - 87, textBox1.Height);
            btn_add.SetBounds(panel4.Size.Width - 77, btn_add.Location.Y,
                                    btn_add.Width, btn_add.Height);

            btn_hide_Click(null, null);
        }

        // 핫키 등륵 //
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);
       
        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.CapsLock);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //이 폼에 ID가 0인 핫키 해제
            UnregisterHotKey((int)this.Handle, 0);
        }

        //윈도우프로시저 콜백함수
        protected override void WndProc(ref Message m) 
        {
            base.WndProc(ref m);

            if (m.Msg == (int)0x312) //핫키가 눌러지면 312 정수 메세지를 받게됨
            {
                if (m.WParam == (IntPtr)0x0) // 그 키의 ID가 0이면
                {
                    this.Visible ^= true;
                    panel4.Visible = false;
                    if (child.Created) child.Close();

                    // btn_hide_Click(null, null);

                    if (!this.Visible && Silent) Set_Volume(0);
                    else Set_Volume(1000000);
                }
            }
        }
        // 핫키 끝.

        // 볼륨 조절
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private void Set_Volume(uint vol)
        {
             waveOutSetVolume(IntPtr.Zero, vol);
        }

        public void Set_Silent(bool check)
        {
            Silent = check;
        }
        // 볼륨 조절 끝.

        // 숨김 버튼.
        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (!child.Created)
            {
                child = new Form2(dataGridView1, this, Silent);

                // 폼 같이 움직이기 //
                this.AddOwnedForm(child);
                formutil = new FormUtil(this);

                child.Show();
                panel4.Visible = true;
            }
            else
            {
                child.Close();
                panel4.Visible = false;
            }
        }

        // 음악 재생
        public void play(string url2)
        {
            string url = url2;

            webBrowser1.Visible = true;
            webBrowser1.Dock = DockStyle.Fill;

            btn_hide_Click(null, null);

            webBrowser1.Document.Write(url);
            webBrowser1.Refresh();
        }

        // 추가 버튼
        private void btn_add_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (url == "" || !url.Contains("www.youtube.com/watch?")) return;

            // if (child.Created) child.add_music(url);
            webBrowser1.Navigate(url);
            textBox1.Text = "";
        }

        // 버튼 설정 끝.
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // if (webBrowser1.IsBusy == false)
            {
                // 동영상 제목
                string title = webBrowser1.DocumentTitle;
                // 뒤쪽에 - Toutube 잘라냄.
                title = title.Substring(0, title.Length - 10);

                // 동영상 ID
                string s = webBrowser1.Url.ToString();
                // 자름
                string[] ID = s.Split('=');
                ID[1] = ID[1].Substring(0, 11);

                if (title != "" && ID[1] != "")
                {
                    // int x = s.Length;
                    // s = s.Substring(x-11, x);
                    // MessageBox.Show(s);
                    child.add_list(title, ID[1]);
                    // dataGridView1.Rows.Add(title, ID[1]);
                    // 초기화
                    webBrowser1.Navigate("about:blank");
                }
                else MessageBox.Show("적합하지 못한 주소입니다.", "회피만렙");
            }
        }

        //  폼설정
        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            textBox1.SetBounds(textBox1.Location.X, textBox1.Location.Y,
                                panel4.Size.Width - 87, textBox1.Height);
            btn_add.SetBounds(panel4.Size.Width - 77, btn_add.Location.Y,
                                    btn_add.Width, btn_add.Height);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (child.Created) formutil.docking(child, 10);
        }
        // 폼설정 끝
    }
}
