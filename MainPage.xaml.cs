using Module05Exercise01.Services;
using MySql.Data.MySqlClient;

namespace Module05Exercise01
{
    public partial class MainPage : ContentPage
    {

        private readonly DatabaseConnectionService _dbConnectionService;

        public MainPage()
        {
            InitializeComponent();

            //Initialize Database Connection
            _dbConnectionService = new DatabaseConnectionService();
        }

        

        private async void OpenViewEmployee(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ViewEmployee");
        }
    }

}
