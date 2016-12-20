using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace player
{
    public partial class Form2 : Form
    {
        private Form3 child = null;
        private FormUtil formUtil = null;
        private Form1 parent;
        private DataGridView Parent_GirdView;

        private System.Timers.Timer timer1 = new System.Timers.Timer();

        public Form2(DataGridView Parent_GirdView, Form1 parent, bool Silent)
        {
            InitializeComponent();

            formUtil = new FormUtil(this);
            this.parent = parent;

            this.Width = 347;

            webBrowser1.Visible = false;

            // 컨트롤을 맨 위에 //
            this.TopMost = true;

            // 여기서 부터 리스트 설정 //
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "title";
            dataGridView1.Columns[0].Width = panel1.Width - 5;//(int)(dataGridView1.Width * 2);

            dataGridView1.Columns[1].Name = "url";
            dataGridView1.Columns[1].Visible = false;

            this.Parent_GirdView = Parent_GirdView;

            // 부모의 리스트 자료를 옮김.
            for (int i = 0; i < Parent_GirdView.Rows.Count; i++)
            {
                string temp1 = Parent_GirdView.Rows[i].Cells[0].Value.ToString();
                string temp2 = Parent_GirdView.Rows[i].Cells[1].Value.ToString();
                
                dataGridView1.Rows.Add(temp1, temp2);
            }
            
            // 체크박스 설정
            if (Silent) checkBox1.Checked = true;

            // 폼 초기화
            child = new Form3();

            // 다운로드시 이용하는 타이머
            timer1.Interval = 3 * 1000; // 3초
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
        }

        private void Form2_Move_1(object sender, EventArgs e)
        {
            formUtil.docking(this.Owner, 10);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            Top = this.Owner.Top;
            Left = this.Owner.Right;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("재생 목록이 없습니다.", "회피만렙");
                return;
            }
            parent.play(get_url());
            this.Close();
        }

        // 재생 함수
        public string get_url()
        {
            string url = "";
            string head = "<html><head><meta charset='UTF-8'>" + 
                "</head><body style='margin:0px;padding:0px;'>" +
                "<div style='margin:0px;padding:0px;'><embed src='http://www.youtube.com/v/";
            string play = "";
            string middle = "?rel=0&showinfo=1&version=3&amp;hl=ko_KR&amp;vq=hd720&autoplay=1&";
            string list = "playlist=";
            string tail = "type='application/x-shockwave-flash' width='100%' height='100%' ='always' allowfullscreen='true'>" +
                "</embed></div></body></html>";


            // 컬랙션이 하나.
            if (dataGridView1.Rows.Count == 1)
            {
                play = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                url = head + play + middle + tail;
            }
            //컬랙션이 둘.
            else
            {
                play = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                    list += dataGridView1.Rows[i].Cells[1].Value.ToString() + ",";

                //list = list.Substring(0, list.Length - 1);
                url = head + play + middle + list + tail;

                //MessageBox.Show(url);
            }
            return url;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // 내용ㄴ? 저장 ㄴ
            if (dataGridView1.Rows.Count == 0) return;

            SaveFileDialog Save = new SaveFileDialog();
            Save.DefaultExt = "att";
            Save.Filter = "(*.att)|*.att";
            Save.InitialDirectory = System.Environment.CurrentDirectory;

            string text = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                    text += dataGridView1.Rows[i].Cells[j].Value.ToString() + '\t';

                text += "\r\n";
            }

            if (Save.ShowDialog() == DialogResult.OK)
            {
                byte[] data = Encoding.Default.GetBytes(text);

                System.IO.FileStream file = new System.IO.FileStream(Save.FileName,
                                                                        System.IO.FileMode.Create,
                                                                        System.IO.FileAccess.ReadWrite);

                file.Write(data, 0, data.Length);
                file.Close();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            // 자식 리스트 초기화
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            }

            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "(*.att)|*.att";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream file = new System.IO.FileStream(Open.FileName,
                                                                        System.IO.FileMode.Open,
                                                                        System.IO.FileAccess.Read);

                System.IO.FileInfo info = new System.IO.FileInfo(Open.FileName);
                int file_byte = Convert.ToInt32(info.Length);
                byte[] data = new byte[file_byte];

                file.Read(data, 0, file_byte);
                string text = Encoding.Default.GetString(data, 0, data.Length);
                file.Close();

                //MessageBox.Show(text);
                string[] text_arr = text.Split('\t');

                for (int i = 0; i < text_arr.Length - 1; i += 2)
                    dataGridView1.Rows.Add(text_arr[i], text_arr[i + 1]);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int x = 0; x < dataGridView1.SelectedRows.Count; x++)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[x]);
                }
            }
        }

        // 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // e.Clicks : 클릭이 되었는가.
            // e.Button : 어디로 클릭 했는가.
            // e.RowIndex : 몇번째 줄을 클릭 했는가.
            if (e.Button.ToString() == "Right")
            {
                int num = e.RowIndex;
                dataGridView1.Rows[num].Selected = true;
                //MessageBox.Show(num.ToString());

                ContextMenu m = new ContextMenu();

                MenuItem m1 = new MenuItem();
                m1.Text = "재생";
                m.MenuItems.Add(m1);
                m1.Click += (senders, e2) =>
                {
                    btn_play_Click(null, null);
                };

                MenuItem m2 = new MenuItem();
                m2.Text = "삭제";
                m.MenuItems.Add(m2);
                m2.Click += (senders, e2) =>
                {
                    btn_delete_Click(null, null);
                };

                MenuItem m3 = new MenuItem();
                m3.Text = "주소복사";
                m.MenuItems.Add(m3);
                m3.Click += (senders, e2) =>
                {
                    Clipboard.SetText(@"https://www.youtube.com/watch?v=" + dataGridView1.Rows[num].Cells[1].Value.ToString());
                    MessageBox.Show("복사완료! \n원하는 곳에 Ctrl+v", "회피만렙");
                };

                MenuItem m4 = new MenuItem();
                m4.Text = "내려받기";
                m.MenuItems.Add(m4);
                m4.Click += (senders, e2) =>
                {
                    timer1.Start();

                    string head = "http://en.savefrom.net/#url=http://youtube.com/watch?v=";
                    string video_id = dataGridView1.Rows[num].Cells[1].Value.ToString();
                    string tail = "&utm_source=youtube.com&utm_medium=short_domains&utm_campaign=www.ssyoutube.com";

                    download(head + video_id + tail);
                    // String url = @"https://www.ssyoutube.com/watch?v=" + dataGridView1.Rows[num].Cells[1].Value.ToString();
                    // System.Diagnostics.Process.Start("IExplore.exe", url);
                };

                MenuItem m5 = new MenuItem();
                m5.Text = "이름수정";
                m.MenuItems.Add(m5);
                m5.Click += (senders, e2) =>
                {
                    if (!child.Created)
                    {
                        child = new Form3(this, num, dataGridView1.Rows[num].Cells[0].Value.ToString());
                        child.Show();
                    }
                };

                // 보여주는 위치 설정
                m.Show(dataGridView1, new Point(e.X, e.Y + num * dataGridView1.Rows[0].Height));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (child.Created) child.Close();

            // 부모 리스트 초기화
            for(int i = Parent_GirdView.Rows.Count-1; i>=0; i--)
            {
                Parent_GirdView.Rows.Remove(Parent_GirdView.Rows[i]);
            }

            // 자식의 리스트 자료를 부모로 옮김.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string temp1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string temp2 = dataGridView1.Rows[i].Cells[1].Value.ToString();

                Parent_GirdView.Rows.Add(temp1, temp2);
            }

        }

        // 음소거
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) parent.Set_Silent(true);
            else parent.Set_Silent(false);
        }

        // 더블클릭
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_play_Click(null, null);
        }

        // 크기보정
        private void Form2_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Width = 165;
        }


        public void add_list(string title, string ID)
        {
            dataGridView1.Rows.Add(title, ID);
        }

        // 드래그 & 드랍
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] url = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(
                url[0]
                );
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        // 이름 변경
        public void set_Songs_name(int index, string name)
        {
            dataGridView1.Rows[index].Cells[0].Value = name;
        }

        // 다운로드
        string i = null;
        private void download(string id)
        {
            if (id != null) i = id;

            webBrowser1.Navigate(i);
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri == webBrowser1.Url.AbsoluteUri)
            {
                get_href();
            }
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            download(null);
        }

        private void get_href()
        {
            // MessageBox.Show("찾으러");
            string html_text = null;
            var doc = webBrowser1.Document;
            // var els = doc.DomDocument as MSHTML.HTMLDocument;

            // foreach (MSHTML.IHTMLElement el in els.getElementsByTagName("div"))
            foreach (HtmlElement el in doc.GetElementsByTagName("div"))
            {
                try
                {
                    if (el.GetAttribute("className").ToString() == null) continue;
                    if (el.GetAttribute("className").ToString().Trim() == "def-btn-box")
                    {
                        html_text = el.InnerHtml.Replace("amp;", "");
                    }
                }
                catch { }
            }

            if (html_text != null)
            {
                open_href(html_text);
            }
            else
            {
                timer1.Interval += 2000; // 인터벌 2초 증가.
            }
        }

        private void open_href(string html_text)
        {
            timer1.Stop();
            // MessageBox.Show("찾음");
            string[] href = html_text.Split('"');

            foreach (string i in href)
            {
                if (i.Contains("http"))
                    System.Diagnostics.Process.Start("IExplore.exe", i);
                // 새창을 연다.
            }
        }
    }
}
