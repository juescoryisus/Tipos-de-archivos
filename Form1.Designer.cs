namespace Archivoss
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialIndexadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoDirectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 36);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secuencialToolStripMenuItem,
            this.secuencialIndexadoToolStripMenuItem,
            this.accesoDirectoToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // secuencialToolStripMenuItem
            // 
            this.secuencialToolStripMenuItem.Name = "secuencialToolStripMenuItem";
            this.secuencialToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.secuencialToolStripMenuItem.Text = "Secuencial";
            this.secuencialToolStripMenuItem.Click += new System.EventHandler(this.secuencialToolStripMenuItem_Click);
            // 
            // secuencialIndexadoToolStripMenuItem
            // 
            this.secuencialIndexadoToolStripMenuItem.Name = "secuencialIndexadoToolStripMenuItem";
            this.secuencialIndexadoToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.secuencialIndexadoToolStripMenuItem.Text = "Secuencial indexado";
            this.secuencialIndexadoToolStripMenuItem.Click += new System.EventHandler(this.secuencialIndexadoToolStripMenuItem_Click);
            // 
            // accesoDirectoToolStripMenuItem
            // 
            this.accesoDirectoToolStripMenuItem.Name = "accesoDirectoToolStripMenuItem";
            this.accesoDirectoToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.accesoDirectoToolStripMenuItem.Text = "Acceso directo";
            this.accesoDirectoToolStripMenuItem.Click += new System.EventHandler(this.accesoDirectoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presionar con click derecho cualquier parte del cuadro para \r\n             ver la" +
    "s opciones de los tipos de archivos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 205);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencialIndexadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoDirectoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

