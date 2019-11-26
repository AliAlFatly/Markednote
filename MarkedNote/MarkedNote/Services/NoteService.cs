using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkedNote.Data;
using MarkedNote.Domain.V1;
using MarkedNote.Models;
using Microsoft.EntityFrameworkCore;
using MarkedNote.Extentions;

namespace MarkedNote.Services
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;

        public NoteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetNotesAsync(string userId)
        {
            return await _context.Note.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<List<Note>> GetNotesByTagsAsync(string userId, string[] tags)
        {
            var notes = await _context.Note.Where(x => x.UserId == userId).ToListAsync();
            if(tags == null)
            {
                return notes;
            }
            foreach(Note note in notes)
            {
                var notesTags = note.Tags.ToList();
                var Exists = false;
                for (int i = 0; i < tags.Length; i++)
                {
                    foreach(var tag in notesTags)
                    {
                        if(!string.IsNullOrEmpty(tags[i]) && tag.Tag == tags[i])
                        {
                            Exists = true;
                            i = tags.Length;
                        }
                    }
                }
                if (!Exists)
                {
                    notes.Remove(note);
                }
            }
           
            return notes;
            
        }

        public async Task<Note> GetNotesByIdAsync(int id)
        {
            return await _context.Note.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CreateNotesAsync(NotesViewModel newNote, string userId)
        {
            var note = new Note
            {
                Title = newNote.Title != null ? newNote.Title : "No Title",
                Content = newNote.Content != null ? newNote.Content : "No Content",
                Date = DateTime.UtcNow,
                UserId = userId,
                Link = newNote.Links
            };
            var addedNote = await _context.Note.AddAsync(note);
            await _context.SaveChangesAsync();

            var addedNoteId = (await _context.Note.SingleOrDefaultAsync(x => x.Id == addedNote.Entity.Id)).Id;

            //if(newNote.Links != null)
            //{
            //    var tempLink = new NoteLinks
            //    {
            //        NoteId = addedNoteId,
            //        Link = newNote.Links
            //    };
            //    _context.NoteLinks.Add(tempLink);
            //}


            if (newNote.Tags != null)
            {
                foreach (string noteTags in newNote.Tags)
                {
                    var tempTag = new Tags
                    {
                        NoteId = addedNoteId,
                        Tag = noteTags
                    };
                    _context.Tags.Add(tempTag);
                }
            }


            var created = await _context.SaveChangesAsync();
            return addedNoteId;
        }

        public async Task<bool> UpdateNotesAsync(int id, NotesViewModel noteToUpdate, string userId)
        {
            var note = new Note
            {
                Id = id,
                Title = noteToUpdate.Title,
                Content = noteToUpdate.Content,
                Date = DateTime.UtcNow,
                UserId = userId,
                Link = noteToUpdate.Links
            };

            _context.Note.Update(note);
            //earlier save changes to check if note is updated
            var updated = await _context.SaveChangesAsync();
            //delete existing links/tags.
            //var linksToDelete = await _context.NoteLinks.Where(x => x.NoteId == id).ToListAsync();
            //foreach (var link in linksToDelete)
            //{
            //    _context.NoteLinks.Remove(link);
            //}
            var tagsToDelete = await _context.Tags.Where(x => x.NoteId == id).ToListAsync();
            foreach (var tag in tagsToDelete)
            {
                _context.Tags.Remove(tag);
            }
            //if(noteToUpdate.Links != null)
            //{
            //    var tempLink = new NoteLinks
            //    {
            //        Link = noteToUpdate.Links,
            //        NoteId = id
            //    };
            //    await _context.NoteLinks.AddAsync(tempLink);

            //}
            //add new state of links/tags
            if(noteToUpdate.Tags != null)
            {
                foreach (string noteTags in noteToUpdate.Tags)
                {
                    var tempTag = new Tags
                    {
                        Tag = noteTags,
                        NoteId = id
                    };
                    await _context.Tags.AddAsync(tempTag);
                }
            }
  
            await _context.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            var noteToDelete = await GetNotesByIdAsync(id);
            //var linksToDelete = await _context.NoteLinks.Where(x => x.NoteId == id).ToListAsync();
            //foreach(var link in linksToDelete)
            //{
            //    _context.NoteLinks.Remove(link);
            //}
            var tagsToDelete = await _context.Tags.Where(x => x.NoteId == id).ToListAsync();
            foreach(var tag in tagsToDelete)
            {
                _context.Tags.Remove(tag);
            }
            await _context.SaveChangesAsync();
            _context.Note.Remove(noteToDelete);
            var deleted = await _context.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<bool> UserOwnsNoteAsync(int noteId, string userId)
        {
            var note = await _context.Note.AsNoTracking().SingleOrDefaultAsync(x => x.Id == noteId);

            if (note == null)
            {
                return false;
            }
            //var email = (await _context.Users.FirstOrDefaultAsync(x => x.Id == userId)).Email;

            if(note.UserId != userId)
            {
                return false;
            }

            return true;

        }

        public async Task<NotesDto> AddTags(NotesDto notesDto)
        {
            var tags = await _context.Tags.Where(x => x.NoteId == notesDto.Id).Select(x => x.Tag).ToListAsync();
            notesDto.Tags = tags;
            return notesDto;
        }

        public async Task<List<NotesDto>> AddTags(List<NotesDto> notesDtoList)
        {
            foreach(var notesDto in notesDtoList)
            {
                await AddTags(notesDto);
            }
            return notesDtoList;
        }


        public async Task<List<NotesDto>> GetNotesDtoAsync(string userId)
        {
            var userEmail = await _context.Users.Where(x => x.Id == userId).Select(x => x.Email).SingleOrDefaultAsync();
            var notes = (await this.GetNotesAsync(userId)).ListToDto(userEmail);
            //await AddLinks(notes);
            await AddTags(notes);

            return notes;
        }

        public async Task<NotesDto> GetNotesDtoByIdAsync(int id)
        {
            var note = await GetNotesByIdAsync(id);
            var userEmail = await _context.Users.Where(x => x.Id == note.UserId).Select(x => x.Email).SingleOrDefaultAsync();
            var noteDto = note.ToDto(userEmail);
            //await AddLinks(noteDto);
            await AddTags(noteDto);
            return noteDto;
        }

        public async Task<List<NotesDto>> GetNotesDtoByTagAsync(string userId, string[] tags)
        {
            var notesDto = await GetNotesDtoAsync(userId);

            if (tags == null)
            {
                return notesDto;
            }

            foreach(var noteDto in notesDto)
            {
                var notesTag = noteDto.Tags.ToArray();
                for(int i = 0; i < tags.Length; i++)
                {
                    if(!Array.Exists(notesTag, e => e == tags[i]))
                    {
                        notesDto.Remove(noteDto);
                        i = tags.Length - 1;
                    }
                }
            }
            return notesDto;

        }
    }
}
