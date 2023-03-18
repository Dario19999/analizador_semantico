namespace Analizador_Lexico__Traductor_
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
            Menu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem1 = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            traducirToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            TBCode = new TextBox();
            DGWarnings = new DataGridView();
            panel1 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            DGVariables = new DataGridView();
            panel4 = new Panel();
            label1 = new Label();
            DGSintaxis = new DataGridView();
            panel2 = new Panel();
            panel8 = new Panel();
            DGErrores = new DataGridView();
            label4 = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWarnings).BeginInit();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVariables).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGErrores).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.DimGray;
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, traducirToolStripMenuItem, limpiarToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1386, 24);
            Menu.TabIndex = 2;
            Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem1, guardarToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            abrirToolStripMenuItem1.Size = new Size(116, 22);
            abrirToolStripMenuItem1.Text = "Abrir";
            abrirToolStripMenuItem1.Click += abrirToolStripMenuItem1_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // traducirToolStripMenuItem
            // 
            traducirToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            traducirToolStripMenuItem.Name = "traducirToolStripMenuItem";
            traducirToolStripMenuItem.Size = new Size(68, 20);
            traducirToolStripMenuItem.Text = "Compilar";
            traducirToolStripMenuItem.Click += traducirToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(59, 20);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // TBCode
            // 
            TBCode.Location = new Point(31, 54);
            TBCode.Multiline = true;
            TBCode.Name = "TBCode";
            TBCode.Size = new Size(643, 304);
            TBCode.TabIndex = 3;
            // 
            // DGWarnings
            // 
            DGWarnings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGWarnings.BackgroundColor = Color.FromArgb(37, 38, 45);
            DGWarnings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWarnings.Location = new Point(13, 39);
            DGWarnings.Name = "DGWarnings";
            DGWarnings.RowHeadersWidth = 51;
            DGWarnings.RowTemplate.Height = 25;
            DGWarnings.Size = new Size(640, 155);
            DGWarnings.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 37, 45);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(TBCode);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 612);
            panel1.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DimGray;
            panel9.Controls.Add(label3);
            panel9.Controls.Add(DGWarnings);
            panel9.Location = new Point(703, 378);
            panel9.Name = "panel9";
            panel9.Size = new Size(666, 213);
            panel9.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(263, 7);
            label3.Name = "label3";
            label3.Size = new Size(154, 29);
            label3.TabIndex = 0;
            label3.Text = "Advertencias";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(DGVariables);
            panel5.Location = new Point(1039, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 328);
            panel5.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(107, 13);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 0;
            label2.Text = "Variables";
            // 
            // DGVariables
            // 
            DGVariables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVariables.BackgroundColor = Color.FromArgb(38, 37, 45);
            DGVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVariables.Location = new Point(10, 55);
            DGVariables.Name = "DGVariables";
            DGVariables.RowHeadersWidth = 51;
            DGVariables.RowTemplate.Height = 25;
            DGVariables.Size = new Size(307, 259);
            DGVariables.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(DGSintaxis);
            panel4.Location = new Point(703, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 328);
            panel4.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(79, 13);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 0;
            label1.Text = "Analisis Lexico";
            // 
            // DGSintaxis
            // 
            DGSintaxis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGSintaxis.BackgroundColor = Color.FromArgb(38, 37, 45);
            DGSintaxis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGSintaxis.Location = new Point(13, 55);
            DGSintaxis.Name = "DGSintaxis";
            DGSintaxis.RowHeadersWidth = 51;
            DGSintaxis.RowTemplate.Height = 25;
            DGSintaxis.Size = new Size(304, 259);
            DGSintaxis.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(21, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 327);
            panel2.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DimGray;
            panel8.Controls.Add(DGErrores);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(21, 378);
            panel8.Name = "panel8";
            panel8.Size = new Size(666, 213);
            panel8.TabIndex = 9;
            // 
            // DGErrores
            // 
            DGErrores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGErrores.BackgroundColor = Color.FromArgb(37, 38, 45);
            DGErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGErrores.Location = new Point(10, 41);
            DGErrores.Name = "DGErrores";
            DGErrores.RowHeadersWidth = 51;
            DGErrores.RowTemplate.Height = 25;
            DGErrores.Size = new Size(643, 155);
            DGErrores.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(298, 9);
            label4.Name = "label4";
            label4.Size = new Size(95, 29);
            label4.TabIndex = 0;
            label4.Text = "Errores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 612);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = Menu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto Final";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGWarnings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVariables).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem1;
        private ToolStripMenuItem traducirToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private TextBox TBCode;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private DataGridView DGWarnings;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView DGSintaxis;
        private Panel panel5;
        private DataGridView DGVariables;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel9;
        private DataGridView DGErrores;
        private Panel panel8;
    }
}