
namespace SistemaVenta.Utility
{
    public static class BCryptPasswordHasher
    {
        public static string hashClave(string clave)
        {
            string claveHash = BCrypt.Net.BCrypt.EnhancedHashPassword(clave,13);
            return claveHash;
        }

        public static bool validarClave (string claveUsuario,string clave)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(claveUsuario,clave);
        }


    }
    
}
