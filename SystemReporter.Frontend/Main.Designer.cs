namespace SystemReporter.Frontend
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FastReport = new System.Windows.Forms.Button();
            this.NewReport = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.NewFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FastReport
            // 
            this.FastReport.Location = new System.Drawing.Point(12, 12);
            this.FastReport.Name = "FastReport";
            this.FastReport.Size = new System.Drawing.Size(128, 37);
            this.FastReport.TabIndex = 0;
            this.FastReport.Text = "Szybki Raport";
            this.FastReport.UseVisualStyleBackColor = true;
            this.FastReport.Click += new System.EventHandler(this.OnFastReport);
            // 
            // NewReport
            // 
            this.NewReport.Location = new System.Drawing.Point(146, 12);
            this.NewReport.Name = "NewReport";
            this.NewReport.Size = new System.Drawing.Size(128, 37);
            this.NewReport.TabIndex = 1;
            this.NewReport.Text = "Utwórz Raport";
            this.NewReport.UseVisualStyleBackColor = true;
            this.NewReport.Click += new System.EventHandler(this.OnReport);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(12, 52);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(128, 37);
            this.Filter.TabIndex = 2;
            this.Filter.Text = "Filtruj Raport";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.OnFilter);
            // 
            // NewFilter
            // 
            this.NewFilter.Location = new System.Drawing.Point(146, 52);
            this.NewFilter.Name = "NewFilter";
            this.NewFilter.Size = new System.Drawing.Size(128, 37);
            this.NewFilter.TabIndex = 3;
            this.NewFilter.Text = "Utwórz Filtr";
            this.NewFilter.UseVisualStyleBackColor = true;
            this.NewFilter.Click += new System.EventHandler(this.OnNewFilter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.NewFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.NewReport);
            this.Controls.Add(this.FastReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systemowy Raporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FastReport;
        private System.Windows.Forms.Button NewReport;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button NewFilter;
    }
}

