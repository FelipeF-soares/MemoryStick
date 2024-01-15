using MemoryStick.Data;
using MemoryStick.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStick.Views
{
    public partial class UserControlSortWord : UserControl
    {
        List<Note> notes = new List<Note>();
        Note noteSort = new Note();
        string wordCorrect;
        string translation;
        int numberWords;
        int totalHits = 0;
        public UserControlSortWord()
        {
            InitializeComponent();
            AccessFiles files = new AccessFiles();
            notes = files.GetAllNotes();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            translation = textBoxTranslation.Text;
            try
            {
                bool hit = CompareWord.IsEquals(wordCorrect, translation);
                totalHits = CompareWord.Hits(hit, totalHits, wordCorrect);
                labelTotalHits.Text = totalHits.ToString();
                notes.Remove(noteSort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearTextBox();
                UserControlSortWord_Load(sender, e);
            }
        }

        private void UserControlSortWord_Load(object sender, EventArgs e)
        {
            try
            {
                ClearTextBox();
                labelTotalHits.Text = totalHits.ToString();
                numberWords = notes.Count;
                labelTotalWords.Text = numberWords.ToString();
                SortNote sortNote = new SortNote(notes);
                noteSort = sortNote.NoteRandom();
                wordCorrect = noteSort.WordInOtherIdioms;
                textBoxWordInPortuguese.Text = noteSort.WordInPortuguese;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBox()
        {
            textBoxTranslation.Text = string.Empty;
            textBoxWordInPortuguese.Text = string.Empty;
        }
    }
}
