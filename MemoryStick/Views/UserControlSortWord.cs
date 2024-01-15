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
        public UserControlSortWord()
        {
            InitializeComponent();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {

        }

        private void UserControlSortWord_Load(object sender, EventArgs e)
        {
            ClearTextBox();
            AccessFiles files = new AccessFiles();
            var notes = files.GetAllNotes();
            SortNote sortNote = new SortNote(notes);
            var note = sortNote.NoteRandom();
            textBoxWordInPortuguese.Text = note.WordInPortuguese;
        }

        private void ClearTextBox()
        {
            textBoxTranslation.Text = string.Empty;
            textBoxWordInPortuguese.Text = string.Empty;
        }
    }
}
