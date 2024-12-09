
using MEAVISA.CORE;

namespace MEAVISA.Utilities
{
        public static class Password
        {
            public static string HashPassword(string password)
            {
                return password;
            }

        }
        public static class ValidatorField
        {
            public static (string, int) ValidateEmail(string? email)
            {
                if (string.IsNullOrWhiteSpace(email) || !email.Contains('@') || !email.Contains('.')) return ("Email inválido, por favor o preencha corretamente!", 400);
                else return ("", 200);
            }
            public static (string, int) ValidatePassword(string? password)
            {
                if (string.IsNullOrWhiteSpace(password) || password.Length < 8) return ("Digite uma senha com no mínimo 8 caracteres!", 400);
                else return ("", 200);
            }
            public static (string, int) ValidateName(string? name)
            {
                if (string.IsNullOrWhiteSpace(name) || name.Length < 3) return ("Um nome deve ter no mínimo 3 caracteres!", 400);
                else return ("", 200);
            }
            public static (string, int) ValidateWhatsApp(string? whatsApp)
            {
                if (string.IsNullOrWhiteSpace(whatsApp) || whatsApp.Length > 11 || whatsApp.Length < 10) return ("Número inválido, por favor o preencha corretamente!", 400);
                else return ("", 200);
            }
            public static bool ValidateLocation(string location)
            {
                return DataValues.Locations.Contains(location);
            }
            public static bool ValidateDdd(string ddd)
            {
                return DataValues.Ddds.Contains(ddd);
            }
            public static bool ValidateCategories(List<string> categories)
            {
                return categories.Count > 0;
            }
        }
}
