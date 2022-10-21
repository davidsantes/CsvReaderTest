namespace ConsoleAppReadCsv.Entidades
{
    public class EntidadJudicial
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public int GetDiasDiferencia()
        {
            return (Fecha - DateTime.Now).Days * -1;
        }
    }
}
