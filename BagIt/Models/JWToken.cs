using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagIt.Models
{
    public class JWToken
    {
        [JsonProperty("token")]
        public string Token;
        public DateTime Expiration;
    }
}
