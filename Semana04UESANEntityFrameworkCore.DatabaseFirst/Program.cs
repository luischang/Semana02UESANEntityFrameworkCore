// See https://aka.ms/new-console-template for more information
using Semana04UESANEntityFrameworkCore.DatabaseFirst.Models;

Console.WriteLine("Hello, World!");


var context = new MundialQatar2022SinPeruContext();
//Insert new player
//var player1 = new Player()
//{
//    FullName = "Luis Chang",
//    Dorsal = 10,
//    Active = true
//};

//context.Player.Add(player1);
//context.SaveChanges();

//Insert player in List
var player2 = new Player()
{
    FullName = "Paolo Guerrero",
    Dorsal = 9,
    Active = true
};

var player3 = new Player()
{
    FullName = "Gianluca Lapadula",
    Dorsal = 11,
    Active = true
};

var player4 = new Player()
{
    FullName = "Flavio Maestri",
    Dorsal = 21,
    Active = false
};

var listadoJugadores = new List<Player>();
listadoJugadores.Add(player2);
listadoJugadores.Add(player3);
listadoJugadores.Add(player4);

context.Player.AddRange(listadoJugadores);
context.SaveChanges();

//Query with LINQ query expressions

//var busquedaTodosJugadores = (from p in context.Player
//                              where p.Active == true
//                              select p).ToList();

//Console.WriteLine("La cantidad de jugadores encontrados es: " + busquedaTodosJugadores.Count);
//foreach (var item in busquedaTodosJugadores)
//{
//    Console.WriteLine("Jugador encontrado: " + item.FullName);
//}

//var busquedaJugador = (from p in context.Player
//                       where p.Active == false
//                       select p).FirstOrDefault();

//Console.WriteLine("El jugador encontrado es : " + busquedaJugador.FullName);

//Delete Player

//context.Player.Remove(busquedaJugador);
//context.SaveChanges();


//Update Player

//var busquedaJugadorActualizar = context.Player.Where(x => x.Dorsal == 10).FirstOrDefault();

//busquedaJugadorActualizar.Dorsal = 20;
//context.SaveChanges();