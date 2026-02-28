using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KLLA
{
    public class BaseForm : Form
    {
        //========== COLORS ===========
        protected readonly Color KoreaRed = ColorTranslator.FromHtml("#C60C30");
        protected readonly Color KoreaBlue = ColorTranslator.FromHtml("#003478");
        protected readonly Color AccentRed = ColorTranslator.FromHtml("#D64545");
        protected readonly Color AccentBlue = ColorTranslator.FromHtml("#4DA3FF");
        protected readonly Color DarkGray = ColorTranslator.FromHtml("#2B2B2B");
        protected readonly Color OffWhite = ColorTranslator.FromHtml("#F5F6FA");
        protected readonly Color white = Color.White;
        protected readonly Color black = Color.Black;

        // Window button placeholders
        protected Button btnClose;
        protected Button btnMin;
        protected Button btnMax;

        public BaseForm()
        {
            // =========== CUSTOM BORDER SETTINGS ===========
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = OffWhite;
        }

        // ============= DRAGGABLE HEADER LOGIC =============
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
        protected void EnableDraggableHeader(Panel header)
        {
            if (header != null)
                header.MouseDown += Header_MouseDown;
        }

        // ============= ASSIGN BUTTONS FOR AUTOMATIC WIRING FOR CHILDREN =============
        protected void WireWindowButtons(Button close, Button min, Button max)
        {
            btnClose = close;
            btnMin = min;
            btnMax = max;

            if (btnClose != null)
                btnClose.Click += (_, _) => this.Close();

            if (btnMin != null)
                btnMin.Click += (_, _) => this.WindowState = FormWindowState.Minimized;

            if (btnMax != null)
                btnMax.Click += (_, _) =>
                {
                    this.WindowState = this.WindowState == FormWindowState.Maximized
                        ? FormWindowState.Normal
                        : FormWindowState.Maximized;
                };
        }

        // ============= FROM GDI, CREATES ROUNDED RECTANGLE REGION IN MEMORY =============
        [DllImport("gdi32.dll")]
        protected static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        protected static extern bool DeleteObject(IntPtr hObject);

        // ============= APPLY ROUNDED REGION TO ANY CONTROL WITH DYNAMIC RESIZING SUPPORT =============
        protected void ApplyRoundedRegion(Control control, int radius)
        {
            void Update(object? _, EventArgs __)
            {
                if (control.Width <= 0 || control.Height <= 0)
                    return;

                IntPtr hrgn = CreateRoundRectRgn(
                    0, 0,
                    control.Width,
                    control.Height,
                    radius,
                    radius);

                control.Region?.Dispose();
                control.Region = Region.FromHrgn(hrgn);
                DeleteObject(hrgn);
            }

            control.SizeChanged += Update;
            Update(null, EventArgs.Empty);
        }
    }
}