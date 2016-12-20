using System;
using System.Windows.Forms;
using System.Drawing;

// Author RevMinho

namespace player
{
    class FormUtil
    {
        private Form current;   //현재 폼 윈도우
        private Point prevLoc;  //폼의 이전 위치

        public FormUtil(Form form)
        {
            current = form;
            prevLoc = form.Location;
        }

        public void docking(Form target, int dockGap)
        {
            // 만약 소유한 폼들이 있고 도킹되어 있다면 함께 이동한다.
            foreach (Form temp in current.OwnedForms)
            {
                if (isDocked(temp))
                {
                    temp.SetDesktopLocation(
                        temp.Location.X + (current.Location.X - prevLoc.X),
                        temp.Location.Y + (current.Location.Y - prevLoc.Y));
                }
            }

            // 폼의 현재위치를 저장해둔다.
            prevLoc = current.Location;

            // 도킹 대상 폼윈도우의 오른쪽에 접근시
            if (checkRange(current.Left, target.Right, dockGap) && checkYLine(target))
            {
                current.Left = target.Right;
                current.Height = target.Height;
                current.SetDesktopLocation
                    (current.Location.X, target.Location.Y);
            }

            /*
            // 도킹 대상 폼윈도우의 왼쪽에 접근시
            if (checkRange(current.Right, target.Left, dockGap) && checkYLine(target))
            {
                current.Left = target.Left - current.Width;
            }

            // 도킹 대상 폼윈도우의 아래쪽에 접근시
            if (checkRange(current.Top, target.Bottom, dockGap) && checkXLine(target))
            {
                current.Top = target.Bottom;
            }

            // 도킹 대상 폼윈도우의 위쪽에 접근시
            if (checkRange(current.Bottom, target.Top, dockGap) && checkXLine(target))
            {
                current.Top = target.Top - current.Height;
            }
             */
        }

        // 대상 폼과 도킹되어 있는가
        private bool isDocked(Form target)
        {
            return (target.Left == prevLoc.X + current.Width ||
                    target.Right == prevLoc.X ||
                    target.Top == prevLoc.Y + current.Height ||
                    target.Bottom == prevLoc.Y);
        }

        // 대상 폼 윈도우 테두리의 범위안으로 이동했는가
        private bool checkRange(int curVal, int tarVal, int range)
        {
            return (curVal > tarVal - range) && (curVal < tarVal + range);
        }

        // 대상 폼 윈도우와 수평선상에 있는가
        private bool checkXLine(Form target)
        {
            return (current.Left < target.Right) && (current.Right > target.Left);
        }

        // 대상 폼 윈도우와 수직선상에 있는가
        private bool checkYLine(Form target)
        {
            return (current.Top < target.Bottom) && (current.Bottom > target.Top);
        }
    }
}
