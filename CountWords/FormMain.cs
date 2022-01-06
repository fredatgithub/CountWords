using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CountWords
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void ButtonExtract_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxSource.Text))
      {
        MessageBox.Show("La source ne peut pas être vide");
        return;
      }

      var listOfWords = new List<string>();
      string source = textBoxSource.Text;
      var tableau = source.Split(' ');
      progressBarMain.Minimum = 0;
      progressBarMain.Maximum = tableau.Length;
      progressBarMain.Value = progressBarMain.Minimum;
      int i = 0;
      foreach (var word in tableau)
      {
        string word2 = RemoveBadCharacters(word);
        if (!listOfWords.Contains(word2.ToLower()) && word2 != string.Empty)
        {
          listOfWords.Add(word2.ToLower());
        }

        progressBarMain.Value = i++;
      }

      progressBarMain.Value = progressBarMain.Minimum;
      progressBarMain.Maximum = listOfWords.Count;
      i = 0;
      foreach (var word in listOfWords)
      {
        if (!listBoxDico.Items.Contains(word.ToLower()))
        {
          listBoxDico.Items.Add(word.ToLower());
        }
        
        progressBarMain.Value = i++;
      }

      progressBarMain.Value = progressBarMain.Minimum;
    }

    private string RemoveBadCharacters(string word)
    {
      string result = string.Empty;
      result = word.Trim('.');
      result = result.Trim(',');
      result = result.Trim('"');
      result = result.TrimStart('"');
      result = result.Trim('!');
      result = result.Trim('?');
      result = result.Trim('=');
      result = result.TrimEnd(';');
      if (result == " " || result.Length == 1)
      {
        result = string.Empty;
      }

      if (result.StartsWith("\""))
      {
        result = result.Substring(1);
      }

      return result;
    }

    private void ButtonSaveFile_Click(object sender, EventArgs e)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter("dico.txt"))
        {
          foreach (string word in listBoxDico.Items)
          {
            sw.WriteLine(word);
          }
        }

        MessageBox.Show("Un fichier dico.txt a été enregistré.");
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
      }
    }

    private void ButtonRemove_Click(object sender, EventArgs e)
    {
      if (listBoxDico.SelectedIndex != -1)
      {
        listBoxDico.Items.RemoveAt(listBoxDico.SelectedIndex);
      }
      else
      {
        MessageBox.Show("Vous devez sélectionner un caractère");
      }
    }
  }
}
