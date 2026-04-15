namespace SistemaDeVotacion
{
    partial class frmConteoDeVotos
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
            this.lblResultadoDiputados = new System.Windows.Forms.Label();
            this.lblConteoVotos = new System.Windows.Forms.Label();
            this.lsvConteoVotos = new System.Windows.Forms.ListView();
            this.clhSanJosé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAlajuela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCartago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHeredia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGuanacaste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPuntarenas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLimon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnResultadosPresidente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultadoDiputados
            // 
            this.lblResultadoDiputados.AutoSize = true;
            this.lblResultadoDiputados.Location = new System.Drawing.Point(65, -51);
            this.lblResultadoDiputados.Name = "lblResultadoDiputados";
            this.lblResultadoDiputados.Size = new System.Drawing.Size(289, 20);
            this.lblResultadoDiputados.TabIndex = 4;
            this.lblResultadoDiputados.Text = "RESULTADOS FINALES DIPUTADOS";
            // 
            // lblConteoVotos
            // 
            this.lblConteoVotos.AutoSize = true;
            this.lblConteoVotos.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteoVotos.Location = new System.Drawing.Point(461, 33);
            this.lblConteoVotos.Name = "lblConteoVotos";
            this.lblConteoVotos.Size = new System.Drawing.Size(332, 36);
            this.lblConteoVotos.TabIndex = 7;
            this.lblConteoVotos.Text = "CONTEO DE VOTOS";
            // 
            // lsvConteoVotos
            // 
            this.lsvConteoVotos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhSanJosé,
            this.clhAlajuela,
            this.clhCartago,
            this.clhHeredia,
            this.clhGuanacaste,
            this.clhPuntarenas,
            this.clhLimon});
            this.lsvConteoVotos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvConteoVotos.FullRowSelect = true;
            this.lsvConteoVotos.GridLines = true;
            this.lsvConteoVotos.HideSelection = false;
            this.lsvConteoVotos.Location = new System.Drawing.Point(26, 100);
            this.lsvConteoVotos.Name = "lsvConteoVotos";
            this.lsvConteoVotos.Size = new System.Drawing.Size(1321, 435);
            this.lsvConteoVotos.TabIndex = 6;
            this.lsvConteoVotos.UseCompatibleStateImageBehavior = false;
            this.lsvConteoVotos.View = System.Windows.Forms.View.Details;
            // 
            // clhSanJosé
            // 
            this.clhSanJosé.Text = "SAN JOSÉ";
            this.clhSanJosé.Width = 190;
            // 
            // clhAlajuela
            // 
            this.clhAlajuela.Text = "ALAJUELA";
            this.clhAlajuela.Width = 190;
            // 
            // clhCartago
            // 
            this.clhCartago.Text = "CARTAGO";
            this.clhCartago.Width = 190;
            // 
            // clhHeredia
            // 
            this.clhHeredia.Text = "HEREDIA";
            this.clhHeredia.Width = 190;
            // 
            // clhGuanacaste
            // 
            this.clhGuanacaste.Text = "GUANACASTE";
            this.clhGuanacaste.Width = 190;
            // 
            // clhPuntarenas
            // 
            this.clhPuntarenas.Text = "PUNTARENAS";
            this.clhPuntarenas.Width = 190;
            // 
            // clhLimon
            // 
            this.clhLimon.Text = "LIMÓN";
            this.clhLimon.Width = 190;
            // 
            // btnResultadosPresidente
            // 
            this.btnResultadosPresidente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadosPresidente.Location = new System.Drawing.Point(826, 569);
            this.btnResultadosPresidente.Name = "btnResultadosPresidente";
            this.btnResultadosPresidente.Size = new System.Drawing.Size(477, 57);
            this.btnResultadosPresidente.TabIndex = 5;
            this.btnResultadosPresidente.Text = "&RESULTADOS PRESIDENTE";
            this.btnResultadosPresidente.UseVisualStyleBackColor = true;
            // 
            // frmConteoDeVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 647);
            this.Controls.Add(this.lblConteoVotos);
            this.Controls.Add(this.lsvConteoVotos);
            this.Controls.Add(this.btnResultadosPresidente);
            this.Controls.Add(this.lblResultadoDiputados);
            this.Name = "frmConteoDeVotos";
            this.Text = "Conteo De Votos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultadoDiputados;
        private System.Windows.Forms.Label lblConteoVotos;
        private System.Windows.Forms.ListView lsvConteoVotos;
        private System.Windows.Forms.ColumnHeader clhSanJosé;
        private System.Windows.Forms.ColumnHeader clhAlajuela;
        private System.Windows.Forms.ColumnHeader clhCartago;
        private System.Windows.Forms.ColumnHeader clhHeredia;
        private System.Windows.Forms.ColumnHeader clhGuanacaste;
        private System.Windows.Forms.ColumnHeader clhPuntarenas;
        private System.Windows.Forms.ColumnHeader clhLimon;
        private System.Windows.Forms.Button btnResultadosPresidente;
    }
}