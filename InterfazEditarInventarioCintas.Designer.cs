namespace TapeManager
{
    partial class InterfazEditarInventarioCintas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BarraMenuSuperior = new Panel();
            panel2 = new Panel();
            btnRegresarInterfazContenedoresEnviados = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel8 = new Panel();
            BarraMenuSuperior.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraMenuSuperior
            // 
            BarraMenuSuperior.BackColor = Color.Teal;
            BarraMenuSuperior.Controls.Add(panel2);
            BarraMenuSuperior.Controls.Add(panel1);
            BarraMenuSuperior.Dock = DockStyle.Top;
            BarraMenuSuperior.Location = new Point(0, 0);
            BarraMenuSuperior.Name = "BarraMenuSuperior";
            BarraMenuSuperior.Size = new Size(1046, 50);
            BarraMenuSuperior.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRegresarInterfazContenedoresEnviados);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(868, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 50);
            panel2.TabIndex = 3;
            // 
            // btnRegresarInterfazContenedoresEnviados
            // 
            btnRegresarInterfazContenedoresEnviados.BackColor = Color.Transparent;
            btnRegresarInterfazContenedoresEnviados.Dock = DockStyle.Right;
            btnRegresarInterfazContenedoresEnviados.FlatAppearance.BorderSize = 0;
            btnRegresarInterfazContenedoresEnviados.FlatStyle = FlatStyle.Flat;
            btnRegresarInterfazContenedoresEnviados.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarInterfazContenedoresEnviados.ForeColor = Color.GhostWhite;
            btnRegresarInterfazContenedoresEnviados.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            btnRegresarInterfazContenedoresEnviados.IconColor = Color.GhostWhite;
            btnRegresarInterfazContenedoresEnviados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresarInterfazContenedoresEnviados.ImageAlign = ContentAlignment.MiddleRight;
            btnRegresarInterfazContenedoresEnviados.Location = new Point(7, 0);
            btnRegresarInterfazContenedoresEnviados.Name = "btnRegresarInterfazContenedoresEnviados";
            btnRegresarInterfazContenedoresEnviados.Size = new Size(171, 50);
            btnRegresarInterfazContenedoresEnviados.TabIndex = 0;
            btnRegresarInterfazContenedoresEnviados.Text = "Previous";
            btnRegresarInterfazContenedoresEnviados.TextAlign = ContentAlignment.MiddleLeft;
            btnRegresarInterfazContenedoresEnviados.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 50);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(50, 13);
            label1.Name = "label1";
            label1.Size = new Size(340, 37);
            label1.TabIndex = 2;
            label1.Text = "Editar Inventario de Cintas";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.GhostWhite;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tape;
            iconPictureBox1.IconColor = Color.GhostWhite;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 50);
            panel8.Name = "panel8";
            panel8.Size = new Size(1046, 12);
            panel8.TabIndex = 6;
            // 
            // InterfazEditarInventarioCintas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1046, 649);
            Controls.Add(panel8);
            Controls.Add(BarraMenuSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazEditarInventarioCintas";
            Text = "InterfazEditarInventarioCintas";
            BarraMenuSuperior.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraMenuSuperior;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnRegresarInterfazContenedoresEnviados;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel8;
    }
}