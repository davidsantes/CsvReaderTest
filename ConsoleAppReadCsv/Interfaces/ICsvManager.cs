using ConsoleAppReadCsv.Entidades;

namespace ConsoleAppReadCsv.Interfaces
{
    public interface ICsvManager
    {
        List<EntidadJudicial> ReadCsv(string path);
    }
}
