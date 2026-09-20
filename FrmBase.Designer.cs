// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmBase
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlFormularioBase = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lblId);
            pnlFormularioBase.Controls.Add(txtId);
            pnlFormularioBase.Dock = DockStyle.Fill;
            pnlFormularioBase.Location = new Point(0, 0);
            pnlFormularioBase.Name = "pnlFormularioBase";
            pnlFormularioBase.Size = new Size(800, 450);
            pnlFormularioBase.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(230, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(230, 31);
            txtId.TabIndex = 1;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlFormularioBase);
            Name = "FrmBase";
            Text = "FrmBase";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnlFormularioBase;
        protected Label lblId;
        protected TextBox txtId;
    }
}