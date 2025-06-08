using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;


namespace TapeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBCerrar_MouseEnter(object sender, EventArgs e)
        {
            PBCerrar.Image = Properties.Resources.boton_cerrar___rojo;
        }

        private void PBCerrar_MouseLeave(object sender, EventArgs e)
        {
            PBCerrar.Image = Properties.Resources.boton_cerrar;
        }


        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBMinimizar_MouseEnter(object sender, EventArgs e)
        {
            PBMinimizar.Image = Properties.Resources.minimizar_Azul;
        }

        private void PBMinimizar_MouseLeave(object sender, EventArgs e)
        {
            PBMinimizar.Image = Properties.Resources.minimizar;
        }

        // Estas funciones permiten mover la ventana
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes necesarias
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        private void ArrastrarVentana(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }






    }
}
