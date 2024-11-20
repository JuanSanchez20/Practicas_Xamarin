using System;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GeolocationApp
{
    public partial class GeolocationPage : ContentPage
    {
        private CancellationTokenSource cts;
        private bool isTracking = false;

        public GeolocationPage()
        {
            InitializeComponent();
        }

        // Evento que se dispara al presionar el botón "Obtener Ubicación"
        private async void OnGetLocationClicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }

                if (location != null)
                {
                    latitudeLabel.Text = $"Latitud: {location.Latitude}";
                    longitudeLabel.Text = $"Longitud: {location.Longitude}";
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo obtener la ubicación", "OK");
                }
            }
            catch (FeatureNotSupportedException)
            {
                await DisplayAlert("Error", "Función no soportada en este dispositivo", "OK");
            }
            catch (PermissionException)
            {
                await DisplayAlert("Error", "Permisos de ubicación denegados", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al obtener la ubicación: {ex.Message}", "OK");
            }
        }

        // Iniciar el rastreo simulado de ubicación
        private void OnStartTrackingClicked(object sender, EventArgs e)
        {
            if (isTracking)
            {
                return; // Ya está rastreando
            }

            isTracking = true;
            cts = new CancellationTokenSource();

            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                if (isTracking && !cts.Token.IsCancellationRequested)
                {
                    GetLocationContinuously();
                    return true; // Continua con el temporizador
                }
                return false; // Detiene el temporizador
            });

            DisplayAlert("Éxito", "Rastreo de ubicación iniciado", "OK");
        }

        // Detener el rastreo de ubicación
        private void OnStopTrackingClicked(object sender, EventArgs e)
        {
            if (!isTracking)
            {
                return; // No estaba rastreando
            }

            isTracking = false;
            cts.Cancel(); // Detiene el temporizador
            DisplayAlert("Éxito", "Rastreo de ubicación detenido", "OK");
        }

        // Obtener la ubicación continuamente
        private async void GetLocationContinuously()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(10)
                });

                if (location != null)
                {
                    latitudeLabel.Text = $"Latitud: {location.Latitude}";
                    longitudeLabel.Text = $"Longitud: {location.Longitude}";
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores durante el rastreo
                await DisplayAlert("Error", $"Error al obtener la ubicación: {ex.Message}", "OK");
            }
        }
    }
}
