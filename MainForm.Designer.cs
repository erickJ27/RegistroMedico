namespace ProyectoFinal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTipoDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rCargosToolStripMenuItem,
            this.registroDeAnalisisToolStripMenuItem,
            this.registroDeTipoDeAnalisisToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.usuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // rCargosToolStripMenuItem
            // 
            this.rCargosToolStripMenuItem.Name = "rCargosToolStripMenuItem";
            this.rCargosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.rCargosToolStripMenuItem.Text = "Registro de Cargos";
            this.rCargosToolStripMenuItem.Click += new System.EventHandler(this.RCargosToolStripMenuItem_Click);
            // 
            // registroDeAnalisisToolStripMenuItem
            // 
            this.registroDeAnalisisToolStripMenuItem.Name = "registroDeAnalisisToolStripMenuItem";
            this.registroDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.registroDeAnalisisToolStripMenuItem.Text = "Registro de Analisis";
            this.registroDeAnalisisToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeAnalisisToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUsuariosToolStripMenuItem,
            this.cCargosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cUsuariosToolStripMenuItem
            // 
            this.cUsuariosToolStripMenuItem.Name = "cUsuariosToolStripMenuItem";
            this.cUsuariosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cUsuariosToolStripMenuItem.Text = "cUsuarios";
            this.cUsuariosToolStripMenuItem.Click += new System.EventHandler(this.CUsuariosToolStripMenuItem_Click);
            // 
            // cCargosToolStripMenuItem
            // 
            this.cCargosToolStripMenuItem.Name = "cCargosToolStripMenuItem";
            this.cCargosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cCargosToolStripMenuItem.Text = "cCargos";
            this.cCargosToolStripMenuItem.Click += new System.EventHandler(this.CCargosToolStripMenuItem_Click);
            // 
            // registroDeTipoDeAnalisisToolStripMenuItem
            // 
            this.registroDeTipoDeAnalisisToolStripMenuItem.Name = "registroDeTipoDeAnalisisToolStripMenuItem";
            this.registroDeTipoDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.registroDeTipoDeAnalisisToolStripMenuItem.Text = "Registro de Tipo de Analisis";
            this.registroDeTipoDeAnalisisToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeTipoDeAnalisisToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Consulta Medica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTipoDeAnalisisToolStripMenuItem;
    }
}

