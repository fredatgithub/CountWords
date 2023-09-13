using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CountFileWords.Properties;

namespace CountFileWords
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private Dictionary<string, int> _dico = new Dictionary<string, int>();

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      GetWindowValue();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.textBoxfilePath = textBoxfilePath.Text;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxfilePath.Text = Settings.Default.textBoxfilePath;
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      SaveWindowValue();
    }

    private void ButtonChooseFile_Click(object sender, EventArgs e)
    {
      textBoxfilePath.Text = GetFilename();
      LoadFileContent();
    }

    private string ReadFilename(string filename)
    {
      var result = string.Empty;
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          while (!sr.EndOfStream)
          {
            result += sr.ReadToEnd();
          }
        }
      }
      catch (Exception)
      {
      }

      return result;
    }

    private string GetFilename()
    {
      var result = string.Empty;
      var openFileDialog = new OpenFileDialog();
      //openFileDialog.InitialDirectory = "C:\\"; 
      openFileDialog.Title = "Choisissez un fichier";
      openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        result = openFileDialog.FileName;
      }

      return result;
    }

    private void TextBoxfilePath_TextChanged(object sender, EventArgs e)
    {
      buttonLoadFileContent.Enabled = textBoxfilePath.Text.Length != 0;
    }

    private void ButtonLoadFileContent_Click(object sender, EventArgs e)
    {
      LoadFileContent();
    }

    private void LoadFileContent()
    {
      if (!string.IsNullOrEmpty(textBoxfilePath.Text) && File.Exists(textBoxfilePath.Text))
      {
        textBoxFileContent.Text = ReadFilename(textBoxfilePath.Text);
      }
    }

    private void ButtonCountWords_Click(object sender, EventArgs e)
    {
      listBoxWords.Items.Clear();
      var dico = new Dictionary<string, int>();
      var allWords = textBoxFileContent.Text.Split(' ');
      dico = CountWords(allWords);
      _dico.Clear();
      _dico = dico;
      LoadDicoIntoListBox(dico);
      CountListboxItems();
      EnableButtons();
    }

    private void EnableButtons()
    {
      buttonSortByNumber.Enabled = true;
      buttonSortByWord.Enabled = true;
    }

    private void CountListboxItems()
    {
      labelCountListBoxWords.Text = $"Count: {listBoxWords.Items.Count} word{Plural(listBoxWords.Items.Count)}";
    }

    private string Plural(int number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    private Dictionary<string, int> CountWords(string[] allWords)
    {
      var dico = new Dictionary<string, int>();
      foreach (var word in allWords)
      {
        if (dico.ContainsKey(word))
        {
          dico[word]++;
        }
        else
        {
          dico.Add(word, 1);
        }
      }

      return dico;
    }

    private void LoadDicoIntoListBox(Dictionary<string, int> dico)
    {
      listBoxWords.Items.Clear();
      foreach (var item in dico)
      {
        listBoxWords.Items.Add($"{item.Key} - {item.Value}");
      }
    }

    private void TextBoxFileContent_TextChanged(object sender, EventArgs e)
    {
      buttonCountWords.Enabled = textBoxFileContent.Text.Length != 0;
    }

    private void ButtonSortByWord_Click(object sender, EventArgs e)
    {
      var sortedDico = _dico.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
      LoadDicoIntoListBox(sortedDico);
    }

    private void ButtonSortByNumber_Click(object sender, EventArgs e)
    {
      var sortedDico = _dico.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
      LoadDicoIntoListBox(sortedDico);
    }
  }
}
