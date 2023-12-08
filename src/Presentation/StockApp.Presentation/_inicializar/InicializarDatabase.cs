using StockApp.Busines.Interface.Database;
using StockApp.DataAccess.Database;


namespace StockApp.WindowsForms._inicializar
{
    internal class InicializarDatabase
    {
        private readonly IDataBaseService _dataBaseService;

        
        public InicializarDatabase()
        {
            _dataBaseService = new DataBaseService();
        }

        internal void Init() 
        {
            _dataBaseService.CriarBanco();
            _dataBaseService.CriarTabelaCategoria();

        
        }
       
    }
}
