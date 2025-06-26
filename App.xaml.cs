using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> QuartoList = new List<Quarto> 
        {
            new Quarto()
            {
                descricao="Suite Super Luxo",
                valorDiariaAdulto=100,
                valorDiariaCrianca=55
            },
            new Quarto()
            {
                descricao="Suite  Luxo",
                valorDiariaAdulto=85,
                valorDiariaCrianca=40
            },
            new Quarto()
            {
                descricao="Suite  Single",
                valorDiariaAdulto=50,
                valorDiariaCrianca=14
            },
            new Quarto()
            {
                descricao="Suite  Crise",
                valorDiariaAdulto=30,
                valorDiariaCrianca=8
            }

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? ActivationState)
        {
            var window = base.CreateWindow(ActivationState);    
            window.Width = 400;  // Set the width of the window
            window.Height = 600; // Set the height of the window
            return window;  // Handle when your app starts
        }

    }
}
