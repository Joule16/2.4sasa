// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmPrestamo
    {
        
        private void InitializeComponent()
        {
            lblIdUsuarioPrestamo = new Label();
            txtIdUsuarioPrestamo = new TextBox();
            lblIdEjemplarPrestamo = new Label();
            txtIdEjemplarPrestamo = new TextBox();
            lblFechaPrestamo = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaLimite = new Label();
            dtpFechaLimite = new DateTimePicker();
            chkDevuelto = new CheckBox();
            chkEstadoPrestamo = new CheckBox();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
            
            // lblIdUsuarioPrestamo
            
            lblIdUsuarioPrestamo.AutoSize = true;
            lblIdUsuarioPrestamo.Location = new Point(20, 75);
            lblIdUsuarioPrestamo.Name = "lblIdUsuarioPrestamo";
            lblIdUsuarioPrestamo.Size = new Size(101, 25);
            lblIdUsuarioPrestamo.TabIndex = 2;
            lblIdUsuarioPrestamo.Text = "ID Usuario:";
            
            // txtIdUsuarioPrestamo
            
            txtIdUsuarioPrestamo.Location = new Point(230, 72);
            txtIdUsuarioPrestamo.Name = "txtIdUsuarioPrestamo";
            txtIdUsuarioPrestamo.Size = new Size(230, 31);
            txtIdUsuarioPrestamo.TabIndex = 3;
            
            // lblIdEjemplarPrestamo
            
            lblIdEjemplarPrestamo.AutoSize = true;
            lblIdEjemplarPrestamo.Location = new Point(20, 120);
            lblIdEjemplarPrestamo.Name = "lblIdEjemplarPrestamo";
            lblIdEjemplarPrestamo.Size = new Size(110, 25);
            lblIdEjemplarPrestamo.TabIndex = 4;
            lblIdEjemplarPrestamo.Text = "ID Ejemplar:";
            
            // txtIdEjemplarPrestamo
            
            txtIdEjemplarPrestamo.Location = new Point(230, 117);
            txtIdEjemplarPrestamo.Name = "txtIdEjemplarPrestamo";
            txtIdEjemplarPrestamo.Size = new Size(230, 31);
            txtIdEjemplarPrestamo.TabIndex = 5;
           
            // lblFechaPrestamo
            
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(20, 165);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(157, 25);
            lblFechaPrestamo.TabIndex = 6;
            lblFechaPrestamo.Text = "Fecha de préstamo:";
            
            // dtpFechaPrestamo
            
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(230, 162);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(230, 31);
            dtpFechaPrestamo.TabIndex = 7;
            
            // lblFechaLimite
            
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Location = new Point(20, 210);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(112, 25);
            lblFechaLimite.TabIndex = 8;
            lblFechaLimite.Text = "Fecha límite:";
            
            // dtpFechaLimite
            
            dtpFechaLimite.Format = DateTimePickerFormat.Short;
            dtpFechaLimite.Location = new Point(230, 207);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(230, 31);
            dtpFechaLimite.TabIndex = 9;
            
            // chkDevuelto
            
            chkDevuelto.AutoSize = true;
            chkDevuelto.Location = new Point(230, 255);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(108, 29);
            chkDevuelto.TabIndex = 10;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            
            // chkEstadoPrestamo
            
            chkEstadoPrestamo.AutoSize = true;
            chkEstadoPrestamo.Location = new Point(360, 255);
            chkEstadoPrestamo.Name = "chkEstadoPrestamo";
            chkEstadoPrestamo.Size = new Size(85, 29);
            chkEstadoPrestamo.TabIndex = 11;
            chkEstadoPrestamo.Text = "Activo";
            chkEstadoPrestamo.UseVisualStyleBackColor = true;
            
            // pnlFormularioBase
            
            pnlFormularioBase.Controls.Add(lblIdUsuarioPrestamo);
            pnlFormularioBase.Controls.Add(txtIdUsuarioPrestamo);
            pnlFormularioBase.Controls.Add(lblIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(txtIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaPrestamo);
            pnlFormularioBase.Controls.Add(dtpFechaPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaLimite);
            pnlFormularioBase.Controls.Add(dtpFechaLimite);
            pnlFormularioBase.Controls.Add(chkDevuelto);
            pnlFormularioBase.Controls.Add(chkEstadoPrestamo);
            
            // FrmPrestamo
           
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmPrestamo";
            Text = "FrmPrestamo";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

      

        private Label lblIdUsuarioPrestamo;
        private TextBox txtIdUsuarioPrestamo;
        private Label lblIdEjemplarPrestamo;
        private TextBox txtIdEjemplarPrestamo;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechaLimite;
        private DateTimePicker dtpFechaLimite;
        private CheckBox chkDevuelto;
        private CheckBox chkEstadoPrestamo;
    }
}