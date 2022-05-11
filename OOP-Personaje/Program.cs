//Personaje
//Crear una clase abstracta llamada Personaje, que tenga las siguientes propiedades:
//Nombre
//Fuerza
//Agilidad
//Magia
//y los Métodos:
//CalcularDanio()
//Atacar()
//El método abstracto CalcularDanio y Atacar muestra por consola: “{ nombre}
//hizo
//{ x}
//de daño”. Donde x es el daño calculado.

//Crear una clase llamada PersonajeDeFuerza, que implemente a Personaje.
//Crear un constructor para PersonajeDeFuerza que reciba los tres atributos de parámetro y se los asigne a Nombre Agilidad y Magia respectivamente. Fuerza estará por defecto en 100. CalcularDanio que calcula el daño en base a una fórmula que involucra las 3 propiedades (queda a imaginación de ustedes)

//Crear una clase llamada PersonajeDeAgilidad que tenga un constructor que reciba los 4 atributos como parámetro. Al atacar debe implementar el método CalcularDanio() y utilizar la fórmula Fuerza/2*Agilidad*Magia/2 para calcular el daño.
//Crear una clase llamada PersonajeDeMagia que tenga 2 constructores, uno que reciba los 4 atributos como parámetro y otro que reciba 3 y le ponga el atributo magia en 60 por defecto. Al atacar debe sobreescribir el método Atacar() para que diga: “{ nombre}
//hizo
//{ x}
//de daño gracias a su magia” y utilizar la fórmula Fuerza+Agilidad+Magia*4 para calcular el daño.

//Crear una clase Enemigo que tenga vida y nivel.

//Crear una interfaz IMoverse que tenga 2 métodos: MoverseEjeX y MoverseEjeY. Todos los personajes y enemigos deben implementar esta interfaz.

//Crear una clase estática llamada Turno que implemente 2 métodos estáticos:
//public static void Atacarse(IList<Personaje> personajes)
//public static void MoverFichas(IMoverse ficha)

//El primero tiene que recibir una lista de todos los personajes instanciados y hacerlos atacar.
//El segundo recibe un objeto que implementa IMoverse y los hace moverse en el eje X y en el Y. Hacer que en program reciba algunos personajes y un enemigo para probar.

namespace Personaje
{
    public class Program
    {
        public static void Main()
        {
            PersonajeDeAgilidad Robert = new("Robert", 75, 150, 50);
            PersonajeDeFuerza Harold = new("Harold", 100, 5);
            PersonajeDeMagia Lillia = new("Lillia", 50, 50);
            Enemigo Juan = new("Juan", 400, 10);

            List<Personaje> personajes = new();
            personajes.Add(Robert);
            personajes.Add(Harold);
            personajes.Add(Lillia);
            personajes.Add(Juan);

            Turno.Atacarse(personajes);
            Turno.MoverFichas(Lillia, 5, 0);
            Turno.MoverFichas(Juan, -5, 10);
            Turno.MoverFichas(Harold, 7, 4);
            Turno.MoverFichas(Robert, 0, -5);

        }
    }
}
