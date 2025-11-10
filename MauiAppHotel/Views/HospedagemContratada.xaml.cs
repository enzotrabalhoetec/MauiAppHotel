namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked_2(object sender, EventArgs e)
    {
		try 
		{
			Navigation.PushAsync(new ContratacaoHospedagem());
		} 
		catch (Exception ex)
		{
            DisplayAlert("ops", ex.Message, "OK");
        }
    }
}
