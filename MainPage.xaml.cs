using System.Threading.Tasks;

namespace CursoCompletoCSharp
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculateClicked(object? sender, EventArgs e)
        {
            //Chama a tela de inserção de dados das pessoas.
            //
            await Shell.Current.GoToAsync("///ListaPessoas");

            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }



    }
}
