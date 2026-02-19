using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.PronunciationAssessment;
using NAudio.Wave;
using System.Text.Json;

namespace KLLA
{
    public partial class Form1 : Form
    {
        // ========= AUDIO RECORDING =========
        // Added '?' because Nullable is enabled [1] and these start as null [2]
        private WaveInEvent? waveIn;
        private WaveFileWriter? waveWriter;
        private readonly string audioPath = @"C:\KLLA\test.wav";

        // ========= AZURE CONFIG =========
        private const string AZURE_KEY = "AZLLB8UpSxw6iKhjpMIG3FP7BGPcxyArQ6P3wP1XNunBNUhHdEdKJQQJ99CBACYeBjFXJ3w3AAAYACOGISoR"; // [2]
        private const string AZURE_REGION = "eastus"; // [3]
        private string currentKoreanWord = ""; // [3]

        // ========= WORD MODEL =========
        public class Word // [3]
        {
            public int word_id { get; set; }
            public string? hangeul { get; set; } // Added '?' for null safety [1]
            public string? english_definition { get; set; }
            public string? pronunciation_guide { get; set; }
            public bool is_learned { get; set; }
        }

        public Form1()
        {
            InitializeComponent(); // [3]
        }

        // ========= PICK RANDOM WORD =========
        private void learnWordB_Click(object sender, EventArgs e)
        {
            // [4]
            if (!File.Exists("MasterBank.json")) return;

            string jsonString = File.ReadAllText("MasterBank.json");

            // FIXED: Added missing generic type <List<Word>> to the Deserializer [4]
            var words = JsonSerializer.Deserialize<List<Word>>(jsonString);

            if (words != null && words.Count > 0)
            {
                Random rand = new Random();
                var randomWord = words[rand.Next(words.Count)];

                // Ensure we handle potential nulls from the JSON [1]
                currentKoreanWord = randomWord.hangeul ?? "";
                learnWordLBL.Text = randomWord.hangeul;
                learnPronounceLBL.Text = "("+ randomWord.pronunciation_guide +")";
                learnDefLBL.Text = randomWord.english_definition;
            }
        }

        // ========= MIC RECORDING =========
        private void StartRecording() // [4]
        {
            waveIn = new WaveInEvent
            {
                DeviceNumber = 0,
                WaveFormat = new WaveFormat(16000, 1)
            };

            waveWriter = new WaveFileWriter(audioPath, waveIn.WaveFormat);

            waveIn.DataAvailable += (s, a) =>
            {
                // Added null-conditional to prevent crashes [5]
                waveWriter?.Write(a.Buffer, 0, a.BytesRecorded);
            };

            waveIn.StartRecording();
        }

        private void StopRecording() // [5]
        {
            waveIn?.StopRecording();
            waveIn?.Dispose();
            waveIn = null;

            waveWriter?.Close();
            waveWriter?.Dispose();
            waveWriter = null;
        }

        // ========= MIC CHECKBOX =========
        private async void learnMicCB_CheckedChanged(object sender, EventArgs e)
        {
            // [5]
            if (learnMicCB.Checked)
            {
                learnDefLBL.Text = "🎤 Listening... Speak now.";
                StartRecording();
            }
            else
            {
                learnDefLBL.Text = "🧠 Grading pronunciation...";
                StopRecording();

                try
                {
                    // [6] This now correctly awaits a double result
                    double score = await GradePronunciationAsync(audioPath, currentKoreanWord);
                    learnDefLBL.Text = $"Pronunciation score: {score:0}%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speech Error");
                    learnDefLBL.Text = "❌ Pronunciation failed";
                }
            }
        }

        // ========= AZURE PRONUNCIATION ASSESSMENT =========
        // FIXED: Changed return type to Task<double> to return the AccuracyScore [6],[7]
        private async Task<double> GradePronunciationAsync(string wavPath, string expectedText)
        {
            if (!File.Exists(wavPath))
                throw new FileNotFoundException("Audio file not found");

            var speechConfig = SpeechConfig.FromSubscription(AZURE_KEY, AZURE_REGION); // [8]
            speechConfig.SpeechRecognitionLanguage = "ko-KR";

            using var audioConfig = AudioConfig.FromWavFileInput(wavPath);
            using var recognizer = new SpeechRecognizer(speechConfig, audioConfig);

            var pronunciationConfig = new PronunciationAssessmentConfig(
                referenceText: expectedText,
                gradingSystem: GradingSystem.HundredMark,
                granularity: Granularity.Phoneme,
                enableMiscue: true
            );




            pronunciationConfig.ApplyTo(recognizer);
            var result = await recognizer.RecognizeOnceAsync(); // [7]

            if (result.Reason != ResultReason.RecognizedSpeech)
                throw new Exception("Speech not recognized");

            var pronunciationResult = PronunciationAssessmentResult.FromResult(result);
            return pronunciationResult.AccuracyScore; // Returns the score to the caller [7]
        }
    }
}