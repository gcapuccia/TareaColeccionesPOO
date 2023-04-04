// See https://aka.ms/new-console-template for more information

/*Se pide para un club de futbol generar una lista de 22 jugadores. 
La clase jugador tiene Nombre, Apellido, Edad y Puesto (enumeraciòn arquero, defensor, mediocampista, delantero).

Se pide:
Ordenar alfabeticamente
Calcular el promedio de edad
Listar todos los arqueros
Buscar por apellido
*/


var ListaJugadores = new List<Jugador>()
{
    new Jugador("Lionel","Messi", 33, Jugador.TipoPuesto.mediocampista),
    new Jugador("Emiliano","Martines", 35, Jugador.TipoPuesto.arquero),
    new Jugador("Jesus","Datolo", 36, Jugador.TipoPuesto.delantero),
    new Jugador("Toro","Martinez", 25, Jugador.TipoPuesto.defensor),
    new Jugador("Roberto","Bonano", 28, Jugador.TipoPuesto.arquero),
    new Jugador("Facundo","Cambeces", 22, Jugador.TipoPuesto.arquero),
    new Jugador("Andres","Chaves", 30, Jugador.TipoPuesto.delantero),
    new Jugador("Brian","Aleman", 36, Jugador.TipoPuesto.mediocampista)

};


var ListaOrdenada = ListaJugadores.OrderBy(x=>x.Nombre);

foreach (var Ju in ListaOrdenada)
{
    Console.WriteLine($"Jugador: {Ju.Nombre} {Ju.Apellido} Edad: {Ju.Edad} Puesto: {Ju.Puesto}");
}

//Promedio De Edad
var PromedioEdad = ListaJugadores.Average(x => x.Edad);
Console.WriteLine("Promedio de Edad: " + PromedioEdad);

var ListarPuestoArquero = ListaJugadores.Where(x => x.Puesto == Jugador.TipoPuesto.arquero);

foreach (var Ju in ListarPuestoArquero)
{
    Console.WriteLine($"Arqueros: {Ju.Nombre} {Ju.Apellido} Edad: {Ju.Edad} Puesto: {Ju.Puesto}");
}

Console.WriteLine("Que Apellido quiere buscar?: ");
var ApellidoBuscar = Console.ReadLine();

var ListarApellido = ListaJugadores.Where(x => x.Apellido.ToUpper().Contains(ApellidoBuscar.ToUpper()));

foreach (var Ju in ListarApellido)
{
    Console.WriteLine($"Arqueros: {Ju.Nombre} {Ju.Apellido} Edad: {Ju.Edad} Puesto: {Ju.Puesto}");
}




class Jugador
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public int Edad { get; set; }
    public TipoPuesto Puesto { get; set; }

    public enum TipoPuesto{
        arquero,
        defensor,
        mediocampista,
        delantero
    }

    public Jugador(string NombreJugador, string ApellidoJugador, int EdadJugador, TipoPuesto PuestoJugador)
    {
        this.Nombre = NombreJugador;
        this.Apellido = ApellidoJugador;
        this.Edad = EdadJugador;
        this.Puesto = PuestoJugador;
    }



}

