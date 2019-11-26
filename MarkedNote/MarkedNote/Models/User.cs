using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkedNote.Models
{
    public partial class User
    {
        [Key]
        public string Username { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<NoteComments> NoteComments { get; set; }
        public virtual ICollection<SharedWith> RecievedNotes { get; set; }
        public virtual ICollection<FriendsList> Friends { get; set; }
        public virtual ICollection<FriendRequest> SentRequests { get; set; }
        public virtual ICollection<FriendRequest> RecievedRequests { get; set; }
    }
}
