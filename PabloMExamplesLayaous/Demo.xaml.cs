using PabloMExamplesLayaous.Repositorios;

namespace PabloMExamplesLayaous;

public partial class Demo : ContentPage
{
	private ManejoArchivosRepository _repo;
	public Demo()
	{
		_repo = new ManejoArchivosRepository();
		InitializeComponent();
		ObtenerInformacionArchivo();
	}
	private async Task ObtenerInformacionArchivo()
	{
        TextoArchivo.Text = await _repo.ObtenerInfromacionArchivo();
    }

    private async void Boton_Clicked(object sender, EventArgs e)
    {
		string testo = Texto1.Text;
		Boolean guardar = await _repo.GuardarArchivo(testo);
		//Actualiza el archivo
        TextoArchivo.Text = await _repo.ObtenerInfromacionArchivo();

        if (!guardar)
		{
			throw new Exception("No se pudo guardar el archivo");
        }
    }
}