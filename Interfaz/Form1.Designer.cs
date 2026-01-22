namespace Interfaz
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
            txtOrigen = new TextBox();
            lblOrigen = new Label();
            lblDestino = new Label();
            txtDestino = new TextBox();
            btnOrigen = new Button();
            btnDestino = new Button();
            btnIniciar = new Button();
            btnPausar = new Button();
            btnReanudar = new Button();
            lstLog = new ListBox();
            btnSalir = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(16, 68);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(278, 23);
            txtOrigen.TabIndex = 0;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(16, 50);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(87, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Carpeta Origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(16, 110);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(91, 15);
            lblDestino.TabIndex = 2;
            lblDestino.Text = "Carpeta Destino";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(16, 128);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(278, 23);
            txtDestino.TabIndex = 3;
            // 
            // btnOrigen
            // 
            btnOrigen.Location = new Point(300, 68);
            btnOrigen.Name = "btnOrigen";
            btnOrigen.Size = new Size(44, 23);
            btnOrigen.TabIndex = 4;
            btnOrigen.Text = "...";
            btnOrigen.UseVisualStyleBackColor = true;
            btnOrigen.Click += btnOrigen_Click;
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(300, 128);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(44, 23);
            btnDestino.TabIndex = 5;
            btnDestino.Text = "...";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += btnDestino_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(16, 181);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(278, 23);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar Sicronización";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(16, 210);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(278, 23);
            btnPausar.TabIndex = 7;
            btnPausar.Text = "Pausar Sincronización";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnReanudar
            // 
            btnReanudar.Location = new Point(16, 239);
            btnReanudar.Name = "btnReanudar";
            btnReanudar.Size = new Size(278, 23);
            btnReanudar.TabIndex = 8;
            btnReanudar.Text = "Reanudar Sincronización";
            btnReanudar.UseVisualStyleBackColor = true;
            btnReanudar.Click += btnReanudar_Click;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(408, 23);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(543, 289);
            lstLog.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(16, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(278, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.Location = new Point(16, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(264, 28);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Sincronización de archivos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 340);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(lstLog);
            Controls.Add(btnReanudar);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciar);
            Controls.Add(btnDestino);
            Controls.Add(btnOrigen);
            Controls.Add(txtDestino);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(txtOrigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrigen;
        private Label lblOrigen;
        private Label lblDestino;
        private TextBox txtDestino;
        private Button btnOrigen;
        private Button btnDestino;
        private Button btnIniciar;
        private Button btnPausar;
        private Button btnReanudar;
        private ListBox lstLog;
        private Button btnSalir;
        private Label lblTitulo;
    }
}
