using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkedNote.Models
{
    public partial class Tags
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Note")]
        public int NoteId { get; set; }
        public string Tag { get; set; }

        public virtual Note Note { get; set; }
    }
}
