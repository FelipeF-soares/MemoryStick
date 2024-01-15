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
    public partial class UserControlAddNewWord : UserControl
    {
        public UserControlAddNewWord()
        {
            InitializeComponent();
        }

        private void buttonAddNewWord_Click(object sender, EventArgs e)
        {
            string wordInPortuguese = textBoxWordInPortuguese.Text;
            string wordInOtherLanguage = textBoxOtherLanguage.Text;
            AccessFiles accessFiles = new AccessFiles();
            CapitalizedString capitalized = new CapitalizedString(wordInPortuguese, wordInOtherLanguage);
            var note = capitalized.OrganizeString();
            accessFiles.AddNewWordInFile(note);
            ClearTextBox();

        }

        private void ClearTextBox()
        {
            textBoxWordInPortuguese.Text = string.Empty;
            textBoxOtherLanguage.Text = string.Empty;
        }

    }
}
