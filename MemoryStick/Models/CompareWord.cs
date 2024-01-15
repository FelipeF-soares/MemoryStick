using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStick.Models;

public static class CompareWord
{

    public static bool IsEquals(string wordInPortuguese, string translation)
    {
        string word1 = wordInPortuguese.ToLower().Trim();
        string word2 = translation.ToLower().Trim();
        if (word2 == "Enter your word here!")
        {
            word2 = string.Empty;
        }
        if (word2 != string.Empty)
        {
            if (string.Equals(word1,word2))
            {
                
                return true;
            }
            return false;
        }
        else
        {
            throw new NotImplementedException("Translation field is empty.");
        }
        
    }

    public static int Hits(bool hit, int totalHits,string wordCorrect)
    {
        if (hit) 
        {
            MessageBox.Show("GREAT!!!!\nVERY GOOD");
            return ++totalHits; 
        }
        MessageBox.Show($"I AM SORRY,  BUT THE WORD IS WRONG.\nTHE CORRECT WORD IS {wordCorrect}");
        return totalHits;
    }
}
