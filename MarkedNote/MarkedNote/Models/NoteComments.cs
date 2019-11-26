using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MarkedNote.Models
{
    public partial class NoteComments
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Note")]
        public int NoteId { get; set; }
        public string Body { get; set; }
        public DateTime? Date { get; set; }

        public virtual Note Note { get; set; }
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; }
    }
}
