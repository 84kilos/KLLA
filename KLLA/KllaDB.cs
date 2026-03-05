//Require nuGet package:
//1. Supabase by joseph Schultz 
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KLLA

{
    [Table("korean_vocabulary")]

    // Korean VocabTable ///////////////////////////////////////////
    public class KoreanVocabulary : BaseModel
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

    ////////////////////////////////////////////////////////////////

    internal class KllaDB
    {
        private Client? _supabase;
        private List<KoreanVocabulary> _words = new List<KoreanVocabulary>();
        private int _currentIndex = -1;

        // unchangeable secret keys
        private const string url = "https://cdfkpfjeflljhutuwrun.supabase.co";
        private const string key = "sb_publishable_gnJ_0UWf-bYZ8_1J6Xgqxg_yRfU4ucY";

        public string Url { get; }
        public string Key { get; }

        // Constructor to create un-editable keys
        public KllaDB()
        {
            Url = url;
            Key = key;
        }

        // Internal helpers
        internal int GetWordCount() => _words.Count;
        internal bool IsLoaded() => _words.Count > 0;
        internal List<KoreanVocabulary> GetAllWords() => new List<KoreanVocabulary>(_words); // def copy

        /// COnnecting Korean Database //////////////////////////////////////////////////////////////////
        internal async Task Connect_Database()
        {
            try
            {
                var options = new SupabaseOptions { AutoConnectRealtime = true };

                _supabase = new Client(Url, Key, options);
                await _supabase.InitializeAsync(); // wait for the supabase to connect

                // Once connected, get the data
                var response = await _supabase
                    .From<KoreanVocabulary>()
                    .Get();

                //Check to see if all data is collecetd (for Dev)
                _words = response.Models;

                if (_words.Count > 0)
                {
                    Console.WriteLine($"Loaded {_words.Count} words!");
                }
                else { Console.WriteLine($"DataBase connected, but only {_words.Count} words!"); }

            }
            catch (Exception e) { MessageBox.Show($"Error: {e}"); }

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////

        //// Get the infomation bsed on the english word
        internal KoreanVocabulary? GetByEnglish(string englishWord)
        {
            return _words.Find(w =>
                string.Equals(w.EnglishTranslation, englishWord, StringComparison.OrdinalIgnoreCase));
        }

        //// Get info based on korean word
        internal KoreanVocabulary? GetByKorean(string koreanWord)
        {
            return _words.Find(w =>
                string.Equals(w.KoreanWord, koreanWord, StringComparison.OrdinalIgnoreCase));
        }

        /// Get random words
        internal KoreanVocabulary? GetRandomWord()
        {
            if (_words.Count == 0) return null;
            _currentIndex = new Random().Next(_words.Count);
            return _words[_currentIndex];
        }
        



    }
}
