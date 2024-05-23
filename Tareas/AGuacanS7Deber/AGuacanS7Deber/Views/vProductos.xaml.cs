using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace AGuacanS7Deber.Views;

public partial class vProductos : ContentPage
{
    private const string Url = "http://localhost/appmovil/post.php";
    private readonly HttpClient cliente = new HttpClient();
    private ObservableCollection<Estudiante> estud;

    public vProductos()
	{
		InitializeComponent();
        Obtener();
	}
    public async void Obtener()
    {
        var content = await cliente.GetStringAsync(Url);
        List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        estud = new ObservableCollection<Estudiante>(mostrarEst);
        listaEstudiantes.ItemsSource = estud;
    }

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAgregar());
    }

    private void listaEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var objestudiante = (Estudiante)e.SelectedItem;
        Navigation.PushAsync(new vEditar(objestudiante));
    }
}