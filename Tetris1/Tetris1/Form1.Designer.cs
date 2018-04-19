namespace Tetris1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.Brique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Location = new System.Drawing.Point(90, 12);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(136, 23);
            this.btnDemarrer.TabIndex = 0;
            this.btnDemarrer.Text = "Démarrer le jeu";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // Brique
            // 
            this.Brique.Location = new System.Drawing.Point(44, 59);
            this.Brique.Name = "Brique";
            this.Brique.Size = new System.Drawing.Size(75, 23);
            this.Brique.TabIndex = 1;
            this.Brique.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Brique);
            this.Controls.Add(this.btnDemarrer);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Button Brique;
    }
}

