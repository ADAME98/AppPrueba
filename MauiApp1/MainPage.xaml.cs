using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        // Define la colección que actuará como fuente de datos para el ListView
        public ObservableCollection<Archivo> Items { get; set; } = new ObservableCollection<Archivo>();

        public MainPage()
        {
            InitializeComponent();

            // Asigna la colección al BindingContext del ListView
            BindingContext = this;
        }

        private void OnConectarClicked(object sender, EventArgs e)
        {
            // Simulación de la conexión exitosa
            bool conexionExitosa = SimularConexion();

            if (conexionExitosa)
            {
                // Habilitar los botones de subir, descargar y actualizar lista
                btnSubir.IsEnabled = true;
                btnDescargar.IsEnabled = true;
                btnActualizarLista.IsEnabled = true;

                // Simulación de la carga de archivos
                CargarArchivosFicticios();
            }
            else
            {
                // Mostrar un mensaje de error si la conexión falla
                DisplayAlert("Error", "No se pudo conectar. Por favor, revise las credenciales.", "OK");
            }
        }

        private bool SimularConexion()
        {
            // Simulación de validación de credenciales
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtPassword.Text;

            const string UsuarioFicticio = "usuario";
            const string ContraseñaFicticia = "contraseña";

            return usuarioIngresado == UsuarioFicticio && contraseñaIngresada == ContraseñaFicticia;
        }

        private void CargarArchivosFicticios()
        {
            // Simulación de carga de archivos ficticios
            Items.Clear(); // Limpiar la lista actual

            // Agregar archivos ficticios
            Items.Add(new Archivo { Nombre = "archivo1.txt", Icono = "archivo_icono.png" });
            Items.Add(new Archivo { Nombre = "documento2.pdf", Icono = "documento_icono.png" });
            Items.Add(new Archivo { Nombre = "imagen3.png", Icono = "imagen_icono.png" });
            // Agregar más archivos según sea necesario
        }
    }

    public class Archivo
    {
        public string? Nombre { get; set; }
        public string? Icono { get; set; }
    }
}
