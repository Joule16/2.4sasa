// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
using System;
using System.Windows.Forms;

// Autoría: (pon aquí el mismo encabezado con los nombres del equipo)

namespace SistemaBiblioteca1
{
    public partial class FrmMaestro : Form
    {
        // Variable polimórfica: no conoce las clases concretas de los hijos
        private IPanelCRUD vistaActiva;

        public FrmMaestro()
        {
            InitializeComponent();
            cmbModulo.Items.AddRange(new object[] { "Autor", "Libro", "Prestamo", "Sancion", "Usuario" });
        }

        // ---------- Selección e incrustación del módulo ----------
        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form vista = CrearVista(cmbModulo.SelectedItem?.ToString());
            if (vista == null)
                return;

            MostrarVista(vista);
        }

        private Form CrearVista(string modulo)
        {
            switch (modulo)
            {
                case "Autor":
                    return new FrmAutor();
                case "Usuario":
                    return new FrmUsuario();
                case "Libro":
                    return new FrmLibro();
                case "Prestamo":
                    return new FrmPrestamo();
                case "Sancion":
                    return new FrmSancion();
                default:
                    return null;
            }
        }

        private void MostrarVista(Form vista)
        {
            // Quitar y liberar la vista anterior
            if (pnlContenedorVistas.Controls.Count > 0)
            {
                Control anterior = pnlContenedorVistas.Controls[0];
                pnlContenedorVistas.Controls.Clear();
                anterior.Dispose();
            }

            // Incrustar el formulario hijo dentro del panel
            vista.TopLevel = false;
            vista.FormBorderStyle = FormBorderStyle.None;
            vista.Dock = DockStyle.Fill;
            pnlContenedorVistas.Controls.Add(vista);
            vista.Show();

            vistaActiva = (IPanelCRUD)vista;

            errorProvider1.Clear();
            tsslEstado.Text = "Módulo activo: " + cmbModulo.SelectedItem;
        }

        // ---------- Botones maestros ----------
        private void btnMasterGuardar_Click(object sender, EventArgs e)
        {
            if (!HayVistaActiva()) return;
            vistaActiva.EjecutarGuardar();
        }

        private void btnMasterBuscar_Click(object sender, EventArgs e)
        {
            if (!HayVistaActiva()) return;
            vistaActiva.EjecutarBuscar(txtIdBusqueda.Text, errorProvider1);
        }

        private void btnMasterActualizar_Click(object sender, EventArgs e)
        {
            if (!HayVistaActiva()) return;
            vistaActiva.EjecutarActualizar();
        }

        private void btnMasterEliminar_Click(object sender, EventArgs e)
        {
            if (!HayVistaActiva()) return;
            vistaActiva.EjecutarEliminar(statusStrip1);
        }

        private bool HayVistaActiva()
        {
            if (vistaActiva == null)
            {
                tsslEstado.Text = "Primero elige un módulo.";
                return false;
            }
            return true;
        }

        private void txtIdBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}