using MarkedNote.Domain.V1;
using MarkedNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Services
{
    public interface INoteService
    {
        Task<List<Note>> GetNotesAsync(string userId);

        Task<List<Note>> GetNotesByTagsAsync(string userId, string[] tags);

        Task<int> CreateNotesAsync(NotesViewModel newNote, string userId);

        Task<Note> GetNotesByIdAsync(int id);

        Task<bool> UpdateNotesAsync(int id, NotesViewModel noteToUpdate, string userId);

        Task<bool> DeletePostAsync(int id);

        Task<bool> UserOwnsNoteAsync(int noteId, string userId);

        Task<NotesDto> AddTags(NotesDto notesDto);

        Task<List<NotesDto>> AddTags(List<NotesDto> notesDtoList);

        //Task<NotesDto> AddLinks(NotesDto notesDto);

        //Task<List<NotesDto>> AddLinks(List<NotesDto> notesDtoList);

        Task<List<NotesDto>> GetNotesDtoAsync(string userId);

        Task<NotesDto> GetNotesDtoByIdAsync(int id);

        Task<List<NotesDto>> GetNotesDtoByTagAsync(string userId, string[] tags);
        
    }
}
