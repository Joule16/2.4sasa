// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmMaestro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlContenedorVistas = new Panel();
            pnlSuperior = new Panel();
            lblModulo = new Label();
            cmbModulo = new ComboBox();
            lblIdBusqueda = new Label();
            txtIdBusqueda = new TextBox();
            btnMasterBuscar = new Button();
            pnlInferior = new Panel();
            btnMasterGuardar = new Button();
            btnMasterActualizar = new Button();
            btnMasterEliminar = new Button();
            statusStrip1 = new StatusStrip();
            tsslEstado = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            pnlSuperior.SuspendLayout();
            pnlInferior.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            
            // pnlContenedorVistas
           
            pnlContenedorVistas.Dock = DockStyle.Fill;
            pnlContenedorVistas.Location = new Point(0, 70);
            pnlContenedorVistas.Name = "pnlContenedorVistas";
            pnlContenedorVistas.Size = new Size(900, 428);
            pnlContenedorVistas.TabIndex = 1;
           
            // pnlSuperior
          
            pnlSuperior.Controls.Add(lblModulo);
            pnlSuperior.Controls.Add(cmbModulo);
            pnlSuperior.Controls.Add(lblIdBusqueda);
            pnlSuperior.Controls.Add(txtIdBusqueda);
            pnlSuperior.Controls.Add(btnMasterBuscar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(900, 70);
            pnlSuperior.TabIndex = 0;
            
            // lblModulo
            
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(15, 22);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(79, 25);
            lblModulo.TabIndex = 0;
            lblModulo.Text = "Módulo:";
            
            // cmbModulo
            
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new Point(100, 18);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(220, 33);
            cmbModulo.TabIndex = 1;
            cmbModulo.SelectedIndexChanged += cmbModulo_SelectedIndexChanged;
            
            // lblIdBusqueda
            
            lblIdBusqueda.AutoSize = true;
            lblIdBusqueda.Location = new Point(340, 22);
            lblIdBusqueda.Name = "lblIdBusqueda";
            lblIdBusqueda.Size = new Size(105, 25);
            lblIdBusqueda.TabIndex = 2;
            lblIdBusqueda.Text = "ID a buscar:";
            
            // txtIdBusqueda
            
            txtIdBusqueda.Location = new Point(455, 18);
            txtIdBusqueda.Name = "txtIdBusqueda";
            txtIdBusqueda.Size = new Size(120, 31);
            txtIdBusqueda.TabIndex = 3;
            txtIdBusqueda.TextChanged += txtIdBusqueda_TextChanged;
            
            // btnMasterBuscar
            
            btnMasterBuscar.Location = new Point(595, 15);
            btnMasterBuscar.Name = "btnMasterBuscar";
            btnMasterBuscar.Size = new Size(120, 40);
            btnMasterBuscar.TabIndex = 4;
            btnMasterBuscar.Text = "Buscar";
            btnMasterBuscar.UseVisualStyleBackColor = true;
            btnMasterBuscar.Click += btnMasterBuscar_Click;
            
            // pnlInferior
            
            pnlInferior.Controls.Add(btnMasterGuardar);
            pnlInferior.Controls.Add(btnMasterActualizar);
            pnlInferior.Controls.Add(btnMasterEliminar);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 498);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(900, 70);
            pnlInferior.TabIndex = 2;
            
            // btnMasterGuardar
            
            btnMasterGuardar.Location = new Point(15, 15);
            btnMasterGuardar.Name = "btnMasterGuardar";
            btnMasterGuardar.Size = new Size(150, 40);
            btnMasterGuardar.TabIndex = 0;
            btnMasterGuardar.Text = "Guardar";
            btnMasterGuardar.UseVisualStyleBackColor = true;
            btnMasterGuardar.Click += btnMasterGuardar_Click;
            
            // btnMasterActualizar
            
            btnMasterActualizar.Location = new Point(180, 15);
            btnMasterActualizar.Name = "btnMasterActualizar";
            btnMasterActualizar.Size = new Size(150, 40);
            btnMasterActualizar.TabIndex = 1;
            btnMasterActualizar.Text = "Actualizar";
            btnMasterActualizar.UseVisualStyleBackColor = true;
            btnMasterActualizar.Click += btnMasterActualizar_Click;
            
            // btnMasterEliminar
            
            btnMasterEliminar.Location = new Point(345, 15);
            btnMasterEliminar.Name = "btnMasterEliminar";
            btnMasterEliminar.Size = new Size(150, 40);
            btnMasterEliminar.TabIndex = 2;
            btnMasterEliminar.Text = "Eliminar";
            btnMasterEliminar.UseVisualStyleBackColor = true;
            btnMasterEliminar.Click += btnMasterEliminar_Click;
            
            // statusStrip1
            
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslEstado });
            statusStrip1.Location = new Point(0, 568);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            
            // tsslEstado
            
            tsslEstado.Name = "tsslEstado";
            tsslEstado.Size = new Size(192, 25);
            tsslEstado.Text = "Listo. Elige un módulo.";
            
            // errorProvider1
            
            errorProvider1.ContainerControl = this;
            
            // FrmMaestro
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(pnlContenedorVistas);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            Controls.Add(statusStrip1);
            Name = "FrmMaestro";
            Text = "Sistema de Biblioteca";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInferior.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private Panel pnlContenedorVistas;
        private Panel pnlSuperior;
        private Label lblModulo;
        private ComboBox cmbModulo;
        private Label lblIdBusqueda;
        private TextBox txtIdBusqueda;
        private Button btnMasterBuscar;
        private Panel pnlInferior;
        private Button btnMasterGuardar;
        private Button btnMasterActualizar;
        private Button btnMasterEliminar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslEstado;
        private ErrorProvider errorProvider1;
    }
}