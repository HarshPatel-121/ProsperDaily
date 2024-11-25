using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily
{
    public partial class App : Application
    {
        //Dependency
        public static BaseRepository<Transaction>
            TransactionsRepo { get; private set; }
        public App(BaseRepository<Transaction>_transactionsrepo)
        {
            InitializeComponent();

            //Inject Dependency
            TransactionsRepo = _transactionsrepo;
            MainPage = new AppContainer();
        }
    }
}
