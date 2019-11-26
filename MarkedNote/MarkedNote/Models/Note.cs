using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MarkedNote.Models
{

    public partial class Note
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? Date { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public string Link { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        //public virtual ICollection<NoteLinks> NoteLinks { get; set; }
        public virtual ICollection<NoteComments> NoteComments { get; set; }
        public virtual ICollection<SharedWith> SharedUsers { get; set; }
    }
}
