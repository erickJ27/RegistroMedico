namespace Sistema_Consulta.UI.Registros
{
    partial class rAnalisis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAnalisis));
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoAnalisisComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(67, 13);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(86, 20);
            this.IdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(67, 48);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // UsuarioComboBox
            // 
            this.UsuarioComboBox.FormattingEnabled = true;
            this.UsuarioComboBox.Location = new System.Drawing.Point(67, 85);
            this.UsuarioComboBox.Name = "UsuarioComboBox";
            this.UsuarioComboBox.Size = new System.Drawing.Size(282, 21);
            this.UsuarioComboBox.TabIndex = 5;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.RemoverButton);
            this.GroupBox.Controls.Add(this.AgregarButton);
            this.GroupBox.Controls.Add(this.DetalleDataGridView);
            this.GroupBox.Controls.Add(this.ResultadoTextBox);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.TipoAnalisisComboBox);
            this.GroupBox.Location = new System.Drawing.Point(12, 123);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(337, 275);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Agregar Analisis";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = global::Sistema_Consulta.Properties.Resources.Close_2_icon;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(9, 235);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(105, 31);
            this.RemoverButton.TabIndex = 6;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(302, 41);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(22, 23);
            this.AgregarButton.TabIndex = 5;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(9, 79);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(316, 150);
            this.DetalleDataGridView.TabIndex = 4;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(173, 41);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(123, 20);
            this.ResultadoTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Analisis";
            // 
            // TipoAnalisisComboBox
            // 
            this.TipoAnalisisComboBox.FormattingEnabled = true;
            this.TipoAnalisisComboBox.Location = new System.Drawing.Point(9, 40);
            this.TipoAnalisisComboBox.Name = "TipoAnalisisComboBox";
            this.TipoAnalisisComboBox.Size = new System.Drawing.Size(158, 21);
            this.TipoAnalisisComboBox.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Sistema_Consulta.Properties.Resources.search2_icon;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(159, 6);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 36);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Sistema_Consulta.Properties.Resources.new_file_icon;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(21, 415);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 37);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Sistema_Consulta.Properties.Resources.Save2_icon;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(145, 415);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 37);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Sistema_Consulta.Properties.Resources.Button_Close_icon;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(261, 415);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 37);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 465);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.UsuarioComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Analisis Medico";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UsuarioComboBox;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoAnalisisComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}