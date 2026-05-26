using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CRM.Services
{
    public class ClienteService
    {
        // Validación nombre vacio
        public static bool ValidarNombre(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre);
        }

        // Validación correo
        public static bool ValidarCorreo(string correo)
        {
            string patron =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(correo, patron);
        }

        // Validación largo telefonos
        public static bool ValidarTelefono(string telefono)
        {
            return telefono.Length == 10 &&
                   telefono.All(char.IsDigit);
        }
    }
}