using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStick.Models;

public class CapitalizedString
{
    private string WordInPortuguese { get; set; }
    private string WordInOtherIdioms { get; set; }

    public CapitalizedString(string wordInPortuguese, string wordInOtherIdioms)
    {
        WordInPortuguese = wordInPortuguese;
        WordInOtherIdioms = wordInOtherIdioms;
    }

    public Note OrganizeString()
    {
        Note note = new Note();
        note.WordInPortuguese = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(WordInPortuguese.ToLower());
        note.WordInOtherIdioms = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(WordInOtherIdioms.ToLower());
        return note;
    }
}
