using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZadacaEdukos
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Creation { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            Creation = DateTime.Now;
        }
    }

    public class Collections
    {
        public string Author { get; private set; }
        public List<Note> notes;

        public Collections(string author)
        {
            Author = author;
            notes = new List<Note>();
        }

        public void Add(Note note)
        {
            notes.Add(note);
        }
    }
}
