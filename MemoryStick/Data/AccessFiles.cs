using MemoryStick.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStick.Data;

public class AccessFiles
{
    private string path = "C:\\MemoryStickWords\\";
    private string memoryStickFile = "C:\\MemoryStickWords\\memoryStickFile.json";

    public AccessFiles()
    {
        try
        {
            if(!(Directory.Exists(path))) 
            {
                 Directory.CreateDirectory(path);
            }
            if (!(File.Exists(memoryStickFile)))
            {
                File.WriteAllText(memoryStickFile, "[]");
            }
            
        }
        catch (Exception ex) 
        {
            throw new Exception($"ERRO!!!\nErro ao Criar Diretorio: ${ex.Message}");
        }
    }

    public void AddNewWordInFile(Note note)
    {
        List<Note>notes = new List<Note>();
        
        try
        {
            notes = GetAllNotes();
            notes.Add(note);
            string noteJson = JsonConvert.SerializeObject(notes);
            File.WriteAllText(memoryStickFile, noteJson); 
        }
        catch(Exception ex)
        {
            throw new Exception($"ERRO!!!\nErro ao Criar New Word: ${ex.Message}");
        }

    }

    public List<Note> GetAllNotes()
    { 
        List<Note> notes = new List<Note>();
        string notesJson;
        try
        {
            notesJson = File.ReadAllText(memoryStickFile);
            notes = JsonConvert.DeserializeObject<List<Note>>(notesJson);
            return notes;
        }
        catch(Exception ex)
        {
            throw new Exception($"ERRO!!!\nErro ao Busca os arquivos: ${ex.Message}");
        }
    }
}
