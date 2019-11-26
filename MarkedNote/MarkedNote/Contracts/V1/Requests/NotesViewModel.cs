using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Domain.V1
{
    public class NotesViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string Links { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
