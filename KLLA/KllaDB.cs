//Require nuGet package:
//1. Supabase by Joseph Schultz 
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLLA
{
    // =====================================================================
    // TABLE MODEL: korean_vocabulary
    // Columns: id, created_at, korean_word, english_word, romanization,
    //          audio_url, tag
    // Tags: Easy_word | Hard_word | Consonant | Vowel
    // =====================================================================
    [Table("korean_vocabulary")]
    public class KoreanVocabulary : BaseModel
    {
        [PrimaryKey("id")]
        public string? Id { get; set; }

        [Column("created_at")]
        public string? CreatedAt { get; set; }

        [Column("korean_word")]
        public string? KoreanWord { get; set; }

        [Column("english_word")]
        public string? EnglishTranslation { get; set; }

        [Column("romanization")]
        public string? Romanization { get; set; }

        [Column("audio_url")]
        public string? AudioUrl { get; set; }

        [Column("tag")]
        public string? Tag { get; set; }
    }

    // =====================================================================
    // TABLE MODEL: korean_sentences
    // Columns: id, sentence, translation, pronunciation, theme
    // Themes: common | introductions | ordering | work | directions
    // =====================================================================
    [Table("korean_sentences")]
    public class KoreanSentence : BaseModel
    {
        [PrimaryKey("id", false)] //false = not auto-generated UUID, it's an int
        public int Id { get; set; }

        [Column("sentence")]
        public string? Sentence { get; set; }

        [Column("translation")]
        public string? Translation { get; set; }

        [Column("pronunciation")]
        public string? Pronunciation { get; set; }

        [Column("theme")]
        public string? Theme { get; set; }
    }

    // =====================================================================
    // DATABASE HANDLER
    // =====================================================================
    internal class KllaDB
    {
        private Client? _supabase;

        private List<KoreanVocabulary> _words = new List<KoreanVocabulary>();
        private List<KoreanSentence> _sentences = new List<KoreanSentence>();

        private const string url = "https://cdfkpfjeflljhutuwrun.supabase.co";
        private const string key = "sb_publishable_gnJ_0UWf-bYZ8_1J6Xgqxg_yRfU4ucY";

        public string Url { get; }
        public string Key { get; }

        public KllaDB()
        {
            Url = url;
            Key = key;
        }

        // -----------------------------------------------------------------
        // CONNECTION
        // -----------------------------------------------------------------
        //need fallback ~~
        internal async Task Connect_Database()
        {
            try
            {
                var options = new SupabaseOptions { AutoConnectRealtime = true };
                _supabase = new Client(Url, Key, options);
                await _supabase.InitializeAsync();

                //Load vocabulary
                var vocabResponse = await _supabase.From<KoreanVocabulary>().Get();
                _words = vocabResponse.Models;

                //Load sentences
                var sentenceResponse = await _supabase.From<KoreanSentence>().Get();
                _sentences = sentenceResponse.Models;

                Console.WriteLine($"Loaded {_words.Count} vocab words, {_sentences.Count} sentences.");
            }
            catch (Exception e) { MessageBox.Show($"Error: {e}"); }
        }

        // -----------------------------------------------------------------
        // VOCABULARY — korean_vocabulary
        // -----------------------------------------------------------------

        internal int GetWordCount() => _words.Count;
        internal bool IsLoaded() => _words.Count > 0;
        internal List<KoreanVocabulary> GetAllWords() => new List<KoreanVocabulary>(_words);

        //returns all vocab matching a specific tag (Easy_word, Hard_word, Consonant, Vowel)
        internal List<KoreanVocabulary> GetWordsByTag(string tag) =>
            _words.FindAll(w => string.Equals(w.Tag?.Trim(), tag.Trim(), StringComparison.OrdinalIgnoreCase));

        //get vocab only, excludes alphabet
        internal List<KoreanVocabulary> GetVocabOnly() =>
            _words.FindAll(w => w.Tag == "Easy_word" || w.Tag == "Hard_word");

        //get korean word from english
        internal KoreanVocabulary? GetByEnglish(string englishWord) =>
            _words.Find(w => string.Equals(w.EnglishTranslation, englishWord, StringComparison.OrdinalIgnoreCase));

        //get english from korean word
        internal KoreanVocabulary? GetByKorean(string koreanWord) =>
            _words.Find(w => string.Equals(w.KoreanWord, koreanWord, StringComparison.OrdinalIgnoreCase));

        //get random word from koreanVocab Database
        internal KoreanVocabulary? GetRandomWord()
        {
            var vocab = GetVocabOnly();
            if (vocab.Count == 0) return null;
            return vocab[new Random().Next(vocab.Count)];
        }

        // -----------------------------------------------------------------
        // SENTENCES — korean_sentences
        // -----------------------------------------------------------------

        internal int GetSentenceCount() => _sentences.Count;
        internal bool SentencesLoaded() => _sentences.Count > 0;
        internal List<KoreanSentence> GetAllSentences() => new List<KoreanSentence>(_sentences);

        //returns all sentences matching a theme (common, ordering, work, introductions, directions)
        internal List<KoreanSentence> GetSentencesByTheme(string theme) =>
            _sentences.FindAll(s => string.Equals(s.Theme?.Trim(), theme.Trim(), StringComparison.OrdinalIgnoreCase));

        //get a random sentence in snetence database
        internal KoreanSentence? GetRandomSentence()
        {
            if (_sentences.Count == 0) return null;
            return _sentences[new Random().Next(_sentences.Count)];
        }

        // Random sentence from a theme
        internal KoreanSentence? GetRandomSentenceByTheme(string theme)
        {
            var filtered = GetSentencesByTheme(theme);
            if (filtered.Count == 0) return null;
            return filtered[new Random().Next(filtered.Count)];
        }
    }
}