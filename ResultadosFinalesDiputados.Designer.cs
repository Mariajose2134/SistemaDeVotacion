namespace SistemaDeVotacion
{
    partial class ResultadosFinalesDiputados
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
            this.btnResultadoElecciones = new System.Windows.Forms.Button();
            this.lsvDiputados = new System.Windows.Forms.ListView();
            this.clhPartidosPoliticos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhvotos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblResultadoDiputados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResultadoElecciones
            // 
            this.btnResultadoElecciones.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadoElecciones.Location = new System.Drawing.Point(791, 572);
            this.btnResultadoElecciones.Name = "btnResultadoElecciones";
            this.btnResultadoElecciones.Size = new System.Drawing.Size(362, 59);
            this.btnResultadoElecciones.TabIndex = 7;
            this.btnResultadoElecciones.Text = "&RESULTADOS FINALES  ";
            this.btnResultadoElecciones.UseVisualStyleBackColor = true;
            // 
            // lsvDiputados
            // 
            this.lsvDiputados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhPartidosPoliticos,
            this.clhvotos});
            this.lsvDiputados.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDiputados.FullRowSelect = true;
            this.lsvDiputados.GridLines = true;
            this.lsvDiputados.HideSelection = false;
            this.lsvDiputados.Location = new System.Drawing.Point(302, 175);
            this.lsvDiputados.Name = "lsvDiputados";
            this.lsvDiputados.Size = new System.Drawing.Size(606, 302);
            this.lsvDiputados.TabIndex = 6;
            this.lsvDiputados.UseCompatibleStateImageBehavior = false;
            this.lsvDiputados.View = System.Windows.Forms.View.Details;
            // 
            // clhPartidosPoliticos
            // 
            this.clhPartidosPoliticos.Text = "PARTIDOS POLITICOS";
            this.clhPartidosPoliticos.Width = 300;
            // 
            // clhvotos
            // 
            this.clhvotos.Text = "CANTIDDAD DE VOTOS";
            this.clhvotos.Width = 300;
            // 
            // lblResultadoDiputados
            // 
            this.lblResultadoDiputados.AutoSize = true;
            this.lblResultadoDiputados.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDiputados.Location = new System.Drawing.Point(296, 59);
            this.lblResultadoDiputados.Name = "lblResultadoDiputados";
            this.lblResultadoDiputados.Size = new System.Drawing.Size(576, 36);
            this.lblResultadoDiputados.TabIndex = 8;
            this.lblResultadoDiputados.Text = "RESULTADOS FINALES DIPUTADOS";
            // 
            // ResultadosFinalesDiputados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 716);
            this.Controls.Add(this.lblResultadoDiputados);
            this.Controls.Add(this.btnResultadoElecciones);
            this.Controls.Add(this.lsvDiputados);
            this.Name = "ResultadosFinalesDiputados";
            this.Text = "ResultadosFinalesDiputados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultadoElecciones;
        private System.Windows.Forms.ListView lsvDiputados;
        private System.Windows.Forms.ColumnHeader clhPartidosPoliticos;
        private System.Windows.Forms.ColumnHeader clhvotos;
        private System.Windows.Forms.Label lblResultadoDiputados;
    }
}