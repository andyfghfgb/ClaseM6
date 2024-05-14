namespace aguacanT2.Vistas;

public partial class vParcial2 : ContentPage
{
    private double _notaFinal;
    private string _usuario;
    public vParcial2(double notaFinal, string usuario)
	{
		InitializeComponent();
        _notaFinal = notaFinal;
        _usuario = usuario;

        DisplayAlert("notaparcial1", _notaFinal.ToString(), "ok");
        notafinal1.Text = "Nota Primer Parcial: " + _notaFinal;

    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        
        if (double.TryParse(entrydeberes2.Text, out double parcialNota2) &&
            double.TryParse(entryexamen2.Text, out double examenNota2))
        {
           
            double notaFinal2 = (parcialNota2 * 0.6) + (examenNota2 * 0.4);

            
            double sumaMedias = (_notaFinal / 2) + (notaFinal2 / 2);
            DateTime fechaSeleccionada = dateparcial2.Date;

            
            DisplayAlert("Notas Finales: \nUsuario: " + _usuario, $"Parcial 1: {_notaFinal}\nParcial 2: {notaFinal2}\nPromedio Final: {sumaMedias}\nFecha : {fechaSeleccionada.ToString("dd/MM/yyyy")}", "Aceptar");
        }
        else
        {
           
            DisplayAlert("Error", "Por favor ingrese números válidos para las notas.", "Aceptar");
        }
    }
}