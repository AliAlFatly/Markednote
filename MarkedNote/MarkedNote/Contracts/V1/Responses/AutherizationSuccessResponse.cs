using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Contracts.V1.Responses
{
    public class AutherizationSuccessResponse
    {
        public string JwtToken { get; set; }
    }
}
