using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MarkedNote.Models
{
    public partial class SharedWith
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RecieverId { get; set; }

        [ForeignKey(nameof(RecieverId))]
        public virtual IdentityUser Reciever { get; set; }
        public virtual Note Note { get; set; }
    }
}
