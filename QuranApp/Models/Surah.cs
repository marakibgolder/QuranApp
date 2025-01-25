using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuranApp.Models
{
    public class Surah
    {
        public int id { get; set; }
        public string name { get; set; }
        public string transliteration { get; set; }
        public string translation { get; set; }
        public string type { get; set; }
        public int totalVerses { get; set; }
        public List<Verse> verses { get; set; } = new List<Verse>();
    }
}
