using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MarkedNote.Models;
using Microsoft.AspNetCore.Identity;

namespace MarkedNote.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Note>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("AuthorId"));
            ////-----------------
            //modelBuilder.Entity<NoteComments>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("AuthorId").IsRequired());
            ////-----------------
            //modelBuilder.Entity<SharedWith>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("Reciever"));
            ////-----------------
            //modelBuilder.Entity<FriendsList>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("MainUserId"));
            //modelBuilder.Entity<FriendsList>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("FriendId"));
            ////-----------------
            //modelBuilder.Entity<FriendRequest>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("SenderId"));
            //modelBuilder.Entity<FriendRequest>(b =>
            //b.HasOne<IdentityUser>()
            //.WithMany()
            //.HasForeignKey("RecieverId"));
        }

        //public DbSet<User> User { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Tags> Tags { get; set; }
        //public DbSet<NoteContent> NoteContent { get; set; }
        //public DbSet<NoteLinks> NoteLinks { get; set; }
        public DbSet<NoteComments> NoteComments { get; set; }
        public DbSet<SharedWith> SharedWith { get; set; }
        public DbSet<FriendsList> FriendsList { get; set; }
        public DbSet<FriendRequest> FriendRequest { get; set; }



    }
}
