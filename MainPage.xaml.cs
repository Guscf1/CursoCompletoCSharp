using System.Threading.Tasks;

namespace CursoCompletoCSharp
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculateClicked(object? sender, EventArgs e)
        {
            //Chama a tela de inserção de dados das pessoas.
          
            await Shell.Current.GoToAsync("///ListaPessoas");

        }



    }
}
