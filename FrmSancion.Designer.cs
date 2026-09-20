// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmSancion
    {

        private void InitializeComponent()
        {
            lblIdUsuarioSancion = new Label();
            txtIdUsuarioSancion = new TextBox();
            lblIdPrestamoSancion = new Label();
            txtIdPrestamoSancion = new TextBox();
            lblMotivoSancion = new Label();
            txtMotivoSancion = new TextBox();
            lblDiasRetraso = new Label();
            txtDiasRetraso = new TextBox();
            lblPorcentajePenalizacion = new Label();
            txtPorcentajePenalizacion = new TextBox();
            chkPagada = new CheckBox();
            chkEstadoSancion = new CheckBox();
            lblMontoSancion = new Label();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
             
            // pnlFormularioBase
             
            pnlFormularioBase.Controls.Add(lblIdUsuarioSancion);
            pnlFormularioBase.Controls.Add(txtIdUsuarioSancion);
            pnlFormularioBase.Controls.Add(lblIdPrestamoSancion);
            pnlFormularioBase.Controls.Add(txtIdPrestamoSancion);
            pnlFormularioBase.Controls.Add(lblMotivoSancion);
            pnlFormularioBase.Controls.Add(txtMotivoSancion);
            pnlFormularioBase.Controls.Add(lblDiasRetraso);
            pnlFormularioBase.Controls.Add(txtDiasRetraso);
            pnlFormularioBase.Controls.Add(lblPorcentajePenalizacion);
            pnlFormularioBase.Controls.Add(txtPorcentajePenalizacion);
            pnlFormularioBase.Controls.Add(chkPagada);
            pnlFormularioBase.Controls.Add(chkEstadoSancion);
            pnlFormularioBase.Controls.Add(lblMontoSancion);
            pnlFormularioBase.Controls.SetChildIndex(lblMontoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkPagada, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtPorcentajePenalizacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPorcentajePenalizacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtDiasRetraso, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblDiasRetraso, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtMotivoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblMotivoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdPrestamoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdPrestamoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdUsuarioSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdUsuarioSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
             
            // lblIdUsuarioSancion
             
            lblIdUsuarioSancion.AutoSize = true;
            lblIdUsuarioSancion.Location = new Point(20, 75);
            lblIdUsuarioSancion.Name = "lblIdUsuarioSancion";
            lblIdUsuarioSancion.Size = new Size(99, 25);
            lblIdUsuarioSancion.TabIndex = 2;
            lblIdUsuarioSancion.Text = "ID Usuario:";
             
            // txtIdUsuarioSancion
             
            txtIdUsuarioSancion.Location = new Point(280, 72);
            txtIdUsuarioSancion.Name = "txtIdUsuarioSancion";
            txtIdUsuarioSancion.Size = new Size(230, 31);
            txtIdUsuarioSancion.TabIndex = 3;
             
            // lblIdPrestamoSancion
             
            lblIdPrestamoSancion.AutoSize = true;
            lblIdPrestamoSancion.Location = new Point(20, 120);
            lblIdPrestamoSancion.Name = "lblIdPrestamoSancion";
            lblIdPrestamoSancion.Size = new Size(114, 25);
            lblIdPrestamoSancion.TabIndex = 4;
            lblIdPrestamoSancion.Text = "ID Préstamo:";
             
            // txtIdPrestamoSancion
             
            txtIdPrestamoSancion.Location = new Point(280, 117);
            txtIdPrestamoSancion.Name = "txtIdPrestamoSancion";
            txtIdPrestamoSancion.Size = new Size(230, 31);
            txtIdPrestamoSancion.TabIndex = 5;
             
            // lblMotivoSancion
             
            lblMotivoSancion.AutoSize = true;
            lblMotivoSancion.Location = new Point(20, 165);
            lblMotivoSancion.Name = "lblMotivoSancion";
            lblMotivoSancion.Size = new Size(73, 25);
            lblMotivoSancion.TabIndex = 6;
            lblMotivoSancion.Text = "Motivo:";
             
            // txtMotivoSancion
            
            txtMotivoSancion.Location = new Point(280, 162);
            txtMotivoSancion.Name = "txtMotivoSancion";
            txtMotivoSancion.Size = new Size(230, 31);
            txtMotivoSancion.TabIndex = 7;
            
            // lblDiasRetraso
            
            lblDiasRetraso.AutoSize = true;
            lblDiasRetraso.Location = new Point(20, 210);
            lblDiasRetraso.Name = "lblDiasRetraso";
            lblDiasRetraso.Size = new Size(135, 25);
            lblDiasRetraso.TabIndex = 8;
            lblDiasRetraso.Text = "Días de retraso:";
            
            // txtDiasRetraso
             
            txtDiasRetraso.Location = new Point(280, 207);
            txtDiasRetraso.Name = "txtDiasRetraso";
            txtDiasRetraso.Size = new Size(230, 31);
            txtDiasRetraso.TabIndex = 9;
            
            // lblPorcentajePenalizacion
            
            lblPorcentajePenalizacion.AutoSize = true;
            lblPorcentajePenalizacion.Location = new Point(20, 255);
            lblPorcentajePenalizacion.Name = "lblPorcentajePenalizacion";
            lblPorcentajePenalizacion.Size = new Size(218, 25);
            lblPorcentajePenalizacion.TabIndex = 10;
            lblPorcentajePenalizacion.Text = "Porcentaje Recargo (0 - 1):";
            
            // txtPorcentajePenalizacion
            
            txtPorcentajePenalizacion.Location = new Point(280, 252);
            txtPorcentajePenalizacion.Name = "txtPorcentajePenalizacion";
            txtPorcentajePenalizacion.PlaceholderText = "0.20";
            txtPorcentajePenalizacion.Size = new Size(230, 31);
            txtPorcentajePenalizacion.TabIndex = 11;
            
            // chkPagada
            
            chkPagada.AutoSize = true;
            chkPagada.Location = new Point(280, 300);
            chkPagada.Name = "chkPagada";
            chkPagada.Size = new Size(96, 29);
            chkPagada.TabIndex = 12;
            chkPagada.Text = "Pagada";
            chkPagada.UseVisualStyleBackColor = true;
            
            // chkEstadoSancion
            
            chkEstadoSancion.AutoSize = true;
            chkEstadoSancion.Location = new Point(400, 300);
            chkEstadoSancion.Name = "chkEstadoSancion";
            chkEstadoSancion.Size = new Size(86, 29);
            chkEstadoSancion.TabIndex = 13;
            chkEstadoSancion.Text = "Activa";
            chkEstadoSancion.UseVisualStyleBackColor = true;
            
            // lblMontoSancion
            
            lblMontoSancion.AutoSize = true;
            lblMontoSancion.Location = new Point(20, 350);
            lblMontoSancion.Name = "lblMontoSancion";
            lblMontoSancion.Size = new Size(119, 25);
            lblMontoSancion.TabIndex = 14;
            lblMontoSancion.Text = "Monto: $0.00";
            
            // FrmSancion
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmSancion";
            Text = "FrmSancion";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblIdUsuarioSancion;
        private TextBox txtIdUsuarioSancion;
        private Label lblIdPrestamoSancion;
        private TextBox txtIdPrestamoSancion;
        private Label lblMotivoSancion;
        private TextBox txtMotivoSancion;
        private Label lblDiasRetraso;
        private TextBox txtDiasRetraso;
        private Label lblPorcentajePenalizacion;
        private TextBox txtPorcentajePenalizacion;
        private CheckBox chkPagada;
        private CheckBox chkEstadoSancion;
        private Label lblMontoSancion;
    }
}