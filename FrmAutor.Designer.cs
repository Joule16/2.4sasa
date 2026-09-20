// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmAutor
    {

        private void InitializeComponent()
        {
            lblNombreAutor = new Label();
            txtNombreAutor = new TextBox();
            lblApellidoAutor = new Label();
            txtApellidoAutor = new TextBox();
            lblNacionalidadAutor = new Label();
            txtNacionalidadAutor = new TextBox();
            lblFechaNacimientoAutor = new Label();
            dtpFechaNacimientoAutor = new DateTimePicker();
            chkEstadoAutor = new CheckBox();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
          
            // pnlFormularioBase

            pnlFormularioBase.Controls.Add(lblNombreAutor);
            pnlFormularioBase.Controls.Add(txtNombreAutor);
            pnlFormularioBase.Controls.Add(lblApellidoAutor);
            pnlFormularioBase.Controls.Add(txtApellidoAutor);
            pnlFormularioBase.Controls.Add(lblNacionalidadAutor);
            pnlFormularioBase.Controls.Add(txtNacionalidadAutor);
            pnlFormularioBase.Controls.Add(lblFechaNacimientoAutor);
            pnlFormularioBase.Controls.Add(dtpFechaNacimientoAutor);
            pnlFormularioBase.Controls.Add(chkEstadoAutor);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaNacimientoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaNacimientoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNacionalidadAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNacionalidadAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtApellidoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblApellidoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNombreAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNombreAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
         
            // txtId
            
            txtId.Location = new Point(230, 35);
         
            // lblNombreAutor
          
            lblNombreAutor.AutoSize = true;
            lblNombreAutor.Location = new Point(20, 75);
            lblNombreAutor.Name = "lblNombreAutor";
            lblNombreAutor.Size = new Size(161, 25);
            lblNombreAutor.TabIndex = 2;
            lblNombreAutor.Text = "Nombre del Autor:";
        
            // txtNombreAutor
        
            txtNombreAutor.Location = new Point(230, 75);
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(230, 31);
            txtNombreAutor.TabIndex = 3;
           
            // lblApellidoAutor
           
            lblApellidoAutor.AutoSize = true;
            lblApellidoAutor.Location = new Point(20, 120);
            lblApellidoAutor.Name = "lblApellidoAutor";
            lblApellidoAutor.Size = new Size(161, 25);
            lblApellidoAutor.TabIndex = 4;
            lblApellidoAutor.Text = "Apellido del Autor:";
           
            // txtApellidoAutor
        
            txtApellidoAutor.Location = new Point(230, 117);
            txtApellidoAutor.Name = "txtApellidoAutor";
            txtApellidoAutor.Size = new Size(230, 31);
            txtApellidoAutor.TabIndex = 5;
         
            // lblNacionalidadAutor
         
            lblNacionalidadAutor.AutoSize = true;
            lblNacionalidadAutor.Location = new Point(20, 165);
            lblNacionalidadAutor.Name = "lblNacionalidadAutor";
            lblNacionalidadAutor.Size = new Size(119, 25);
            lblNacionalidadAutor.TabIndex = 6;
            lblNacionalidadAutor.Text = "Nacionalidad:";
         
            // txtNacionalidadAutor
       
            txtNacionalidadAutor.Location = new Point(230, 162);
            txtNacionalidadAutor.Name = "txtNacionalidadAutor";
            txtNacionalidadAutor.Size = new Size(230, 31);
            txtNacionalidadAutor.TabIndex = 7;
          
            // lblFechaNacimientoAutor
        
            lblFechaNacimientoAutor.AutoSize = true;
            lblFechaNacimientoAutor.Location = new Point(20, 210);
            lblFechaNacimientoAutor.Name = "lblFechaNacimientoAutor";
            lblFechaNacimientoAutor.Size = new Size(178, 25);
            lblFechaNacimientoAutor.TabIndex = 8;
            lblFechaNacimientoAutor.Text = "Fecha de nacimiento:";
       
            // dtpFechaNacimientoAutor
           
            dtpFechaNacimientoAutor.Format = DateTimePickerFormat.Short;
            dtpFechaNacimientoAutor.Location = new Point(230, 207);
            dtpFechaNacimientoAutor.Name = "dtpFechaNacimientoAutor";
            dtpFechaNacimientoAutor.Size = new Size(230, 31);
            dtpFechaNacimientoAutor.TabIndex = 9;
       
            // chkEstadoAutor
        
            chkEstadoAutor.AutoSize = true;
            chkEstadoAutor.Location = new Point(230, 260);
            chkEstadoAutor.Name = "chkEstadoAutor";
            chkEstadoAutor.Size = new Size(88, 29);
            chkEstadoAutor.TabIndex = 10;
            chkEstadoAutor.Text = "Activo";
            chkEstadoAutor.UseVisualStyleBackColor = true;
       
            // FrmAutor
       
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmAutor";
            Text = "FrmAutor";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblNombreAutor;
        private TextBox txtNombreAutor;
        private Label lblApellidoAutor;
        private TextBox txtApellidoAutor;
        private Label lblNacionalidadAutor;
        private TextBox txtNacionalidadAutor;
        private Label lblFechaNacimientoAutor;
        private DateTimePicker dtpFechaNacimientoAutor;
        private CheckBox chkEstadoAutor;
    }
}