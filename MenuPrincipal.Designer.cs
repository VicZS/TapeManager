namespace TapeManager
{
    partial class MenuPrincipal
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
            btnAjustes = new FontAwesome.Sharp.IconPictureBox();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            PanelLogoForvia = new Panel();
            PBLogoForvia = new PictureBox();
            PanelMenu = new Panel();
            panel8 = new Panel();
            MenuCompararInventario = new FontAwesome.Sharp.IconButton();
            MenuEditarInventario = new FontAwesome.Sharp.IconButton();
            MenuImprimirBarcode = new FontAwesome.Sharp.IconButton();
            MenuEnviarContenedor = new FontAwesome.Sharp.IconButton();
            MenuResguardarCintas = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            MenuGenerarReportes = new FontAwesome.Sharp.IconButton();
            MenuContenedores = new FontAwesome.Sharp.IconButton();
            MenuCintasBoveda = new FontAwesome.Sharp.IconButton();
            MenuCintasUso = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            PanelInterfaces = new Panel();
            PanelSuperior.SuspendLayout();
            PanelNombreApp.SuspendLayout();
            PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAjustes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            PanelLogoForvia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).BeginInit();
            PanelMenu.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
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
            PanelSuperior.Padding = new Padding(5);
            PanelSuperior.Size = new Size(1280, 71);
            PanelSuperior.TabIndex = 0;
            PanelSuperior.MouseDown += ArrastrarVentana;
            // 
            // PanelNombreApp
            // 
            PanelNombreApp.Controls.Add(label1);
            PanelNombreApp.Dock = DockStyle.Left;
            PanelNombreApp.Location = new Point(170, 5);
            PanelNombreApp.Name = "PanelNombreApp";
            PanelNombreApp.Padding = new Padding(1);
            PanelNombreApp.Size = new Size(786, 61);
            PanelNombreApp.TabIndex = 2;
            PanelNombreApp.MouseDown += ArrastrarVentana;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(345, 1);
            label1.Name = "label1";
            label1.Size = new Size(440, 51);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Cintas";
            label1.MouseDown += ArrastrarVentana;
            // 
            // PanelControles
            // 
            PanelControles.Controls.Add(btnAjustes);
            PanelControles.Controls.Add(PBMinimizar);
            PanelControles.Controls.Add(PBCerrar);
            PanelControles.Dock = DockStyle.Right;
            PanelControles.Location = new Point(1115, 5);
            PanelControles.Name = "PanelControles";
            PanelControles.Padding = new Padding(0, 0, 0, 17);
            PanelControles.Size = new Size(160, 61);
            PanelControles.TabIndex = 1;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.FromArgb(17, 47, 84);
            btnAjustes.Cursor = Cursors.Hand;
            btnAjustes.Dock = DockStyle.Left;
            btnAjustes.ForeColor = Color.Gainsboro;
            btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnAjustes.IconColor = Color.Gainsboro;
            btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAjustes.IconSize = 44;
            btnAjustes.Location = new Point(0, 0);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(44, 44);
            btnAjustes.TabIndex = 2;
            btnAjustes.TabStop = false;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Cursor = Cursors.Hand;
            PBMinimizar.Dock = DockStyle.Right;
            PBMinimizar.Image = Properties.Resources.minimizar;
            PBMinimizar.Location = new Point(72, 0);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(44, 44);
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
            PBCerrar.Location = new Point(116, 0);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(44, 44);
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
            PanelLogoForvia.Location = new Point(5, 5);
            PanelLogoForvia.Name = "PanelLogoForvia";
            PanelLogoForvia.Size = new Size(165, 61);
            PanelLogoForvia.TabIndex = 0;
            PanelLogoForvia.MouseDown += ArrastrarVentana;
            // 
            // PBLogoForvia
            // 
            PBLogoForvia.Cursor = Cursors.Hand;
            PBLogoForvia.Dock = DockStyle.Fill;
            PBLogoForvia.Image = Properties.Resources.forvia_logo;
            PBLogoForvia.Location = new Point(0, 0);
            PBLogoForvia.Margin = new Padding(0);
            PBLogoForvia.Name = "PBLogoForvia";
            PBLogoForvia.Size = new Size(165, 61);
            PBLogoForvia.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLogoForvia.TabIndex = 0;
            PBLogoForvia.TabStop = false;
            PBLogoForvia.Click += PBLogoForvia_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.AutoScroll = true;
            PanelMenu.BackColor = Color.FromArgb(24, 57, 99);
            PanelMenu.Controls.Add(panel8);
            PanelMenu.Controls.Add(panel7);
            PanelMenu.Controls.Add(panel6);
            PanelMenu.Controls.Add(panel5);
            PanelMenu.Controls.Add(panel4);
            PanelMenu.Controls.Add(panel3);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(panel1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 71);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(234, 649);
            PanelMenu.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(MenuCompararInventario);
            panel8.Controls.Add(MenuEditarInventario);
            panel8.Controls.Add(MenuImprimirBarcode);
            panel8.Controls.Add(MenuEnviarContenedor);
            panel8.Controls.Add(MenuResguardarCintas);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 370);
            panel8.Name = "panel8";
            panel8.Size = new Size(224, 279);
            panel8.TabIndex = 7;
            // 
            // MenuCompararInventario
            // 
            MenuCompararInventario.Dock = DockStyle.Top;
            MenuCompararInventario.FlatAppearance.BorderSize = 0;
            MenuCompararInventario.FlatStyle = FlatStyle.Flat;
            MenuCompararInventario.ForeColor = SystemColors.Menu;
            MenuCompararInventario.IconChar = FontAwesome.Sharp.IconChar.CodeCompare;
            MenuCompararInventario.IconColor = Color.Chocolate;
            MenuCompararInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCompararInventario.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCompararInventario.Location = new Point(0, 200);
            MenuCompararInventario.Name = "MenuCompararInventario";
            MenuCompararInventario.Padding = new Padding(10, 0, 0, 0);
            MenuCompararInventario.Size = new Size(224, 55);
            MenuCompararInventario.TabIndex = 5;
            MenuCompararInventario.Text = "Comparar\r\nInventario";
            MenuCompararInventario.TextAlign = ContentAlignment.MiddleRight;
            MenuCompararInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuCompararInventario.UseVisualStyleBackColor = true;
            MenuCompararInventario.Click += MenuCompararInventario_Click;
            // 
            // MenuEditarInventario
            // 
            MenuEditarInventario.Dock = DockStyle.Top;
            MenuEditarInventario.FlatAppearance.BorderSize = 0;
            MenuEditarInventario.FlatStyle = FlatStyle.Flat;
            MenuEditarInventario.ForeColor = SystemColors.Menu;
            MenuEditarInventario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            MenuEditarInventario.IconColor = Color.PaleTurquoise;
            MenuEditarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuEditarInventario.ImageAlign = ContentAlignment.MiddleLeft;
            MenuEditarInventario.Location = new Point(0, 150);
            MenuEditarInventario.Name = "MenuEditarInventario";
            MenuEditarInventario.Padding = new Padding(10, 0, 0, 0);
            MenuEditarInventario.Size = new Size(224, 50);
            MenuEditarInventario.TabIndex = 4;
            MenuEditarInventario.Text = "Editar Inventario";
            MenuEditarInventario.TextAlign = ContentAlignment.MiddleRight;
            MenuEditarInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuEditarInventario.UseVisualStyleBackColor = true;
            MenuEditarInventario.Click += MenuEditarInventario_Click;
            // 
            // MenuImprimirBarcode
            // 
            MenuImprimirBarcode.Dock = DockStyle.Top;
            MenuImprimirBarcode.FlatAppearance.BorderSize = 0;
            MenuImprimirBarcode.FlatStyle = FlatStyle.Flat;
            MenuImprimirBarcode.ForeColor = SystemColors.Menu;
            MenuImprimirBarcode.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            MenuImprimirBarcode.IconColor = Color.DimGray;
            MenuImprimirBarcode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuImprimirBarcode.ImageAlign = ContentAlignment.MiddleLeft;
            MenuImprimirBarcode.Location = new Point(0, 100);
            MenuImprimirBarcode.Name = "MenuImprimirBarcode";
            MenuImprimirBarcode.Padding = new Padding(10, 0, 0, 0);
            MenuImprimirBarcode.Size = new Size(224, 50);
            MenuImprimirBarcode.TabIndex = 3;
            MenuImprimirBarcode.Text = "Imprimir Barcode";
            MenuImprimirBarcode.TextAlign = ContentAlignment.MiddleRight;
            MenuImprimirBarcode.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuImprimirBarcode.UseVisualStyleBackColor = true;
            MenuImprimirBarcode.Click += MenuImprimirBarcode_Click;
            // 
            // MenuEnviarContenedor
            // 
            MenuEnviarContenedor.Dock = DockStyle.Top;
            MenuEnviarContenedor.FlatAppearance.BorderSize = 0;
            MenuEnviarContenedor.FlatStyle = FlatStyle.Flat;
            MenuEnviarContenedor.ForeColor = SystemColors.Menu;
            MenuEnviarContenedor.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            MenuEnviarContenedor.IconColor = Color.Orange;
            MenuEnviarContenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuEnviarContenedor.ImageAlign = ContentAlignment.MiddleLeft;
            MenuEnviarContenedor.Location = new Point(0, 50);
            MenuEnviarContenedor.Name = "MenuEnviarContenedor";
            MenuEnviarContenedor.Padding = new Padding(10, 0, 0, 0);
            MenuEnviarContenedor.Size = new Size(224, 50);
            MenuEnviarContenedor.TabIndex = 2;
            MenuEnviarContenedor.Text = "Enviar Contenedor";
            MenuEnviarContenedor.TextAlign = ContentAlignment.MiddleRight;
            MenuEnviarContenedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuEnviarContenedor.UseVisualStyleBackColor = true;
            MenuEnviarContenedor.Click += MenuEnviarContenedor_Click;
            // 
            // MenuResguardarCintas
            // 
            MenuResguardarCintas.Dock = DockStyle.Top;
            MenuResguardarCintas.FlatAppearance.BorderSize = 0;
            MenuResguardarCintas.FlatStyle = FlatStyle.Flat;
            MenuResguardarCintas.ForeColor = SystemColors.Menu;
            MenuResguardarCintas.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            MenuResguardarCintas.IconColor = Color.Gainsboro;
            MenuResguardarCintas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuResguardarCintas.ImageAlign = ContentAlignment.MiddleLeft;
            MenuResguardarCintas.Location = new Point(0, 0);
            MenuResguardarCintas.Name = "MenuResguardarCintas";
            MenuResguardarCintas.Padding = new Padding(10, 0, 0, 0);
            MenuResguardarCintas.Size = new Size(224, 50);
            MenuResguardarCintas.TabIndex = 1;
            MenuResguardarCintas.Text = "Resguardar Cintas";
            MenuResguardarCintas.TextAlign = ContentAlignment.MiddleRight;
            MenuResguardarCintas.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuResguardarCintas.UseVisualStyleBackColor = true;
            MenuResguardarCintas.Click += MenuResguardarCintas_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 360);
            panel7.Name = "panel7";
            panel7.Size = new Size(224, 10);
            panel7.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 290);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 70);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(71, 33);
            label3.Name = "label3";
            label3.Size = new Size(141, 37);
            label3.TabIndex = 1;
            label3.Text = "Funciones";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.icono_funciones;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 280);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 10);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(MenuGenerarReportes);
            panel4.Controls.Add(MenuContenedores);
            panel4.Controls.Add(MenuCintasBoveda);
            panel4.Controls.Add(MenuCintasUso);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 200);
            panel4.TabIndex = 3;
            // 
            // MenuGenerarReportes
            // 
            MenuGenerarReportes.Dock = DockStyle.Top;
            MenuGenerarReportes.FlatAppearance.BorderSize = 0;
            MenuGenerarReportes.FlatStyle = FlatStyle.Flat;
            MenuGenerarReportes.ForeColor = SystemColors.Menu;
            MenuGenerarReportes.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            MenuGenerarReportes.IconColor = Color.Green;
            MenuGenerarReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuGenerarReportes.ImageAlign = ContentAlignment.MiddleLeft;
            MenuGenerarReportes.Location = new Point(0, 150);
            MenuGenerarReportes.Name = "MenuGenerarReportes";
            MenuGenerarReportes.Padding = new Padding(10, 0, 0, 0);
            MenuGenerarReportes.Size = new Size(224, 50);
            MenuGenerarReportes.TabIndex = 4;
            MenuGenerarReportes.Text = "Generar Reporte";
            MenuGenerarReportes.TextAlign = ContentAlignment.MiddleRight;
            MenuGenerarReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuGenerarReportes.UseVisualStyleBackColor = true;
            MenuGenerarReportes.Click += MenuGenerarReportes_Click;
            // 
            // MenuContenedores
            // 
            MenuContenedores.Dock = DockStyle.Top;
            MenuContenedores.FlatAppearance.BorderSize = 0;
            MenuContenedores.FlatStyle = FlatStyle.Flat;
            MenuContenedores.ForeColor = SystemColors.Menu;
            MenuContenedores.IconChar = FontAwesome.Sharp.IconChar.Archive;
            MenuContenedores.IconColor = Color.Gray;
            MenuContenedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuContenedores.ImageAlign = ContentAlignment.MiddleLeft;
            MenuContenedores.Location = new Point(0, 100);
            MenuContenedores.Name = "MenuContenedores";
            MenuContenedores.Padding = new Padding(10, 0, 0, 0);
            MenuContenedores.Size = new Size(224, 50);
            MenuContenedores.TabIndex = 3;
            MenuContenedores.Text = "Contenedores";
            MenuContenedores.TextAlign = ContentAlignment.MiddleRight;
            MenuContenedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuContenedores.UseVisualStyleBackColor = true;
            MenuContenedores.Click += MenuContenedores_Click;
            // 
            // MenuCintasBoveda
            // 
            MenuCintasBoveda.Dock = DockStyle.Top;
            MenuCintasBoveda.FlatAppearance.BorderSize = 0;
            MenuCintasBoveda.FlatStyle = FlatStyle.Flat;
            MenuCintasBoveda.ForeColor = SystemColors.Menu;
            MenuCintasBoveda.IconChar = FontAwesome.Sharp.IconChar.Vault;
            MenuCintasBoveda.IconColor = Color.LightBlue;
            MenuCintasBoveda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCintasBoveda.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCintasBoveda.Location = new Point(0, 50);
            MenuCintasBoveda.Name = "MenuCintasBoveda";
            MenuCintasBoveda.Padding = new Padding(10, 0, 0, 0);
            MenuCintasBoveda.Size = new Size(224, 50);
            MenuCintasBoveda.TabIndex = 2;
            MenuCintasBoveda.Text = "Cintas en Boveda\r\n";
            MenuCintasBoveda.TextAlign = ContentAlignment.MiddleRight;
            MenuCintasBoveda.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuCintasBoveda.UseVisualStyleBackColor = true;
            MenuCintasBoveda.Click += MenuCintasBoveda_Click;
            // 
            // MenuCintasUso
            // 
            MenuCintasUso.Dock = DockStyle.Top;
            MenuCintasUso.FlatAppearance.BorderSize = 0;
            MenuCintasUso.FlatStyle = FlatStyle.Flat;
            MenuCintasUso.ForeColor = SystemColors.Menu;
            MenuCintasUso.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            MenuCintasUso.IconColor = Color.GhostWhite;
            MenuCintasUso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCintasUso.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCintasUso.Location = new Point(0, 0);
            MenuCintasUso.Name = "MenuCintasUso";
            MenuCintasUso.Padding = new Padding(10, 0, 0, 0);
            MenuCintasUso.Size = new Size(224, 50);
            MenuCintasUso.TabIndex = 1;
            MenuCintasUso.Text = "Cintas en Uso";
            MenuCintasUso.TextAlign = ContentAlignment.MiddleRight;
            MenuCintasUso.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuCintasUso.UseVisualStyleBackColor = true;
            MenuCintasUso.Click += MenuCintasUso_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 10);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 70);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(71, 33);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 1;
            label2.Text = "Inventario";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.la_gestion_del_inventario;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 649);
            panel1.TabIndex = 0;
            // 
            // PanelInterfaces
            // 
            PanelInterfaces.Dock = DockStyle.Fill;
            PanelInterfaces.Location = new Point(234, 71);
            PanelInterfaces.Margin = new Padding(0);
            PanelInterfaces.Name = "PanelInterfaces";
            PanelInterfaces.Size = new Size(1046, 649);
            PanelInterfaces.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1280, 720);
            Controls.Add(PanelInterfaces);
            Controls.Add(PanelMenu);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1280, 720);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            PanelSuperior.ResumeLayout(false);
            PanelNombreApp.ResumeLayout(false);
            PanelNombreApp.PerformLayout();
            PanelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAjustes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            PanelLogoForvia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).EndInit();
            PanelMenu.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton MenuCintasUso;
        private FontAwesome.Sharp.IconButton MenuCintasBoveda;
        private FontAwesome.Sharp.IconButton MenuContenedores;
        private Panel panel6;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton MenuImprimirBarcode;
        private FontAwesome.Sharp.IconButton MenuEnviarContenedor;
        private FontAwesome.Sharp.IconButton MenuResguardarCintas;
        private Panel panel7;
        private FontAwesome.Sharp.IconPictureBox btnAjustes;
        private FontAwesome.Sharp.IconButton MenuGenerarReportes;
        private FontAwesome.Sharp.IconButton MenuCompararInventario;
        private FontAwesome.Sharp.IconButton MenuEditarInventario;
    }
}
