using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkedNote.Models
{
    public partial class NoteLinks
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Note")]
        public int NoteId { get; set; }
        public string Link { get; set; }
        //public string LinkComment { get; set; }

        public virtual Note Note { get; set; }
    }
}
