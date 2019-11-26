using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkedNote.Contracts.V1.Responses;
using MarkedNote.Domain.V1;
using MarkedNote.Extentions;
using MarkedNote.Models;
using MarkedNote.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarkedNote.Controllers.V1
{
    [Route("notes")]
    //[ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class NotesController : Controller
    {
        private readonly INoteService _noteService; 

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("mynotes")]
        public async Task<IActionResult> GetAllNotes()
        {
            var notes = await _noteService.GetNotesDtoAsync(HttpContext.GetUserId());
            return Ok(new NotesResponse
            {
                notes = notes
            });
        }


        [HttpPost("/search")]
        public async Task<IActionResult> GetNotesByTags([FromBody] string[] tags)
        {
            return Ok(await _noteService.GetNotesDtoByTagAsync(HttpContext.GetUserId(), tags));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNoteById([FromRoute] int id)
        {
            var userOwnsNote = await _noteService.UserOwnsNoteAsync(id, HttpContext.GetUserId());
            if (!userOwnsNote)
            {
                return BadRequest("Something went wrong");
            }

            return Ok(new { note = await _noteService.GetNotesDtoByIdAsync(id) });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNote([FromRoute] int id, [FromBody] NotesViewModel updatedNote)
        {
            var userOwnsNote = await _noteService.UserOwnsNoteAsync(id, HttpContext.GetUserId());
            if (!userOwnsNote)
            {
                return BadRequest("Something went wrong");
            }

            var updated = await _noteService.UpdateNotesAsync(id, updatedNote, HttpContext.GetUserId());

            if (updated)
            {
                return Ok(await _noteService.GetNotesByIdAsync(id));
            }

            return NotFound();
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateNote([FromBody] NotesViewModel newNote)
        {
            var noteId = await _noteService.CreateNotesAsync(newNote, HttpContext.GetUserId());

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + "notes/" + noteId;

            var createdNote = await _noteService.GetNotesByIdAsync(noteId);

            return Created(locationUri, createdNote);

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] int id)
        {
            var userOwnsNote = await _noteService.UserOwnsNoteAsync(id, HttpContext.GetUserId());
            if (!userOwnsNote)
            {
                return BadRequest("Something went wrong");
            }

            var deleted = await _noteService.DeletePostAsync(id);

            if (deleted)
            {
                return Ok();
            }

            return NotFound();
        }

    }
}