namespace aguacanT2.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}
    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;
        Navigation.PushAsync(new vLogin(usuario, contrase�a));
    }
}