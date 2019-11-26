using MarkedNote.Domain.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Contracts.V1.Responses
{
    public class NotesResponse
    {
        public ICollection<NotesDto> notes { get; set; }
    }
}
