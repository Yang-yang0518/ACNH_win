using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNH_win
{
    public class ResidentDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public string Personality { get; set; } = "";
        public string CatchPhrase { get; set; } = "";
        public string? ImagePath { get; set; }
        public int Affection { get; set; }
    }
}
