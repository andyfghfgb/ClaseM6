namespace aguacanT2.Vistas;

public partial class vElementos : ContentPage
{
	public vElementos(string usuario )
	{
        InitializeComponent();
        DisplayAlert("Bienvenido", usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + usuario;
    }
    private void bntPicker_Clicked(object sender, EventArgs e)
    {
        if (pkCiudades.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Selecciona una Ciudad", "Aceptar");
        }
        else
        {
            String ciudadselect = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();

            //String ciudadselect = pkCiudades.SelectedItem.ToString();

            //DisplayAlert("Muy Bien", "Tu ciudad preferida es " + ciudadselect + "", "Aceptar");

            lblDatop.Text = "Tu ciudad preferida es " + ciudadselect;

        }
    }

    private void btnFechas_Clicked(object sender, EventArgs e)
    {
        String fecha = dpFecha.Date.ToString();
        lblDatop.Text = "El dato seleccinado es " + fecha;
    }
}