using MarkedNote.Domain.V1;
using MarkedNote.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Extentions
{
    public static class GeneralExtensions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if(httpContext.User == null)
            {
                return string.Empty;
            }

            return httpContext.User.Claims.Single(x => x.Type == "id").Value;
        }

        public static NotesDto ToDto(this Note note, string email)
        {
            var noteDto = new NotesDto
            {
                Id = note.Id,
                Title = note.Title,
                Date = note.Date,
                Content = note.Content,
                Email = email,
                Link = note.Link
            };

            return noteDto;
        }

        public static List<NotesDto> ListToDto(this List<Note> noteList, string email)
        {
            var noteDtoList = new List<NotesDto>();
            foreach(var note in noteList)
            {
                var tempNoteDto = note.ToDto(email);
                noteDtoList.Add(tempNoteDto);
            }

            return noteDtoList;
        }
    }
}
