namespace SystemReporter.Frontend
{
    partial class ReportWizard
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.TemplateSelect = new System.Windows.Forms.ComboBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterSelect = new System.Windows.Forms.ComboBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputSelect = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 14);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(40, 13);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "Nazwa";
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(15, 30);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(257, 20);
            this.FileNameInput.TabIndex = 2;
            // 
            // TemplateSelect
            // 
            this.TemplateSelect.FormattingEnabled = true;
            this.TemplateSelect.Location = new System.Drawing.Point(15, 78);
            this.TemplateSelect.Name = "TemplateSelect";
            this.TemplateSelect.Size = new System.Drawing.Size(257, 21);
            this.TemplateSelect.TabIndex = 3;
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(12, 62);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(45, 13);
            this.TemplateLabel.TabIndex = 4;
            this.TemplateLabel.Text = "Szablon";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 112);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(23, 13);
            this.FilterLabel.TabIndex = 6;
            this.FilterLabel.Text = "Filtr";
            // 
            // FilterSelect
            // 
            this.FilterSelect.FormattingEnabled = true;
            this.FilterSelect.Location = new System.Drawing.Point(15, 128);
            this.FilterSelect.Name = "FilterSelect";
            this.FilterSelect.Size = new System.Drawing.Size(257, 21);
            this.FilterSelect.TabIndex = 5;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 161);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(99, 13);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "Ścieżka Wyjściowa";
            // 
            // OutputSelect
            // 
            this.OutputSelect.FormattingEnabled = true;
            this.OutputSelect.Location = new System.Drawing.Point(15, 177);
            this.OutputSelect.Name = "OutputSelect";
            this.OutputSelect.Size = new System.Drawing.Size(257, 21);
            this.OutputSelect.TabIndex = 7;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(15, 212);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(125, 37);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Utwórz";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.OnCreate);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(144, 212);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 37);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Wróć";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.OnReturn);
            // 
            // ReportWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputSelect);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterSelect);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.TemplateSelect);
            this.Controls.Add(this.FileNameInput);
            this.Controls.Add(this.FileNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportWizard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator Raportu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameInput;
        private System.Windows.Forms.ComboBox TemplateSelect;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ComboBox FilterSelect;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ComboBox OutputSelect;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button BackButton;
    }
}