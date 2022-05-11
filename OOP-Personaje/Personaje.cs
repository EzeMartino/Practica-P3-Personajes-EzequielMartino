using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    abstract class Personaje : IMoverse
    {
        protected string nombre;
        protected int fuerza;
        protected int agilidad;
        protected int magia;
        public abstract int CalcularDanio();
        public abstract void Atacar();

        public virtual void MoverseEjeX(int movimientos)
        {
            throw new NotImplementedException();
        }

        public virtual void MoverseEjeY(int movimientos)
        {
            throw new NotImplementedException();
        }
    }
}
