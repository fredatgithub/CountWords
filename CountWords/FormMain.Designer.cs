namespace CountWords
{
  partial class FormMain
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
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.buttonExtract = new System.Windows.Forms.Button();
      this.buttonSaveFile = new System.Windows.Forms.Button();
      this.progressBarMain = new System.Windows.Forms.ProgressBar();
      this.listBoxDico = new System.Windows.Forms.ListBox();
      this.buttonRemove = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxSource
      // 
      this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.textBoxSource.Location = new System.Drawing.Point(12, 67);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxSource.Size = new System.Drawing.Size(209, 334);
      this.textBoxSource.TabIndex = 0;
      // 
      // buttonExtract
      // 
      this.buttonExtract.Location = new System.Drawing.Point(233, 108);
      this.buttonExtract.Name = "buttonExtract";
      this.buttonExtract.Size = new System.Drawing.Size(75, 23);
      this.buttonExtract.TabIndex = 2;
      this.buttonExtract.Text = "Extract";
      this.buttonExtract.UseVisualStyleBackColor = true;
      this.buttonExtract.Click += new System.EventHandler(this.ButtonExtract_Click);
      // 
      // buttonSaveFile
      // 
      this.buttonSaveFile.Location = new System.Drawing.Point(233, 337);
      this.buttonSaveFile.Name = "buttonSaveFile";
      this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
      this.buttonSaveFile.TabIndex = 3;
      this.buttonSaveFile.Text = "Save";
      this.buttonSaveFile.UseVisualStyleBackColor = true;
      this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
      // 
      // progressBarMain
      // 
      this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBarMain.Location = new System.Drawing.Point(0, 427);
      this.progressBarMain.Name = "progressBarMain";
      this.progressBarMain.Size = new System.Drawing.Size(588, 23);
      this.progressBarMain.TabIndex = 4;
      // 
      // listBoxDico
      // 
      this.listBoxDico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listBoxDico.FormattingEnabled = true;
      this.listBoxDico.Location = new System.Drawing.Point(321, 67);
      this.listBoxDico.Name = "listBoxDico";
      this.listBoxDico.Size = new System.Drawing.Size(231, 329);
      this.listBoxDico.Sorted = true;
      this.listBoxDico.TabIndex = 5;
      // 
      // buttonRemove
      // 
      this.buttonRemove.Location = new System.Drawing.Point(233, 137);
      this.buttonRemove.Name = "buttonRemove";
      this.buttonRemove.Size = new System.Drawing.Size(75, 23);
      this.buttonRemove.TabIndex = 6;
      this.buttonRemove.Text = "Remove ->";
      this.buttonRemove.UseVisualStyleBackColor = true;
      this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(588, 450);
      this.Controls.Add(this.buttonRemove);
      this.Controls.Add(this.listBoxDico);
      this.Controls.Add(this.progressBarMain);
      this.Controls.Add(this.buttonSaveFile);
      this.Controls.Add(this.buttonExtract);
      this.Controls.Add(this.textBoxSource);
      this.Name = "FormMain";
      this.Text = "Create dictionary";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Button buttonExtract;
    private System.Windows.Forms.Button buttonSaveFile;
    private System.Windows.Forms.ProgressBar progressBarMain;
    private System.Windows.Forms.ListBox listBoxDico;
    private System.Windows.Forms.Button buttonRemove;
  }
}

