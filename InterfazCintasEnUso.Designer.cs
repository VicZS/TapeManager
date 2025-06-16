namespace TapeManager
{
    partial class InterfazCintasEnUso
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
            listBox1 = new ListBox();
            panel2 = new Panel();
            btnGenerarReporteCintasEnUso = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel4 = new Panel();
            LNombreCintaSeleccionada = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panel8 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panel9 = new Panel();
            label5 = new Label();
            BarraMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // BarraMenuSuperior
            // 
            BarraMenuSuperior.BackColor = Color.FromArgb(148, 148, 153);
            BarraMenuSuperior.Controls.Add(label1);
            BarraMenuSuperior.Controls.Add(iconPictureBox1);
            BarraMenuSuperior.Dock = DockStyle.Top;
            BarraMenuSuperior.Location = new Point(0, 0);
            BarraMenuSuperior.Name = "BarraMenuSuperior";
            BarraMenuSuperior.Size = new Size(1046, 50);
            BarraMenuSuperior.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(50, 13);
            label1.Name = "label1";
            label1.Size = new Size(393, 37);
            label1.TabIndex = 1;
            label1.Text = "Inventario de las Cintas en Uso";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(148, 148, 153);
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.GhostWhite;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cogs;
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
            panel1.BackColor = Color.FromArgb(148, 148, 153);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(0, 0, 10, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 10, 0);
            panel1.Size = new Size(204, 599);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Menu;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Dock = DockStyle.Left;
            listBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "PUE000L6", "PUE001L6", "PUE002L6", "PUE004L6", "PUE005L6", "PUE006L6" });
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 599);
            listBox1.Sorted = true;
            listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGenerarReporteCintasEnUso);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(204, 599);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(842, 50);
            panel2.TabIndex = 3;
            // 
            // btnGenerarReporteCintasEnUso
            // 
            btnGenerarReporteCintasEnUso.Dock = DockStyle.Right;
            btnGenerarReporteCintasEnUso.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporteCintasEnUso.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            btnGenerarReporteCintasEnUso.IconColor = Color.Green;
            btnGenerarReporteCintasEnUso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarReporteCintasEnUso.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarReporteCintasEnUso.Location = new Point(448, 0);
            btnGenerarReporteCintasEnUso.Name = "btnGenerarReporteCintasEnUso";
            btnGenerarReporteCintasEnUso.Size = new Size(384, 50);
            btnGenerarReporteCintasEnUso.TabIndex = 0;
            btnGenerarReporteCintasEnUso.Text = "Generar Reporte de las Cintas en Uso";
            btnGenerarReporteCintasEnUso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerarReporteCintasEnUso.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(204, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 70);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(LNombreCintaSeleccionada);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(80, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(762, 70);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // LNombreCintaSeleccionada
            // 
            LNombreCintaSeleccionada.AutoSize = true;
            LNombreCintaSeleccionada.Dock = DockStyle.Bottom;
            LNombreCintaSeleccionada.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombreCintaSeleccionada.Location = new Point(0, 38);
            LNombreCintaSeleccionada.Name = "LNombreCintaSeleccionada";
            LNombreCintaSeleccionada.Size = new Size(337, 32);
            LNombreCintaSeleccionada.TabIndex = 4;
            LNombreCintaSeleccionada.Text = "Cinta Seleccionada: SSS###LL";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Control;
            iconPictureBox2.Dock = DockStyle.Left;
            iconPictureBox2.ForeColor = Color.Gray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tape;
            iconPictureBox2.IconColor = Color.Gray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 70;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(80, 70);
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 120);
            label2.Name = "label2";
            label2.Size = new Size(478, 50);
            label2.TabIndex = 5;
            label2.Text = "Tipo de cinta: Nueva / Reuso\r\nTiempo que lleva en Uso (Dentro del BKP): dd/MM/yyyy";
            // 
            // panel8
            // 
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(204, 510);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10, 0, 0, 0);
            panel8.Size = new Size(842, 89);
            panel8.TabIndex = 8;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Left;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Gray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(214, 46);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(164, 43);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Buscar Cinta";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Dock = DockStyle.Left;
            textBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox1.Location = new Point(10, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 39);
            textBox1.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(832, 46);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 14);
            label5.Name = "label5";
            label5.Size = new Size(150, 32);
            label5.TabIndex = 7;
            label5.Text = "Buscar Cinta";
            // 
            // InterfazCintasEnUso
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1046, 649);
            Controls.Add(panel8);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BarraMenuSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazCintasEnUso";
            Text = "InterfazCintasEnUso";
            BarraMenuSuperior.ResumeLayout(false);
            BarraMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraMenuSuperior;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Panel panel1;
        private ListBox listBox1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnGenerarReporteCintasEnUso;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label LNombreCintaSeleccionada;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private Panel panel9;
        private Label label5;
    }
}