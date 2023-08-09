namespace SystemReporter.Frontend
{
    partial class FilterWizard
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
            this.BackButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputSelect = new System.Windows.Forms.ComboBox();
            this.FilterSelect = new System.Windows.Forms.ComboBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputSelect = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(144, 166);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 37);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Wróć";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(15, 166);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(125, 37);
            this.FilterButton.TabIndex = 18;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 115);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(99, 13);
            this.OutputLabel.TabIndex = 17;
            this.OutputLabel.Text = "Ścieżka Wyjściowa";
            // 
            // OutputSelect
            // 
            this.OutputSelect.FormattingEnabled = true;
            this.OutputSelect.Location = new System.Drawing.Point(15, 131);
            this.OutputSelect.Name = "OutputSelect";
            this.OutputSelect.Size = new System.Drawing.Size(257, 21);
            this.OutputSelect.TabIndex = 16;
            // 
            // FilterSelect
            // 
            this.FilterSelect.FormattingEnabled = true;
            this.FilterSelect.Location = new System.Drawing.Point(15, 82);
            this.FilterSelect.Name = "FilterSelect";
            this.FilterSelect.Size = new System.Drawing.Size(257, 21);
            this.FilterSelect.TabIndex = 15;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 16);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(86, 13);
            this.InputLabel.TabIndex = 14;
            this.InputLabel.Text = "Ścieżka Raportu";
            // 
            // InputSelect
            // 
            this.InputSelect.FormattingEnabled = true;
            this.InputSelect.Location = new System.Drawing.Point(15, 32);
            this.InputSelect.Name = "InputSelect";
            this.InputSelect.Size = new System.Drawing.Size(257, 21);
            this.InputSelect.TabIndex = 13;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 66);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(23, 13);
            this.FilterLabel.TabIndex = 20;
            this.FilterLabel.Text = "Filtr";
            // 
            // FilterWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputSelect);
            this.Controls.Add(this.FilterSelect);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilterWizard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrujący Pomocnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ComboBox OutputSelect;
        private System.Windows.Forms.ComboBox FilterSelect;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.ComboBox InputSelect;
        private System.Windows.Forms.Label FilterLabel;
    }
}