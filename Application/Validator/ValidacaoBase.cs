using System.Text.RegularExpressions;

namespace Application.Validator
{
    public class ValidacaoBase
    {
        protected bool ValidaNomeEmBranco(string usuario)
        {
            if (usuario.Equals(string.Empty) || usuario.Equals(""))
                return false;
            return usuario == "" ? false : usuario.Length > 50 ? false : true;
        }

        protected bool ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
                return false;

            return email == "" ? false : email.Length > 50 ? false : true;
        }

        protected bool ValidaID(long id)
        {
            return id == 0 ? false : true;
        }

        public static bool ValidaTelefone(string numero)
        {
            string numeroLimpo = Regex.Replace(numero, "[^0-9]", "");
            if (numeroLimpo.Length != 10 && numeroLimpo.Length != 11)
            {
                return false;
            }
            if (!numeroLimpo.StartsWith("0") && !numeroLimpo.StartsWith("55"))
            {
                return false;
            }
            return true;
        }
    }
}