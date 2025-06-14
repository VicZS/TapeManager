namespace TapeManager
{
    partial class InterfazCintasEnBoveda
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
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            LBCintasWeekly = new ListBox();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            LBCintasDaily = new ListBox();
            panel3 = new Panel();
            label2 = new Label();
            btnGenerarReporteCintasEnBoveda = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel7 = new Panel();
            LNombreCintaSeleccionada = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            BarraMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BarraMenuSuperior
            // 
            BarraMenuSuperior.BackColor = Color.FromArgb(60, 145, 251);
            BarraMenuSuperior.Controls.Add(label1);
            BarraMenuSuperior.Controls.Add(iconPictureBox1);
            BarraMenuSuperior.Dock = DockStyle.Top;
            BarraMenuSuperior.Location = new Point(0, 0);
            BarraMenuSuperior.Name = "BarraMenuSuperior";
            BarraMenuSuperior.Size = new Size(1046, 50);
            BarraMenuSuperior.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(50, 13);
            label1.Name = "label1";
            label1.Size = new Size(436, 37);
            label1.TabIndex = 1;
            label1.Text = "Inventario de las Cintas en Boveda";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.GhostWhite;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Vault;
            iconPictureBox1.IconColor = Color.GhostWhite;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 145, 251);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 599);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(LBCintasWeekly);
            panel6.Location = new Point(0, 332);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 10, 0);
            panel6.Size = new Size(160, 268);
            panel6.TabIndex = 4;
            // 
            // LBCintasWeekly
            // 
            LBCintasWeekly.BackColor = SystemColors.Menu;
            LBCintasWeekly.BorderStyle = BorderStyle.None;
            LBCintasWeekly.Dock = DockStyle.Bottom;
            LBCintasWeekly.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBCintasWeekly.FormattingEnabled = true;
            LBCintasWeekly.HorizontalScrollbar = true;
            LBCintasWeekly.ItemHeight = 30;
            LBCintasWeekly.Items.AddRange(new object[] { "PUE000L6", "PUE001L6", "PUE002L6", "PUE004L6", "PUE005L6", "PUE006L6" });
            LBCintasWeekly.Location = new Point(0, -2);
            LBCintasWeekly.Margin = new Padding(0);
            LBCintasWeekly.Name = "LBCintasWeekly";
            LBCintasWeekly.Size = new Size(150, 270);
            LBCintasWeekly.Sorted = true;
            LBCintasWeekly.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(34, 85, 147);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 32);
            panel5.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 10, 0);
            label3.Size = new Size(103, 32);
            label3.TabIndex = 0;
            label3.Text = "Weekly";
            // 
            // panel4
            // 
            panel4.Controls.Add(LBCintasDaily);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 32);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 10, 0);
            panel4.Size = new Size(160, 268);
            panel4.TabIndex = 2;
            // 
            // LBCintasDaily
            // 
            LBCintasDaily.BackColor = SystemColors.Menu;
            LBCintasDaily.BorderStyle = BorderStyle.None;
            LBCintasDaily.Dock = DockStyle.Bottom;
            LBCintasDaily.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBCintasDaily.FormattingEnabled = true;
            LBCintasDaily.HorizontalScrollbar = true;
            LBCintasDaily.ItemHeight = 30;
            LBCintasDaily.Items.AddRange(new object[] { "PUE000L6", "PUE001L6", "PUE002L6", "PUE004L6", "PUE005L6", "PUE006L6" });
            LBCintasDaily.Location = new Point(0, -2);
            LBCintasDaily.Margin = new Padding(0);
            LBCintasDaily.Name = "LBCintasDaily";
            LBCintasDaily.Size = new Size(150, 270);
            LBCintasDaily.Sorted = true;
            LBCintasDaily.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 85, 147);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 32);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 10, 0);
            label2.Size = new Size(78, 32);
            label2.TabIndex = 0;
            label2.Text = "Daily";
            // 
            // btnGenerarReporteCintasEnBoveda
            // 
            btnGenerarReporteCintasEnBoveda.Dock = DockStyle.Right;
            btnGenerarReporteCintasEnBoveda.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporteCintasEnBoveda.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            btnGenerarReporteCintasEnBoveda.IconColor = Color.Green;
            btnGenerarReporteCintasEnBoveda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarReporteCintasEnBoveda.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarReporteCintasEnBoveda.Location = new Point(450, 0);
            btnGenerarReporteCintasEnBoveda.Name = "btnGenerarReporteCintasEnBoveda";
            btnGenerarReporteCintasEnBoveda.Size = new Size(426, 50);
            btnGenerarReporteCintasEnBoveda.TabIndex = 0;
            btnGenerarReporteCintasEnBoveda.Text = "Generar Reporte de las Cintas en Boveda";
            btnGenerarReporteCintasEnBoveda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerarReporteCintasEnBoveda.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGenerarReporteCintasEnBoveda);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(160, 599);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(886, 50);
            panel2.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(LNombreCintaSeleccionada);
            panel7.Controls.Add(iconPictureBox2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(160, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(886, 70);
            panel7.TabIndex = 5;
            // 
            // LNombreCintaSeleccionada
            // 
            LNombreCintaSeleccionada.AutoSize = true;
            LNombreCintaSeleccionada.Dock = DockStyle.Bottom;
            LNombreCintaSeleccionada.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombreCintaSeleccionada.Location = new Point(80, 38);
            LNombreCintaSeleccionada.Name = "LNombreCintaSeleccionada";
            LNombreCintaSeleccionada.Size = new Size(337, 32);
            LNombreCintaSeleccionada.TabIndex = 6;
            LNombreCintaSeleccionada.Text = "Cinta Seleccionada: SSS###LL";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Control;
            iconPictureBox2.Dock = DockStyle.Left;
            iconPictureBox2.ForeColor = Color.FromArgb(34, 85, 147);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tape;
            iconPictureBox2.IconColor = Color.FromArgb(34, 85, 147);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 70;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(80, 70);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 120);
            label4.Name = "label4";
            label4.Size = new Size(258, 75);
            label4.TabIndex = 6;
            label4.Text = "Cinta: Nueva / Reuso\r\nData Media Set: Daily/Weekly\r\nFecha de Retiro: dd/MM/yyyy";
            // 
            // InterfazCintasEnBoveda
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1046, 649);
            Controls.Add(label4);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BarraMenuSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazCintasEnBoveda";
            Text = "InterfazCintasEnBoveda";
            BarraMenuSuperior.ResumeLayout(false);
            BarraMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraMenuSuperior;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnGenerarReporteCintasEnBoveda;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Panel panel6;
        private ListBox LBCintasWeekly;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private ListBox LBCintasDaily;
        private Panel panel7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label LNombreCintaSeleccionada;
        private Label label4;
    }
}