 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkedNote.Contracts.V1.Responses
{
    public class AutherizationFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
