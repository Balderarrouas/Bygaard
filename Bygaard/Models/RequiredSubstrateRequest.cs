using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bygaard.Models
{
    public class RequiredSubstrateRequest
    {
        public string SubstrateName { get; set; }
        public double RequiredProduce { get; set; }
    }
}