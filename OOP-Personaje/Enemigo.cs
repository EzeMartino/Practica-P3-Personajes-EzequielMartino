using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal class Enemigo : Personaje 
    {
        public int vida;
        public int nivel;
        public Enemigo(string name, int hp, int level)
        {
            nombre = name;
            vida = hp;
            nivel = level;
            fuerza = 80 * nivel / 3;
            agilidad = 50 / nivel / 2;
            magia = 100 * nivel / 2;
        }
        
        public override int CalcularDanio()
        {
            return fuerza + (agilidad / 2) + magia*2;
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{ nombre} hizo { x} de daño");
        }

        public override void MoverseEjeX(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio a la derecha {movimientos} casillas");
            }
            else if (movimientos < 0) { Console.WriteLine($"{nombre} se movio a la izquierda {movimientos * -1} casillas"); }
            else { Console.WriteLine($"{nombre} no se movió en el eje X"); }
        }

        public override void MoverseEjeY(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio hacia arriba {movimientos} casillas");
            }
            else if (movimientos < 0) { Console.WriteLine($"{nombre} se movio hacia abajo {movimientos * -1} casillas"); }
            else { Console.WriteLine($"{nombre} no se movió en el eje Y"); }
        }
    }
}
