using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreBuild.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public decimal NumStars { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; }
    }
}
