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
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            PanelLogoForvia = new Panel();
            PBLogoForvia = new PictureBox();
            PanelSuperior.SuspendLayout();
            PanelNombreApp.SuspendLayout();
            PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            PanelLogoForvia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).BeginInit();
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
            PanelSuperior.Padding = new Padding(10);
            PanelSuperior.Size = new Size(1280, 66);
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
            PanelNombreApp.Size = new Size(574, 46);
            PanelNombreApp.TabIndex = 2;
            PanelNombreApp.MouseDown += ArrastrarVentana;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(345, 1);
            label1.Name = "label1";
            label1.Size = new Size(228, 45);
            label1.TabIndex = 0;
            label1.Text = "Tape Manager";
            label1.MouseDown += ArrastrarVentana;
            // 
            // PanelControles
            // 
            PanelControles.Controls.Add(PBMinimizar);
            PanelControles.Controls.Add(PBCerrar);
            PanelControles.Dock = DockStyle.Right;
            PanelControles.Location = new Point(1158, 10);
            PanelControles.Name = "PanelControles";
            PanelControles.Size = new Size(112, 46);
            PanelControles.TabIndex = 1;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Cursor = Cursors.Hand;
            PBMinimizar.Dock = DockStyle.Right;
            PBMinimizar.Image = Properties.Resources.minimizar;
            PBMinimizar.Location = new Point(20, 0);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(46, 46);
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
            PBCerrar.Location = new Point(66, 0);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(46, 46);
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
            PanelLogoForvia.Size = new Size(189, 46);
            PanelLogoForvia.TabIndex = 0;
            PanelLogoForvia.MouseDown += ArrastrarVentana;
            // 
            // PBLogoForvia
            // 
            PBLogoForvia.Dock = DockStyle.Fill;
            PBLogoForvia.Image = Properties.Resources.Logo_forvia;
            PBLogoForvia.Location = new Point(0, 14);
            PBLogoForvia.Name = "PBLogoForvia";
            PBLogoForvia.Size = new Size(189, 32);
            PBLogoForvia.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLogoForvia.TabIndex = 0;
            PBLogoForvia.TabStop = false;
            PBLogoForvia.MouseDown += ArrastrarVentana; ;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            PanelSuperior.ResumeLayout(false);
            PanelNombreApp.ResumeLayout(false);
            PanelNombreApp.PerformLayout();
            PanelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            PanelLogoForvia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBLogoForvia).EndInit();
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
    }
}
