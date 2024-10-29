using LanguageTranslator.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageTranslator.Controllers
{
    public class WordController : Controller
    {
        // Dictionaries for different languages

        private static readonly Dictionary<string, string> englishToTamil = new Dictionary<string, string>()

    {

      { "hello", "வணக்கம்" },

      { "goodbye", "பிரியாவிடை" },

      { "thank you", "நன்றி" },

      { "yes", "ஆம்" },

      { "no", "இல்லை" }

    };

        private static readonly Dictionary<string, string> englishToFrench = new Dictionary<string, string>()

    {

      { "hello", "bonjour" },

      { "goodbye", "au revoir" },

      { "thank you", "merci" },

      { "yes", "oui" },

      { "no", "non" }

    };
        private static readonly Dictionary<string, string> englishToTelugu = new Dictionary<string, string>()

    {

        { "hello", "హలో" },
        { "goodbye", "వీడ్కోలు" },
        { "thank you", "ధన్యవాదాలు" },
        { "yes", "అవును" },
        { "no", "కాదు" }

    };

        public IActionResult Index()

        {

            return View();

        }

        [HttpPost]

        public IActionResult Translate(WordModel model)

        {

            // Check the selected language and translate the word

            switch (model.Language)

            {

                case "Tamil":

                    model.TranslatedWord = englishToTamil.ContainsKey(model.OriginalWord.ToLower())

                      ? englishToTamil[model.OriginalWord.ToLower()]

                      : "Translation not available";

                    break;

                case "Telugu":

                    model.TranslatedWord = englishToTelugu.ContainsKey(model.OriginalWord.ToLower())

                      ? englishToTelugu[model.OriginalWord.ToLower()]

                      : "Translation not available";

                    break;

                case "French":

                    model.TranslatedWord = englishToFrench.ContainsKey(model.OriginalWord.ToLower())

                      ? englishToFrench[model.OriginalWord.ToLower()]

                      : "Translation not available";

                    break;

                default:

                    model.TranslatedWord = "Language not supported";

                    break;

            }

            // Return the view with the model

            return View("Index", model);

        }
    }
}
