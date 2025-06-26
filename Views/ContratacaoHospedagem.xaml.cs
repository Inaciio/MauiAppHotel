namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    App PropriedadesApp;
	public ContratacaoHospedagem()
	{

		InitializeComponent();
        PropriedadesApp= (App)Application.Current;
        pck_quarto.ItemsSource = PropriedadesApp.QuartoList;

        dtk_Checkin.MinimumDate = DateTime.Now;
        dtk_Checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtk_CheckOut.MinimumDate = dtk_Checkin.Date.AddDays(1);
        dtk_CheckOut.MaximumDate = dtk_Checkin.Date.AddMonths(6);


    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }

    }

    private void dtk_Checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        
        DatePicker elemento = sender as DatePicker;
        DateTime dataSelecionadaCheckIn = elemento.Date;
        dtk_CheckOut.MinimumDate = dataSelecionadaCheckIn.AddDays(1);
        dtk_CheckOut.MaximumDate = dataSelecionadaCheckIn.AddMonths(6);
    }
}