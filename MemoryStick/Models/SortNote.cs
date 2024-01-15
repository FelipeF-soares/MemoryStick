using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStick.Models;

public class SortNote
{
    List<Note> _notes;
    public SortNote(List<Note> notes)
    {
        _notes = notes;
    }

    public Note NoteRandom()
    {
        try
        {
            Random random = new Random();
            int index = random.Next(_notes.Count);
            return _notes[index];
        }
        catch (Exception)
        {
            throw new Exception("The list is empty! Add new words.");
        }
       
    }
}
