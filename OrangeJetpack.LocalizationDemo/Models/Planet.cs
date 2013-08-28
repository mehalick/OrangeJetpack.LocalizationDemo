using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrangeJetpack.Localization;

namespace OrangeJetpack.LocalizationDemo.Models
{
    public class Planet : ILocalizable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanetId { get; set; }

        [Required, Localized]
        public string Name { get; set; }
    }
}