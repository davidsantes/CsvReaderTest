using System.Reflection;
using ConsoleAppReadCsv.Entidades;
using ConsoleAppReadCsv.Managers;


var csvReader = new CsvManager();

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Ejemplo.csv");

var listaReclamacionesTotal = csvReader.ReadCsv(path);
var reclamacionesJudicialesManager = new ReclamacionesJudicialesManager(listaReclamacionesTotal);
var listaReclamacionesFiltradas = reclamacionesJudicialesManager.GetEntidadesFiltradas();

Console.WriteLine("Lista de Reclamaciones judiciales con más de {0} días:", Constantes.filtroDiasTope);
foreach (var reclamacion in listaReclamacionesFiltradas)
{
    Console.WriteLine("Id: {0}, Tipo: {1}, Fecha: {2}, Días diferencia: {3}", reclamacion.Id, reclamacion.Tipo, reclamacion.Fecha, reclamacion.GetDiasDiferencia());
}

Console.ReadLine();