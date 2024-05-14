namespace aguacanT2.Vistas;

public partial class vLogin : ContentPage
{
    string usuario1;
    string contraseña1;

    public vLogin(string usuario, string contraseña)
    {
        InitializeComponent();
        usuario1 = usuario;
        contraseña1 = contraseña;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        //String usuario = "Andy";
        //String contraseña = "12345";

        if (usuario1 == txtUsuario.Text && contraseña1 == txtContraseña.Text)
        {
            Navigation.PushAsync(new vElementos(usuario1));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Aceptar");
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}

