using MarkedNote.Contracts.V1.Requests;
using MarkedNote.Contracts.V1.Responses;
using MarkedNote.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Controllers.V1
{
    [Route("identity")]
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AutherizationFailedResponse
                {
                    Errors = ModelState.Values.SelectMany (x => x.Errors.Select(xx => xx.ErrorMessage))
                });

            }

            var authResponse = await _identityService.RegisterAsync(request.Email, request.Password);

            if(authResponse.Errors != null)
            {
                return BadRequest(new AutherizationFailedResponse
                {
                    Errors = authResponse.Errors
                }); 
            }

            return Ok(new AutherizationSuccessResponse
            {
                JwtToken = authResponse.Token
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            var authResponse = await _identityService.LoginAsync(request.Email, request.Password);

            if (authResponse.Errors != null)
            {
                return BadRequest(new AutherizationFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AutherizationSuccessResponse
            {
                JwtToken = authResponse.Token
            });
        }


    }
}
