namespace TapeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelSuperior = new Panel();
            PanelNombreApp = new Panel();
            label1 = new Label();
            PanelControles = new Panel();
            pictureBox3 = new PictureBox();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            PanelLogoForvia = new Panel();
            PBLogoForvia = new PictureBox();
            PanelMenu = new Panel();
            panel2 = new Panel();
            btnAbrirInterfazEnviarContenedores = new Button();
            btnAbrirInterfazReguardarCintas = new Button();
            panel3 = new Panel();
            btnAbrirInterfazImprimirEtiquetas = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            PanelMenuRegistros = new Panel();
            btnAbrirInterfazGenerarReporte = new Button();
            btnAbrirInterfazContenedores = new Button();
            btnAbrirInterfazCintasBoveda = new Button();
            btnMenuCintasActivas = new Panel();
            btnAbrirInterfazCintasActivas = new Button();
            PanelTituloMenuRegistros = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            PanelInterfaces = new Panel();
            PanelSuperior.SuspendLayout();
            PanelNombreApp.SuspendLayout();
            PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            PanelLogoForvia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).BeginInit();
            PanelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelMenuRegistros.SuspendLayout();
            btnMenuCintasActivas.SuspendLayout();
            PanelTituloMenuRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(17, 47, 84);
            PanelSuperior.Controls.Add(PanelNombreApp);
            PanelSuperior.Controls.Add(PanelControles);
            PanelSuperior.Controls.Add(PanelLogoForvia);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Padding = new Padding(10, 10, 10, 15);
            PanelSuperior.Size = new Size(1280, 75);
            PanelSuperior.TabIndex = 0;
            PanelSuperior.MouseDown += ArrastrarVentana;
            // 
            // PanelNombreApp
            // 
            PanelNombreApp.Controls.Add(label1);
            PanelNombreApp.Dock = DockStyle.Left;
            PanelNombreApp.Location = new Point(199, 10);
            PanelNombreApp.Name = "PanelNombreApp";
            PanelNombreApp.Padding = new Padding(1);
            PanelNombreApp.Size = new Size(727, 50);
            PanelNombreApp.TabIndex = 2;
            PanelNombreApp.MouseDown += ArrastrarVentana;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 1);
            label1.Name = "label1";
            label1.Size = new Size(440, 51);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Cintas";
            label1.MouseDown += ArrastrarVentana;
            // 
            // PanelControles
            // 
            PanelControles.Controls.Add(pictureBox3);
            PanelControles.Controls.Add(PBMinimizar);
            PanelControles.Controls.Add(PBCerrar);
            PanelControles.Dock = DockStyle.Right;
            PanelControles.Location = new Point(1110, 10);
            PanelControles.Name = "PanelControles";
            PanelControles.Size = new Size(160, 50);
            PanelControles.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.ajuste;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Cursor = Cursors.Hand;
            PBMinimizar.Dock = DockStyle.Right;
            PBMinimizar.Image = Properties.Resources.minimizar;
            PBMinimizar.Location = new Point(60, 0);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(50, 50);
            PBMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PBMinimizar.TabIndex = 1;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click;
            PBMinimizar.MouseEnter += PBMinimizar_MouseEnter;
            PBMinimizar.MouseLeave += PBMinimizar_MouseLeave;
            // 
            // PBCerrar
            // 
            PBCerrar.Cursor = Cursors.Hand;
            PBCerrar.Dock = DockStyle.Right;
            PBCerrar.Image = Properties.Resources.boton_cerrar;
            PBCerrar.Location = new Point(110, 0);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(50, 50);
            PBCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCerrar.TabIndex = 0;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click;
            PBCerrar.MouseEnter += PBCerrar_MouseEnter;
            PBCerrar.MouseLeave += PBCerrar_MouseLeave;
            // 
            // PanelLogoForvia
            // 
            PanelLogoForvia.Controls.Add(PBLogoForvia);
            PanelLogoForvia.Dock = DockStyle.Left;
            PanelLogoForvia.Location = new Point(10, 10);
            PanelLogoForvia.Name = "PanelLogoForvia";
            PanelLogoForvia.Padding = new Padding(0, 14, 0, 0);
            PanelLogoForvia.Size = new Size(189, 50);
            PanelLogoForvia.TabIndex = 0;
            PanelLogoForvia.MouseDown += ArrastrarVentana;
            // 
            // PBLogoForvia
            // 
            PBLogoForvia.Dock = DockStyle.Fill;
            PBLogoForvia.Image = Properties.Resources.Logo_forvia;
            PBLogoForvia.Location = new Point(0, 14);
            PBLogoForvia.Name = "PBLogoForvia";
            PBLogoForvia.Size = new Size(189, 36);
            PBLogoForvia.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLogoForvia.TabIndex = 0;
            PBLogoForvia.TabStop = false;
            PBLogoForvia.MouseDown += ArrastrarVentana;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(24, 57, 99);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(panel1);
            PanelMenu.Controls.Add(PanelMenuRegistros);
            PanelMenu.Controls.Add(PanelTituloMenuRegistros);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 75);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(281, 645);
            PanelMenu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAbrirInterfazEnviarContenedores);
            panel2.Controls.Add(btnAbrirInterfazReguardarCintas);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 389);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30, 0, 8, 8);
            panel2.Size = new Size(281, 256);
            panel2.TabIndex = 3;
            // 
            // btnAbrirInterfazEnviarContenedores
            // 
            btnAbrirInterfazEnviarContenedores.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazEnviarContenedores.Dock = DockStyle.Top;
            btnAbrirInterfazEnviarContenedores.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazEnviarContenedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazEnviarContenedores.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazEnviarContenedores.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazEnviarContenedores.ForeColor = Color.White;
            btnAbrirInterfazEnviarContenedores.Image = Properties.Resources.enviar;
            btnAbrirInterfazEnviarContenedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazEnviarContenedores.Location = new Point(30, 152);
            btnAbrirInterfazEnviarContenedores.Margin = new Padding(4);
            btnAbrirInterfazEnviarContenedores.Name = "btnAbrirInterfazEnviarContenedores";
            btnAbrirInterfazEnviarContenedores.Padding = new Padding(2);
            btnAbrirInterfazEnviarContenedores.Size = new Size(243, 76);
            btnAbrirInterfazEnviarContenedores.TabIndex = 3;
            btnAbrirInterfazEnviarContenedores.Text = "Enviar\r\nContenedores";
            btnAbrirInterfazEnviarContenedores.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazEnviarContenedores.UseVisualStyleBackColor = false;
            // 
            // btnAbrirInterfazReguardarCintas
            // 
            btnAbrirInterfazReguardarCintas.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazReguardarCintas.Dock = DockStyle.Top;
            btnAbrirInterfazReguardarCintas.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazReguardarCintas.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazReguardarCintas.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazReguardarCintas.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazReguardarCintas.ForeColor = Color.White;
            btnAbrirInterfazReguardarCintas.Image = Properties.Resources.guardarBoveda;
            btnAbrirInterfazReguardarCintas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazReguardarCintas.Location = new Point(30, 76);
            btnAbrirInterfazReguardarCintas.Margin = new Padding(0);
            btnAbrirInterfazReguardarCintas.Name = "btnAbrirInterfazReguardarCintas";
            btnAbrirInterfazReguardarCintas.Padding = new Padding(2);
            btnAbrirInterfazReguardarCintas.Size = new Size(243, 76);
            btnAbrirInterfazReguardarCintas.TabIndex = 1;
            btnAbrirInterfazReguardarCintas.Text = "Resguardar\r\nCintas";
            btnAbrirInterfazReguardarCintas.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazReguardarCintas.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAbrirInterfazImprimirEtiquetas);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(30, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 5, 0, 0);
            panel3.Size = new Size(243, 76);
            panel3.TabIndex = 0;
            // 
            // btnAbrirInterfazImprimirEtiquetas
            // 
            btnAbrirInterfazImprimirEtiquetas.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazImprimirEtiquetas.Dock = DockStyle.Top;
            btnAbrirInterfazImprimirEtiquetas.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazImprimirEtiquetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazImprimirEtiquetas.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazImprimirEtiquetas.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazImprimirEtiquetas.ForeColor = Color.White;
            btnAbrirInterfazImprimirEtiquetas.Image = Properties.Resources.Data_Cartridge_Icon1;
            btnAbrirInterfazImprimirEtiquetas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazImprimirEtiquetas.Location = new Point(0, 5);
            btnAbrirInterfazImprimirEtiquetas.Margin = new Padding(4);
            btnAbrirInterfazImprimirEtiquetas.Name = "btnAbrirInterfazImprimirEtiquetas";
            btnAbrirInterfazImprimirEtiquetas.Padding = new Padding(2);
            btnAbrirInterfazImprimirEtiquetas.Size = new Size(243, 76);
            btnAbrirInterfazImprimirEtiquetas.TabIndex = 0;
            btnAbrirInterfazImprimirEtiquetas.Text = "Imprimir\r\nEtiquetas";
            btnAbrirInterfazImprimirEtiquetas.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazImprimirEtiquetas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 332);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 30, 10);
            panel1.Size = new Size(281, 66);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.accion;
            pictureBox2.Location = new Point(10, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(71, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 20, 0);
            label3.Size = new Size(180, 57);
            label3.TabIndex = 0;
            label3.Text = "Acciones";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PanelMenuRegistros
            // 
            PanelMenuRegistros.Controls.Add(btnAbrirInterfazGenerarReporte);
            PanelMenuRegistros.Controls.Add(btnAbrirInterfazContenedores);
            PanelMenuRegistros.Controls.Add(btnAbrirInterfazCintasBoveda);
            PanelMenuRegistros.Controls.Add(btnMenuCintasActivas);
            PanelMenuRegistros.Dock = DockStyle.Top;
            PanelMenuRegistros.Location = new Point(0, 66);
            PanelMenuRegistros.Name = "PanelMenuRegistros";
            PanelMenuRegistros.Padding = new Padding(30, 0, 8, 8);
            PanelMenuRegistros.Size = new Size(281, 266);
            PanelMenuRegistros.TabIndex = 1;
            // 
            // btnAbrirInterfazGenerarReporte
            // 
            btnAbrirInterfazGenerarReporte.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazGenerarReporte.Dock = DockStyle.Top;
            btnAbrirInterfazGenerarReporte.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazGenerarReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazGenerarReporte.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazGenerarReporte.ForeColor = Color.White;
            btnAbrirInterfazGenerarReporte.Image = Properties.Resources.expediente_Icon;
            btnAbrirInterfazGenerarReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazGenerarReporte.Location = new Point(30, 200);
            btnAbrirInterfazGenerarReporte.Margin = new Padding(4);
            btnAbrirInterfazGenerarReporte.Name = "btnAbrirInterfazGenerarReporte";
            btnAbrirInterfazGenerarReporte.Padding = new Padding(2);
            btnAbrirInterfazGenerarReporte.Size = new Size(243, 59);
            btnAbrirInterfazGenerarReporte.TabIndex = 2;
            btnAbrirInterfazGenerarReporte.Text = "Generar Reporte";
            btnAbrirInterfazGenerarReporte.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnAbrirInterfazContenedores
            // 
            btnAbrirInterfazContenedores.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazContenedores.Dock = DockStyle.Top;
            btnAbrirInterfazContenedores.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazContenedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazContenedores.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazContenedores.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazContenedores.ForeColor = Color.White;
            btnAbrirInterfazContenedores.Image = Properties.Resources.Contenedor;
            btnAbrirInterfazContenedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazContenedores.Location = new Point(30, 141);
            btnAbrirInterfazContenedores.Margin = new Padding(4);
            btnAbrirInterfazContenedores.Name = "btnAbrirInterfazContenedores";
            btnAbrirInterfazContenedores.Padding = new Padding(2);
            btnAbrirInterfazContenedores.Size = new Size(243, 59);
            btnAbrirInterfazContenedores.TabIndex = 3;
            btnAbrirInterfazContenedores.Text = "Contenedores";
            btnAbrirInterfazContenedores.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazContenedores.UseVisualStyleBackColor = false;
            // 
            // btnAbrirInterfazCintasBoveda
            // 
            btnAbrirInterfazCintasBoveda.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazCintasBoveda.Dock = DockStyle.Top;
            btnAbrirInterfazCintasBoveda.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazCintasBoveda.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazCintasBoveda.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazCintasBoveda.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazCintasBoveda.ForeColor = Color.White;
            btnAbrirInterfazCintasBoveda.Image = Properties.Resources.boveda;
            btnAbrirInterfazCintasBoveda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazCintasBoveda.Location = new Point(30, 64);
            btnAbrirInterfazCintasBoveda.Margin = new Padding(4);
            btnAbrirInterfazCintasBoveda.Name = "btnAbrirInterfazCintasBoveda";
            btnAbrirInterfazCintasBoveda.Padding = new Padding(2);
            btnAbrirInterfazCintasBoveda.Size = new Size(243, 77);
            btnAbrirInterfazCintasBoveda.TabIndex = 1;
            btnAbrirInterfazCintasBoveda.Text = "Cintas en \r\nBóveda";
            btnAbrirInterfazCintasBoveda.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazCintasBoveda.UseVisualStyleBackColor = false;
            // 
            // btnMenuCintasActivas
            // 
            btnMenuCintasActivas.Controls.Add(btnAbrirInterfazCintasActivas);
            btnMenuCintasActivas.Dock = DockStyle.Top;
            btnMenuCintasActivas.Location = new Point(30, 0);
            btnMenuCintasActivas.Name = "btnMenuCintasActivas";
            btnMenuCintasActivas.Padding = new Padding(0, 5, 0, 0);
            btnMenuCintasActivas.Size = new Size(243, 64);
            btnMenuCintasActivas.TabIndex = 0;
            // 
            // btnAbrirInterfazCintasActivas
            // 
            btnAbrirInterfazCintasActivas.BackColor = Color.FromArgb(24, 57, 99);
            btnAbrirInterfazCintasActivas.Dock = DockStyle.Top;
            btnAbrirInterfazCintasActivas.FlatAppearance.BorderSize = 0;
            btnAbrirInterfazCintasActivas.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 72, 136);
            btnAbrirInterfazCintasActivas.FlatStyle = FlatStyle.Flat;
            btnAbrirInterfazCintasActivas.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnAbrirInterfazCintasActivas.ForeColor = Color.White;
            btnAbrirInterfazCintasActivas.Image = Properties.Resources.respaldo;
            btnAbrirInterfazCintasActivas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirInterfazCintasActivas.Location = new Point(0, 5);
            btnAbrirInterfazCintasActivas.Margin = new Padding(4);
            btnAbrirInterfazCintasActivas.Name = "btnAbrirInterfazCintasActivas";
            btnAbrirInterfazCintasActivas.Padding = new Padding(2);
            btnAbrirInterfazCintasActivas.Size = new Size(243, 59);
            btnAbrirInterfazCintasActivas.TabIndex = 0;
            btnAbrirInterfazCintasActivas.Text = "Cintas Activas";
            btnAbrirInterfazCintasActivas.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirInterfazCintasActivas.UseVisualStyleBackColor = false;
            // 
            // PanelTituloMenuRegistros
            // 
            PanelTituloMenuRegistros.Controls.Add(pictureBox1);
            PanelTituloMenuRegistros.Controls.Add(label2);
            PanelTituloMenuRegistros.Dock = DockStyle.Top;
            PanelTituloMenuRegistros.Location = new Point(0, 0);
            PanelTituloMenuRegistros.Name = "PanelTituloMenuRegistros";
            PanelTituloMenuRegistros.Padding = new Padding(10, 0, 10, 10);
            PanelTituloMenuRegistros.Size = new Size(281, 66);
            PanelTituloMenuRegistros.TabIndex = 0;
            PanelTituloMenuRegistros.Paint += PanelTituloMenuRegistros_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Registros;
            pictureBox1.Location = new Point(10, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(74, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 30, 0);
            label2.Size = new Size(197, 57);
            label2.TabIndex = 0;
            label2.Text = "Registros";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PanelInterfaces
            // 
            PanelInterfaces.Dock = DockStyle.Fill;
            PanelInterfaces.Location = new Point(281, 75);
            PanelInterfaces.Name = "PanelInterfaces";
            PanelInterfaces.Size = new Size(999, 645);
            PanelInterfaces.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(PanelInterfaces);
            Controls.Add(PanelMenu);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            PanelSuperior.ResumeLayout(false);
            PanelNombreApp.ResumeLayout(false);
            PanelNombreApp.PerformLayout();
            PanelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            PanelLogoForvia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).EndInit();
            PanelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelMenuRegistros.ResumeLayout(false);
            btnMenuCintasActivas.ResumeLayout(false);
            PanelTituloMenuRegistros.ResumeLayout(false);
            PanelTituloMenuRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSuperior;
        private Panel PanelLogoForvia;
        private PictureBox PBLogoForvia;
        private Panel PanelControles;
        private PictureBox PBCerrar;
        private PictureBox PBMinimizar;
        private Panel PanelNombreApp;
        private Label label1;
        private Panel PanelMenu;
        private Panel PanelInterfaces;
        private Panel PanelMenuRegistros;
        private Panel PanelTituloMenuRegistros;
        private Panel btnMenuCintasActivas;
        private Button btnAbrirInterfazCintasActivas;
        private Button btnAbrirInterfazGenerarReporte;
        private Button btnAbrirInterfazContenedores;
        private Button btnAbrirInterfazCintasBoveda;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
        private Button btnAbrirInterfazEnviarContenedores;
        private Button btnAbrirInterfazReguardarCintas;
        private Panel panel3;
        private Button btnAbrirInterfazImprimirEtiquetas;
        private PictureBox pictureBox3;
    }
}
