using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Domain.V1
{
    public class NotesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }

        public ICollection<string> Tags { get; set; }

    }
}
