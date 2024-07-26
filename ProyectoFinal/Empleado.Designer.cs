namespace ProyectoFinal
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            lblTexto = new Label();
            saveDialog = new SaveFileDialog();
            btnExportar = new Button();
            lblEmpleado2 = new Label();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AccessibleRole = AccessibleRole.None;
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(30, 97);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(85, 20);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Empleado1";
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "planillaExcel";
            saveDialog.Filter = "Archivo de Excel 2007+ |*.xlsx";
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.Location = new Point(549, 32);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblEmpleado2
            // 
            lblEmpleado2.AutoSize = true;
            lblEmpleado2.Location = new Point(30, 143);
            lblEmpleado2.Name = "lblEmpleado2";
            lblEmpleado2.Size = new Size(89, 20);
            lblEmpleado2.TabIndex = 2;
            lblEmpleado2.Text = "Empleado 2";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 239);
            Controls.Add(lblEmpleado2);
            Controls.Add(btnExportar);
            Controls.Add(lblTexto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private SaveFileDialog saveDialog;
        private Button btnExportar;
        private Label lblEmpleado2;
    }
}