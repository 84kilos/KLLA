using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace KLLA
{
    public class Word : BaseModel
    {
        [PrimaryKey("id")]
        public string? Id { get; set; }

        [Column("korean_word")]
        public string? KoreanWord { get; set; }

        [Column("english_word")]
        public string? EnglishTranslation { get; set; }

        [Column("romanization")]
        public string? Romanization { get; set; }

        [Column("audio_url")]
        public string? AudioUrl { get; set; }
    }
}
