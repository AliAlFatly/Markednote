using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MarkedNote.Models
{
    public partial class FriendsList
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MainUserId { get; set; }
        public string FriendId { get; set; }

        [ForeignKey(nameof(MainUserId))]
        public virtual IdentityUser MainUser { get; set; }
        [ForeignKey(nameof(FriendId))]
        public virtual IdentityUser Sender { get; set; }

    }
}
