namespace WinFormsApp1
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPageJugadores = new TabPage();
            btnBuscarJugador = new Button();
            btnEliminarJugador = new Button();
            btnActualizarJugador = new Button();
            btnRegistrarJugador = new Button();
            numericNivelJugador = new NumericUpDown();
            txtNombreJugador = new TextBox();
            dataGridViewJugadores = new DataGridView();
            tabPageBloques = new TabPage();
            btnBuscarBloquesPorRareza = new Button();
            btnBuscarBloque = new Button();
            btnEliminarBloque = new Button();
            btnActualizarBloque = new Button();
            btnRegistrarBloque = new Button();
            txtTipoBloque = new TextBox();
            txtNombreBloque = new TextBox();
            dataGridView1 = new DataGridView();
            tabPageInventario = new TabPage();
            btnVerInventarioJugador = new Button();
            Eliminar = new Button();
            btnActualizarInventario = new Button();
            btnAgregarInventario = new Button();
            numericCantidad = new NumericUpDown();
            comboBoxBloques = new ComboBox();
            comboBoxJugadores = new ComboBox();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNivelJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).BeginInit();
            tabPageBloques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageJugadores);
            tabControl1.Controls.Add(tabPageBloques);
            tabControl1.Controls.Add(tabPageInventario);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1464, 954);
            tabControl1.TabIndex = 0;
            // 
            // tabPageJugadores
            // 
            tabPageJugadores.Controls.Add(btnBuscarJugador);
            tabPageJugadores.Controls.Add(btnEliminarJugador);
            tabPageJugadores.Controls.Add(btnActualizarJugador);
            tabPageJugadores.Controls.Add(btnRegistrarJugador);
            tabPageJugadores.Controls.Add(numericNivelJugador);
            tabPageJugadores.Controls.Add(txtNombreJugador);
            tabPageJugadores.Controls.Add(dataGridViewJugadores);
            tabPageJugadores.Location = new Point(8, 46);
            tabPageJugadores.Name = "tabPageJugadores";
            tabPageJugadores.Padding = new Padding(3);
            tabPageJugadores.Size = new Size(1448, 900);
            tabPageJugadores.TabIndex = 0;
            tabPageJugadores.Text = "Jugadores";
            tabPageJugadores.UseVisualStyleBackColor = true;
            // 
            // btnBuscarJugador
            // 
            btnBuscarJugador.Location = new Point(542, 751);
            btnBuscarJugador.Name = "btnBuscarJugador";
            btnBuscarJugador.Size = new Size(150, 46);
            btnBuscarJugador.TabIndex = 6;
            btnBuscarJugador.Text = "Buscar ID";
            btnBuscarJugador.UseVisualStyleBackColor = true;
            btnBuscarJugador.UseWaitCursor = true;
            btnBuscarJugador.Click += btnBuscarJugador_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Location = new Point(386, 751);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(150, 46);
            btnEliminarJugador.TabIndex = 5;
            btnEliminarJugador.Text = "Eliminar";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnActualizarJugador
            // 
            btnActualizarJugador.Location = new Point(230, 751);
            btnActualizarJugador.Name = "btnActualizarJugador";
            btnActualizarJugador.Size = new Size(150, 46);
            btnActualizarJugador.TabIndex = 4;
            btnActualizarJugador.Text = "Actualizar";
            btnActualizarJugador.UseVisualStyleBackColor = true;
            btnActualizarJugador.Click += btnActualizarJugador_Click;
            // 
            // btnRegistrarJugador
            // 
            btnRegistrarJugador.Location = new Point(71, 751);
            btnRegistrarJugador.Name = "btnRegistrarJugador";
            btnRegistrarJugador.Size = new Size(153, 46);
            btnRegistrarJugador.TabIndex = 3;
            btnRegistrarJugador.Text = "Registrar";
            btnRegistrarJugador.UseVisualStyleBackColor = true;
            btnRegistrarJugador.Click += btnRegistrarJugador_Click;
            // 
            // numericNivelJugador
            // 
            numericNivelJugador.Location = new Point(1224, 756);
            numericNivelJugador.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericNivelJugador.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericNivelJugador.Name = "numericNivelJugador";
            numericNivelJugador.Size = new Size(69, 39);
            numericNivelJugador.TabIndex = 2;
            numericNivelJugador.TabStop = false;
            numericNivelJugador.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(698, 755);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(520, 39);
            txtNombreJugador.TabIndex = 1;
            txtNombreJugador.Text = "Nombre del Jugador";
            // 
            // dataGridViewJugadores
            // 
            dataGridViewJugadores.BackgroundColor = SystemColors.Control;
            dataGridViewJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJugadores.GridColor = SystemColors.Window;
            dataGridViewJugadores.Location = new Point(6, 15);
            dataGridViewJugadores.Name = "dataGridViewJugadores";
            dataGridViewJugadores.RowHeadersWidth = 82;
            dataGridViewJugadores.Size = new Size(1436, 730);
            dataGridViewJugadores.TabIndex = 0;
            // 
            // tabPageBloques
            // 
            tabPageBloques.Controls.Add(btnBuscarBloquesPorRareza);
            tabPageBloques.Controls.Add(btnBuscarBloque);
            tabPageBloques.Controls.Add(btnEliminarBloque);
            tabPageBloques.Controls.Add(btnActualizarBloque);
            tabPageBloques.Controls.Add(btnRegistrarBloque);
            tabPageBloques.Controls.Add(txtTipoBloque);
            tabPageBloques.Controls.Add(txtNombreBloque);
            tabPageBloques.Controls.Add(dataGridView1);
            tabPageBloques.Location = new Point(8, 46);
            tabPageBloques.Name = "tabPageBloques";
            tabPageBloques.Padding = new Padding(3);
            tabPageBloques.Size = new Size(1448, 900);
            tabPageBloques.TabIndex = 1;
            tabPageBloques.Text = "Bloques";
            tabPageBloques.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBloquesPorRareza
            // 
            btnBuscarBloquesPorRareza.Location = new Point(23, 780);
            btnBuscarBloquesPorRareza.Name = "btnBuscarBloquesPorRareza";
            btnBuscarBloquesPorRareza.Size = new Size(181, 46);
            btnBuscarBloquesPorRareza.TabIndex = 7;
            btnBuscarBloquesPorRareza.Text = "Buscar Rareza";
            btnBuscarBloquesPorRareza.UseVisualStyleBackColor = true;
            btnBuscarBloquesPorRareza.Click += btnBuscarBloquesPorRareza_Click;
            // 
            // btnBuscarBloque
            // 
            btnBuscarBloque.Location = new Point(210, 780);
            btnBuscarBloque.Name = "btnBuscarBloque";
            btnBuscarBloque.Size = new Size(150, 46);
            btnBuscarBloque.TabIndex = 6;
            btnBuscarBloque.Text = "Buscar ID";
            btnBuscarBloque.UseVisualStyleBackColor = true;
            btnBuscarBloque.Click += btnBuscarBloque_Click;
            // 
            // btnEliminarBloque
            // 
            btnEliminarBloque.Location = new Point(366, 780);
            btnEliminarBloque.Name = "btnEliminarBloque";
            btnEliminarBloque.Size = new Size(150, 46);
            btnEliminarBloque.TabIndex = 5;
            btnEliminarBloque.Text = "Eliminar";
            btnEliminarBloque.UseVisualStyleBackColor = true;
            btnEliminarBloque.Click += btnEliminarBloque_Click;
            // 
            // btnActualizarBloque
            // 
            btnActualizarBloque.Location = new Point(522, 780);
            btnActualizarBloque.Name = "btnActualizarBloque";
            btnActualizarBloque.Size = new Size(150, 46);
            btnActualizarBloque.TabIndex = 4;
            btnActualizarBloque.Text = "Actualizar";
            btnActualizarBloque.UseVisualStyleBackColor = true;
            btnActualizarBloque.Click += btnActualizarBloque_Click;
            // 
            // btnRegistrarBloque
            // 
            btnRegistrarBloque.Location = new Point(678, 780);
            btnRegistrarBloque.Name = "btnRegistrarBloque";
            btnRegistrarBloque.Size = new Size(150, 46);
            btnRegistrarBloque.TabIndex = 3;
            btnRegistrarBloque.Text = "Registrar";
            btnRegistrarBloque.UseVisualStyleBackColor = true;
            btnRegistrarBloque.Click += btnRegistrarBloque_Click;
            // 
            // txtTipoBloque
            // 
            txtTipoBloque.Location = new Point(1126, 784);
            txtTipoBloque.Name = "txtTipoBloque";
            txtTipoBloque.Size = new Size(295, 39);
            txtTipoBloque.TabIndex = 2;
            txtTipoBloque.Text = "Rareza del Bloque";
            // 
            // txtNombreBloque
            // 
            txtNombreBloque.Location = new Point(834, 784);
            txtNombreBloque.Name = "txtNombreBloque";
            txtNombreBloque.Size = new Size(286, 39);
            txtNombreBloque.TabIndex = 1;
            txtNombreBloque.Text = "Nombre del Bloque";
            
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1398, 741);
            dataGridView1.TabIndex = 0;
            // 
            // tabPageInventario
            // 
            tabPageInventario.Controls.Add(btnVerInventarioJugador);
            tabPageInventario.Controls.Add(Eliminar);
            tabPageInventario.Controls.Add(btnActualizarInventario);
            tabPageInventario.Controls.Add(btnAgregarInventario);
            tabPageInventario.Controls.Add(numericCantidad);
            tabPageInventario.Controls.Add(comboBoxBloques);
            tabPageInventario.Controls.Add(comboBoxJugadores);
            tabPageInventario.Controls.Add(dataGridView2);
            tabPageInventario.Location = new Point(8, 46);
            tabPageInventario.Name = "tabPageInventario";
            tabPageInventario.Padding = new Padding(3);
            tabPageInventario.Size = new Size(1448, 900);
            tabPageInventario.TabIndex = 2;
            tabPageInventario.Text = "Inventario";
            tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // btnVerInventarioJugador
            // 
            btnVerInventarioJugador.Location = new Point(17, 675);
            btnVerInventarioJugador.Name = "btnVerInventarioJugador";
            btnVerInventarioJugador.Size = new Size(173, 46);
            btnVerInventarioJugador.TabIndex = 7;
            btnVerInventarioJugador.Text = "Ver Inventario";
            btnVerInventarioJugador.UseVisualStyleBackColor = true;
            btnVerInventarioJugador.Click += btnVerInventarioJugador_Click;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(196, 675);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(150, 46);
            Eliminar.TabIndex = 6;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // btnActualizarInventario
            // 
            btnActualizarInventario.Location = new Point(352, 675);
            btnActualizarInventario.Name = "btnActualizarInventario";
            btnActualizarInventario.Size = new Size(150, 46);
            btnActualizarInventario.TabIndex = 5;
            btnActualizarInventario.Text = "Actualizar";
            btnActualizarInventario.UseVisualStyleBackColor = true;
            btnActualizarInventario.Click += btnActualizarInventario_Click;
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Location = new Point(508, 677);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(150, 46);
            btnAgregarInventario.TabIndex = 4;
            btnAgregarInventario.Text = "Agregar";
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(664, 682);
            numericCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(75, 39);
            numericCantidad.TabIndex = 3;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxBloques
            // 
            comboBoxBloques.FormattingEnabled = true;
            comboBoxBloques.Location = new Point(745, 681);
            comboBoxBloques.Name = "comboBoxBloques";
            comboBoxBloques.Size = new Size(324, 40);
            comboBoxBloques.TabIndex = 2;
            // 
            // comboBoxJugadores
            // 
            comboBoxJugadores.FormattingEnabled = true;
            comboBoxJugadores.Location = new Point(1075, 681);
            comboBoxJugadores.Name = "comboBoxJugadores";
            comboBoxJugadores.Size = new Size(352, 40);
            comboBoxJugadores.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1410, 643);
            dataGridView2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 955);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Sistema de Gestion De Minecraft";
            tabControl1.ResumeLayout(false);
            tabPageJugadores.ResumeLayout(false);
            tabPageJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNivelJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).EndInit();
            tabPageBloques.ResumeLayout(false);
            tabPageBloques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageJugadores;
        private TabPage tabPageBloques;
        private TabPage tabPageInventario;
        private DataGridView dataGridViewJugadores;
        private TextBox txtNombreJugador;
        private Button btnActualizarJugador;
        private Button btnRegistrarJugador;
        private NumericUpDown numericNivelJugador;
        private Button btnEliminarJugador;
        private Button btnBuscarJugador;
        private DataGridView dataGridView1;
        private Button btnActualizarBloque;
        private Button btnRegistrarBloque;
        private TextBox txtTipoBloque;
        private TextBox txtNombreBloque;
        private Button btnBuscarBloque;
        private Button btnEliminarBloque;
        private Button btnBuscarBloquesPorRareza;
        private NumericUpDown numericCantidad;
        private ComboBox comboBoxBloques;
        private ComboBox comboBoxJugadores;
        private DataGridView dataGridView2;
        private Button btnVerInventarioJugador;
        private Button Eliminar;
        private Button btnActualizarInventario;
        private Button btnAgregarInventario;
    }
}
