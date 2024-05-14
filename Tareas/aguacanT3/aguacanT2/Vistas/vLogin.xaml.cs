namespace aguacanT2.Vistas;

public partial class vLogin : ContentPage
{
    string usuario1;
    string contrase�a1;

    public vLogin(string usuario, string contrase�a)
    {
        InitializeComponent();
        usuario1 = usuario;
        contrase�a1 = contrase�a;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        //String usuario = "Andy";
        //String contrase�a = "12345";

        if (usuario1 == txtUsuario.Text && contrase�a1 == txtContrase�a.Text)
        {
            Navigation.PushAsync(new vElementos(usuario1));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contrase�a incorrectos", "Aceptar");
            txtUsuario.Text = "";
            txtContrase�a.Text = "";
        }
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}

