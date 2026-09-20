// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmLibro
    {
        private void InitializeComponent()
        {
            lblTituloLibro = new Label();
            txtTituloLibro = new TextBox();
            lblIsbn = new Label();
            txtIsbn = new TextBox();
            lblIdAutorLibro = new Label();
            txtIdAutorLibro = new TextBox();
            lblIdCategoriaLibro = new Label();
            txtIdCategoriaLibro = new TextBox();
            lblIdEditorialLibro = new Label();
            txtIdEditorialLibro = new TextBox();
            lblAnioPublicacion = new Label();
            txtAnioPublicacion = new TextBox();
            chkEstadoLibro = new CheckBox();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
        
            // lblTituloLibro
          
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Location = new Point(20, 73);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(62, 25);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Título:";
           
            // txtTituloLibro
        
            txtTituloLibro.Location = new Point(230, 70);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(230, 31);
            txtTituloLibro.TabIndex = 3;
      
            // lblIsbn
       
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(20, 113);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(55, 25);
            lblIsbn.TabIndex = 4;
            lblIsbn.Text = "ISBN:";
         
            // txtIsbn
      
            txtIsbn.Location = new Point(230, 110);
            txtIsbn.MaxLength = 13;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(230, 31);
            txtIsbn.TabIndex = 5;
          
            // lblIdAutorLibro
         
            lblIdAutorLibro.AutoSize = true;
            lblIdAutorLibro.Location = new Point(20, 153);
            lblIdAutorLibro.Name = "lblIdAutorLibro";
            lblIdAutorLibro.Size = new Size(85, 25);
            lblIdAutorLibro.TabIndex = 6;
            lblIdAutorLibro.Text = "ID Autor:";
         
            // txtIdAutorLibro
        
            txtIdAutorLibro.Location = new Point(230, 150);
            txtIdAutorLibro.Name = "txtIdAutorLibro";
            txtIdAutorLibro.Size = new Size(230, 31);
            txtIdAutorLibro.TabIndex = 7;
          
            // lblIdCategoriaLibro
        
            lblIdCategoriaLibro.AutoSize = true;
            lblIdCategoriaLibro.Location = new Point(20, 193);
            lblIdCategoriaLibro.Name = "lblIdCategoriaLibro";
            lblIdCategoriaLibro.Size = new Size(120, 25);
            lblIdCategoriaLibro.TabIndex = 8;
            lblIdCategoriaLibro.Text = "ID Categoría:";
           
            // txtIdCategoriaLibro
         
            txtIdCategoriaLibro.Location = new Point(230, 190);
            txtIdCategoriaLibro.Name = "txtIdCategoriaLibro";
            txtIdCategoriaLibro.Size = new Size(230, 31);
            txtIdCategoriaLibro.TabIndex = 9;
          
            // lblIdEditorialLibro
          
            lblIdEditorialLibro.AutoSize = true;
            lblIdEditorialLibro.Location = new Point(20, 233);
            lblIdEditorialLibro.Name = "lblIdEditorialLibro";
            lblIdEditorialLibro.Size = new Size(109, 25);
            lblIdEditorialLibro.TabIndex = 10;
            lblIdEditorialLibro.Text = "ID Editorial:";
           
            // txtIdEditorialLibro
           
            txtIdEditorialLibro.Location = new Point(230, 230);
            txtIdEditorialLibro.Name = "txtIdEditorialLibro";
            txtIdEditorialLibro.Size = new Size(230, 31);
            txtIdEditorialLibro.TabIndex = 11;
         
            // lblAnioPublicacion
         
            lblAnioPublicacion.AutoSize = true;
            lblAnioPublicacion.Location = new Point(20, 273);
            lblAnioPublicacion.Name = "lblAnioPublicacion";
            lblAnioPublicacion.Size = new Size(177, 25);
            lblAnioPublicacion.TabIndex = 12;
            lblAnioPublicacion.Text = "Año de publicación:";
          
            // txtAnioPublicacion
         
            txtAnioPublicacion.Location = new Point(230, 270);
            txtAnioPublicacion.MaxLength = 4;
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(100, 31);
            txtAnioPublicacion.TabIndex = 13;
           
            // chkEstadoLibro
          
            chkEstadoLibro.AutoSize = true;
            chkEstadoLibro.Location = new Point(230, 318);
            chkEstadoLibro.Name = "chkEstadoLibro";
            chkEstadoLibro.Size = new Size(118, 29);
            chkEstadoLibro.TabIndex = 14;
            chkEstadoLibro.Text = "Disponible";
            chkEstadoLibro.UseVisualStyleBackColor = true;
        
            // pnlFormularioBase
          
            pnlFormularioBase.Controls.Add(lblTituloLibro);
            pnlFormularioBase.Controls.Add(txtTituloLibro);
            pnlFormularioBase.Controls.Add(lblIsbn);
            pnlFormularioBase.Controls.Add(txtIsbn);
            pnlFormularioBase.Controls.Add(lblIdAutorLibro);
            pnlFormularioBase.Controls.Add(txtIdAutorLibro);
            pnlFormularioBase.Controls.Add(lblIdCategoriaLibro);
            pnlFormularioBase.Controls.Add(txtIdCategoriaLibro);
            pnlFormularioBase.Controls.Add(lblIdEditorialLibro);
            pnlFormularioBase.Controls.Add(txtIdEditorialLibro);
            pnlFormularioBase.Controls.Add(lblAnioPublicacion);
            pnlFormularioBase.Controls.Add(txtAnioPublicacion);
            pnlFormularioBase.Controls.Add(chkEstadoLibro);
          
            // FrmLibro
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmLibro";
            Text = "FrmLibro";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }


        private Label lblTituloLibro;
        private TextBox txtTituloLibro;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private Label lblIdAutorLibro;
        private TextBox txtIdAutorLibro;
        private Label lblIdCategoriaLibro;
        private TextBox txtIdCategoriaLibro;
        private Label lblIdEditorialLibro;
        private TextBox txtIdEditorialLibro;
        private Label lblAnioPublicacion;
        private TextBox txtAnioPublicacion;
        private CheckBox chkEstadoLibro;
    }
}