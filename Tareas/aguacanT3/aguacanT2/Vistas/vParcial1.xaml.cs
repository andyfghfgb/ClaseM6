namespace aguacanT2.Vistas;

public partial class vParcial1 : ContentPage
{
	string Usuario;
	public vParcial1(string usuario)
	{
		Usuario = usuario;
        InitializeComponent();
		DisplayAlert("bienvenido", usuario, "ok");
		lblUsuario.Text = "Usuario:" + usuario;
	}

    private void botonParcial1_Clicked(object sender, EventArgs e)
    {
        
        if (double.TryParse(parcial1Entry.Text, out double parcial1Nota) &&
            double.TryParse(examenEntry.Text, out double examenNota))
        {
            
            double notaFinal = (parcial1Nota * 0.6) + (examenNota * 0.4);

            
            DisplayAlert("Nota Parcial 1", $"Parcial 1 = {notaFinal}", "Aceptar");

            Navigation.PushAsync(new vParcial2(notaFinal, Usuario));
        }
        else
        {
            
            DisplayAlert("Error", "Por favor ingrese números válidos para las notas.", "Aceptar");
        }
    }
}