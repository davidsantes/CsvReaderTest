using System.Globalization;
using ConsoleAppReadCsv.Entidades;
using ConsoleAppReadCsv.Interfaces;

namespace ConsoleAppReadCsv.Managers
{
    public class CsvManager : ICsvManager
    {
        private readonly List<EntidadJudicial> _entidades = new();
        private string Path { get; set; }

        public List<EntidadJudicial> ReadCsv(string path)
        {
            Path = path;
            using (var reader = new StreamReader(Path))
            {
                _entidades.Clear();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    var entidad = new EntidadJudicial
                    {
                        Id = int.Parse(values[0]),
                        Tipo = values[1],
                        Fecha = DateTime.ParseExact(values[2], "yyyyMMdd", CultureInfo.InvariantCulture)
                    };
                    _entidades.Add(entidad);
                }
            }

            return _entidades;
        }
    }
}
