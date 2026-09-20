// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
using SistemaBiblioteca1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca1
{
    public partial class FrmPrestamo : FrmBase, IPanelCRUD
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        // Implementación de IPanelCRUD 
        public void EjecutarGuardar()
        {
            try
            {
                Prestamo prestamo = CrearPrestamoDesdeControles();
                prestamo.InsertarRegistro(prestamo);

                MessageBox.Show("Préstamo guardado correctamente.", "Guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            alerta.SetError(txtId, string.Empty);

            try
            {
                Prestamo prestamo = new Prestamo().ConsultarRegistro(id) as Prestamo;

                if (prestamo == null)
                {
                    alerta.SetError(txtId, "No existe un préstamo con ese id.");
                    return;
                }

                txtId.Text = prestamo.Id.ToString();
                txtIdUsuarioPrestamo.Text = prestamo.IdUsuario.ToString();
                txtIdEjemplarPrestamo.Text = prestamo.IdEjemplar.ToString();
                dtpFechaPrestamo.Value = prestamo.FechaPrestamo;
                dtpFechaLimite.Value = prestamo.FechaLimite;
                chkDevuelto.Checked = prestamo.Devuelto;
                chkEstadoPrestamo.Checked = prestamo.EsActivo;
            }
            catch (ArgumentException ex)
            {
                alerta.SetError(txtId, ex.Message);
            }
        }

        public void EjecutarActualizar()
        {
            try
            {
                Prestamo prestamo = CrearPrestamoDesdeControles();

                // Conservar los datos originales
                Prestamo existente = new Prestamo().ConsultarRegistro(txtId.Text) as Prestamo;
                if (existente != null)
                {
                    prestamo.FechaRegistro = existente.FechaRegistro;

                    // Si ya estaba devuelto conserva la fecha de devolución original
                    if (chkDevuelto.Checked && existente.Devuelto)
                        prestamo.FechaDevolucionReal = existente.FechaDevolucionReal;
                }

                prestamo.ActualizarRegistro(prestamo);

                MessageBox.Show("Préstamo actualizado correctamente.", "Actualizar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            try
            {
                new Prestamo().EliminarRegistro(txtId.Text);
                LimpiarControles();
                MostrarEstado(barraEstado, "Préstamo eliminado correctamente.");
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MostrarEstado(barraEstado, ex.Message);
            }
        }

        // Métodos auxiliares 
        private Prestamo CrearPrestamoDesdeControles()
        {
            int id = LeerEntero(txtId.Text, "El id");
            int idUsuario = LeerEntero(txtIdUsuarioPrestamo.Text, "El id del usuario");
            int idEjemplar = LeerEntero(txtIdEjemplarPrestamo.Text, "El id del ejemplar");

            Prestamo prestamo = new Prestamo(id, idUsuario, idEjemplar, dtpFechaPrestamo.Value,
                                             dtpFechaLimite.Value, chkEstadoPrestamo.Checked);
            prestamo.Devuelto = chkDevuelto.Checked;
            return prestamo;
        }

        private int LeerEntero(string texto, string nombreCampo)
        {
            if (!int.TryParse(texto, out int valor))
                throw new FormatException(nombreCampo + " debe ser un número entero.");
            return valor;
        }

        private void LimpiarControles()
        {
            txtId.Clear();
            txtIdUsuarioPrestamo.Clear();
            txtIdEjemplarPrestamo.Clear();
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaLimite.Value = DateTime.Now;
            chkDevuelto.Checked = false;
            chkEstadoPrestamo.Checked = false;
        }

        private void MostrarEstado(StatusStrip barraEstado, string mensaje)
        {
            if (barraEstado.Items.Count > 0)
                barraEstado.Items[0].Text = mensaje;
        }
    }
}