using System.ComponentModel.DataAnnotations;

namespace DonationApi.Models
{
    public class Truma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ShemYeshutMedinitZara is required")]
        [RegularExpression("^[a-zA-Z\u0590-\u05FF\u200f\u200e ]+$", ErrorMessage = "Characters in Hebrew and English only")]
        public string ShemYeshutMedinitZara { get; set; }


        [Required(ErrorMessage = "Schum is required")]
        public decimal Schum { get; set; }


        [Required(ErrorMessage = "SugYeshutMedinitZara is required")]
        public int SugYeshutMedinitZara { get; set; }


        [Required(ErrorMessage = "Yeud is required")]
        [RegularExpression("^[a-zA-Z\u0590-\u05FF\u200f\u200e ]+$", ErrorMessage = "Characters in Hebrew and English only")]
        public string Yeud { get; set; }


        [RegularExpression("^[a-zA-Z\u0590-\u05FF\u200f\u200e ]+$", ErrorMessage = "Characters in Hebrew and English only")]
        public string? Tnaim { get; set; }

        
        [Required(ErrorMessage = "SugMatbea is required")]
        public int SugMatbea { get; set; }

        [Required(ErrorMessage = "ShaarHamara is required")]
        public decimal ShaarHamara { get; set; }

    }
}
