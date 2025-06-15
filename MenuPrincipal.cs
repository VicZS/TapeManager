using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Vml.Office;



namespace TapeManager
{
    public partial class MenuPrincipal : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public MenuPrincipal()
        {
            InitializeComponent();
            AbrirInterfaz(new InterfazInicio());
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

        private void ArrastrarVentana(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int borderRadius = 30;
            var path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }


        private void ActivateButton(object sender)
        {
            if (sender is IconButton button)
            {
                DisableAllsButtons();
                button.BackColor = Color.FromArgb(11, 31, 56);
                button.ForeColor = Color.FromArgb(60, 145, 251);
                button.IconColor = Color.FromArgb(60, 145, 251);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.ImageAlign = ContentAlignment.MiddleRight;
                button.TextImageRelation = TextImageRelation.TextBeforeImage;
            }

        }

        private void DisableAllsButtons()
        {
            IconButton[] buttons = { MenuCintasUso, MenuCintasBoveda, MenuContenedores, MenuGenerarReportes, MenuResguardarCintas, MenuEnviarContenedor, MenuImprimirBarcode, MenuEditarInventario, MenuCompararInventario };

            string col = string.Empty;

            foreach (var button in buttons)
            {
                if (button == MenuCintasUso)
                {
                    col = "GhostWhite";
                }

                if (button == MenuCintasBoveda)
                {
                    col = "LightBlue";
                }

                if (button == MenuContenedores)
                {
                    col = "Gray";
                }

                if (button == MenuGenerarReportes)
                {
                    col = "Green";
                }

                if (button == MenuResguardarCintas)
                {
                    col = "Gainsboro";
                }

                if (button == MenuEnviarContenedor)
                {
                    col = "Orange";
                }

                if (button == MenuImprimirBarcode)
                {
                    col = "DimGray";
                }

                if (button == MenuEditarInventario)
                {
                    col = "PaleTurquoise";
                }

                if (button == MenuCompararInventario)
                {
                    col = "Pink";
                }

                button.BackColor = Color.FromArgb(24, 57, 99);
                button.ForeColor = Color.FromArgb(240, 240, 240);
                button.IconColor = Color.FromName(col);
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

        }

        private void MenuCintasUso_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazCintasEnUso());
        }

        private void MenuCintasBoveda_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazCintasEnBoveda());
        }

        private void MenuContenedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazContenedoresEnviados());
        }

        private void MenuGenerarReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazGenerarReporte());
        }

        private void MenuResguardarCintas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazResguardarCintas());
        }

        private void MenuEnviarContenedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazEnviarContenedor());
        }

        private void MenuImprimirBarcode_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazImprimirBarcode());
        }

        private void MenuEditarInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazEditarInventario());
        }

        private void MenuCompararInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirInterfaz(new InterfazCompararInventario());
        }

        private void PBLogoForvia_Click(object sender, EventArgs e) {
            DisableAllsButtons();
            AbrirInterfaz(new InterfazInicio());
        }

        public void AbrirInterfaz(object formh)
        {
            if (this.PanelInterfaces.Controls.Count > 0)
            {
                this.PanelInterfaces.Controls.RemoveAt(0);
            }
            
            Form fh = formh as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.PanelInterfaces.Controls.Add(fh);
            this.PanelInterfaces.Tag = fh;
            fh.Show();
        }

    }
}
