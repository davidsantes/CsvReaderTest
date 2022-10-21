using ConsoleAppReadCsv.Entidades;
using ConsoleAppReadCsv.Interfaces;

namespace ConsoleAppReadCsv.Managers
{
    public class ReclamacionesJudicialesManager : IReclamacionesJudicialesManager
    {
        private readonly List<EntidadJudicial> _entidadesSinFiltrar = new();
        public List<EntidadJudicial> EntidadesFiltradas { get; private set; } = new();
        public static readonly string[] filtroTiposEntidadesConTopeDias = { "TipoA", "TipoB" };
        
        public ReclamacionesJudicialesManager(List<EntidadJudicial> entidadesSinFiltrar)
        {
            _entidadesSinFiltrar = entidadesSinFiltrar;
        }

        public List<EntidadJudicial> GetEntidadesFiltradas()
        {
            EntidadesFiltradas = _entidadesSinFiltrar.Where
                                    (x => x.GetDiasDiferencia() > Constantes.filtroDiasTope
                                          && filtroTiposEntidadesConTopeDias.Contains(x.Tipo))
                                    .ToList();
            return EntidadesFiltradas;
        }
    }
}
