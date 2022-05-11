using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal static class Turno
    {
        public static void Atacarse (IList<Personaje> personajes)
        {
            foreach(Personaje personaje in personajes)
            {
                personaje.Atacar();
            }
        }
        public static void MoverFichas(Personaje ficha, int espaciosEjeX, int espaciosEjeY)
        {
            ficha.MoverseEjeX(espaciosEjeX);
            ficha.MoverseEjeY(espaciosEjeY);
        }
    }
}
