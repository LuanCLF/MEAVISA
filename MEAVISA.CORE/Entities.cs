using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEAVISA.CORE
{
    public class User(string name, string? email, string? whatsApp, string password, ContactPreference preference, List<string> categoryPreferences, string? locationPreference)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; private set; }

        [Column("Name")]
        [Required]
        public string Name { get; private set; } = name;

        [Column("Email")]
        public string? Email { get; private set; } = email;

        [Column("WhatsApp")]
        public string? WhatsApp { get; private set; } = whatsApp;

        [Column("Password")]
        [Required]
        public string Password { get; private set; } = password;

        [Column("Preference")]
        [Required]
        public ContactPreference Preference { get; private set; } = preference;

        [Column("CategoryPreferences")]
        [Required]
        public List<string> CategoryPreferences { get; private set; } = categoryPreferences;

        [Column("LocationPreference")]
        public string? LocationPreference { get; private set; } = locationPreference;

        [Column("IsAdmin")]
        [Required]
        [DefaultValue(false)]
        public bool IsAdmin { get; private set; } = false;

        public void Update(string? name, string? email, string? whatsApp, string? password, ContactPreference? preference, List<string?> categoryPreferences, string? locationPreference)
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : Name;
            Email = !string.IsNullOrWhiteSpace(email) ? email : Email;
            WhatsApp = !string.IsNullOrWhiteSpace(whatsApp) ? whatsApp : WhatsApp;
            Password = !string.IsNullOrWhiteSpace(password) ? password : Password;
            Preference = preference ?? Preference;
            CategoryPreferences = categoryPreferences.Count > 0 ? categoryPreferences! : CategoryPreferences;
            LocationPreference = locationPreference ?? LocationPreference;
        }
    }
    public enum ContactPreference
    {
        Email,
        WhatsApp
    }
    public static class DataValues
    {
        public static List<string> Categories { get; } =
            [
                "Obras",
                "Problemas de\nágua/energia",
                "Eventos",
                "Concursos",
                "Atendimentos",
                "Vacinas",
                "Campanhas"
            ];
        public static List<string> Locations { get; } =
            [
                "Sítio Canto",
                "Cohab",
                "Jacu",
                "Centro",
                "Umarizeira",
                "Canto Bonito",
                "Sítio Frade",
                "Lagoa Nova",
                "Planalto",
                "Jocellyn Villar",
            ];
        public static List<string> Ddds { get; } = ["11", "12", "13", "14", "15", "16", "17", "18", "19", "21", "22", "24", "27", "28", "31", "32", "33", "34", "35", "37", "38", "41", "42", "43", "44", "45", "46", "47", "48", "49", "51", "53", "54", "55", "61", "62", "63", "64", "65", "66", "67", "68", "69", "71", "73", "74", "75", "77", "79", "81", "82", "83", "84", "85", "86", "87", "88", "89", "91", "92", "93", "94", "95", "96", "97", "98", "99"];
    }
}
