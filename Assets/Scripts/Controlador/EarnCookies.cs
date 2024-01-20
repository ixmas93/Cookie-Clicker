using Modelo;

namespace Controlador
{
    public class EarnCookies
    {
        private readonly Score _score;

        public EarnCookies(Score score) => _score = score;

        public void CookieClick() => _score.AddCookies(_score.cookiesIncrementAmmount);
    }
}