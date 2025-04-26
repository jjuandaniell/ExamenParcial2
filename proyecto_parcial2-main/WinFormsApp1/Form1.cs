using System;
using System.Windows.Forms;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private readonly InventarioService _inventarioService;

        public MainForm()
        {
            InitializeComponent();

            // Inicializar servicios
            var dbManager = new DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);

            // Configurar el evento Load
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales
            CargarJugadores();
            CargarBloques();
            CargarInventario();
            CargarJugadoresEnComboBox();
            CargarBloquesEnComboBox();
        }

        // Métodos para cargar datos
        private void CargarJugadores()
        {
            try
            {
                var jugadores = _jugadorService.ObtenerTodos();
                dataGridViewJugadores.DataSource = jugadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBloques()
        {
            try
            {
                var bloques = _bloqueService.ObtenerTodos();
                dataGridView1.DataSource = bloques;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bloques: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInventario()
        {
            try
            {
                var inventarios = _inventarioService.ObtenerTodos();
                dataGridView2.DataSource = inventarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarJugadoresEnComboBox()
        {
            try
            {
                var jugadores = _jugadorService.ObtenerTodos();
                comboBoxJugadores.DataSource = jugadores;
                comboBoxJugadores.DisplayMember = "Nombre";
                comboBoxJugadores.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar jugadores en el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBloquesEnComboBox()
        {
            try
            {
                var bloques = _bloqueService.ObtenerTodos();
                comboBoxBloques.DataSource = bloques;
                comboBoxBloques.DisplayMember = "Nombre";
                comboBoxBloques.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bloques en el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos para Jugadores
        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            var jugador = new Jugador
            {
                Nombre = txtNombreJugador.Text,
                Nivel = (int)numericNivelJugador.Value
            };

            try
            {
                _jugadorService.Crear(jugador);
                MessageBox.Show("¡Jugador registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var jugadorSeleccionado = (Jugador)dataGridViewJugadores.SelectedRows[0].DataBoundItem;

            jugadorSeleccionado.Nombre = txtNombreJugador.Text;
            jugadorSeleccionado.Nivel = (int)numericNivelJugador.Value;

            try
            {
                _jugadorService.Actualizar(jugadorSeleccionado);
                MessageBox.Show("¡Jugador actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var jugadorSeleccionado = (Jugador)dataGridViewJugadores.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show($"¿Está seguro de eliminar al jugador {jugadorSeleccionado.Nombre}?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _jugadorService.Eliminar(jugadorSeleccionado.Id);
                    MessageBox.Show("¡Jugador eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarJugadores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNombreJugador.Text, out int jugadorId))
            {
                MessageBox.Show("Ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var jugador = _jugadorService.ObtenerPorId(jugadorId);
                if (jugador != null)
                {
                    MessageBox.Show($"Jugador encontrado:\n\n{jugador}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un jugador con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos para Bloques
        private void btnRegistrarBloque_Click(object sender, EventArgs e)
        {
            var bloque = new Bloque
            {
                Nombre = txtNombreBloque.Text,
                Tipo = txtTipoBloque.Text,
                Rareza = txtTipoBloque.Text
            };

            try
            {
                _bloqueService.Crear(bloque);
                MessageBox.Show("¡Bloque registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarBloque_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un bloque para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bloqueSeleccionado = (Bloque)dataGridView1.SelectedRows[0].DataBoundItem;

            bloqueSeleccionado.Nombre = txtNombreBloque.Text;
            bloqueSeleccionado.Tipo = txtTipoBloque.Text;
            bloqueSeleccionado.Rareza = txtTipoBloque.Text;

            try
            {
                _bloqueService.Actualizar(bloqueSeleccionado);
                MessageBox.Show("¡Bloque actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarBloque_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un bloque para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bloqueSeleccionado = (Bloque)dataGridView1.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show($"¿Está seguro de eliminar el bloque {bloqueSeleccionado.Nombre}?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _bloqueService.Eliminar(bloqueSeleccionado.Id);
                    MessageBox.Show("¡Bloque eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarBloques();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarBloquesPorRareza_Click(object sender, EventArgs e)
        {
            string rareza = txtTipoBloque.Text;

            try
            {
                var bloques = _bloqueService.BuscarPorRareza(rareza);
                dataGridView1.DataSource = bloques;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por rareza: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarBloque_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNombreBloque.Text, out int bloqueId))
            {
                MessageBox.Show("Ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bloque = _bloqueService.ObtenerPorId(bloqueId);
                if (bloque != null)
                {
                    MessageBox.Show($"Bloque encontrado:\n\n{bloque}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un bloque con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos para Inventario
        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numericCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var inventario = new Inventario
            {
                JugadorId = (int)comboBoxJugadores.SelectedValue,
                BloqueId = (int)comboBoxBloques.SelectedValue,
                Cantidad = cantidad
            };

            try
            {
                _inventarioService.Agregar(inventario);
                MessageBox.Show("¡Elemento agregado al inventario con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar al inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarInventario_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento del inventario para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var inventarioSeleccionado = (Inventario)dataGridView2.SelectedRows[0].DataBoundItem;

            if (!int.TryParse(numericCantidad.Text, out int nuevaCantidad) || nuevaCantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            inventarioSeleccionado.Cantidad = nuevaCantidad;

            try
            {
                _inventarioService.Actualizar(inventarioSeleccionado);
                MessageBox.Show("¡Inventario actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento del inventario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var inventarioSeleccionado = (Inventario)dataGridView2.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show($"¿Está seguro de eliminar este elemento del inventario?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _inventarioService.Eliminar(inventarioSeleccionado.Id);
                    MessageBox.Show("¡Elemento eliminado del inventario con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInventario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar del inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerInventarioJugador_Click(object sender, EventArgs e)
        {
            if (comboBoxJugadores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un jugador para ver su inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jugadorId = (int)comboBoxJugadores.SelectedValue;

            try
            {
                var inventarios = _inventarioService.ObtenerPorJugador(jugadorId);
                dataGridView2.DataSource = inventarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario del jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

