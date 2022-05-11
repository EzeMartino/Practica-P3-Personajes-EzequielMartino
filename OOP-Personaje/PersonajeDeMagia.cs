using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string name, int strength, int agility, int magic)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = magic;
        }
        public PersonajeDeMagia(string name, int strength, int agility)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = 60;
        }
        public override int CalcularDanio()
        {
            return fuerza + agilidad + magia * 4;
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{nombre} hizo { x} de daño gracias a su magia");
        }
        public override void MoverseEjeX(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio a la derecha {movimientos} casillas");
            }
            else if (movimientos < 0) { Console.WriteLine($"{nombre} se movio a la izquierda {movimientos*-1} casillas"); }
            else { Console.WriteLine($"{nombre} no se movió en el eje X"); }
        }

        public override void MoverseEjeY(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio hacia arriba  arriba {movimientos} casillas");
            }
            else if (movimientos < 0) { Console.WriteLine($"{nombre} se movio hacia abajo {movimientos*-1} casillas"); }
            else { Console.WriteLine($"{nombre} no se movió en el eje Y"); }
        }
    }
}