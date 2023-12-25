using PM2RECU1.Controllers;
using PM2RECU1.Models;
using PM2RECU1.Views;
using Plugin.Maui.Audio;

namespace PM2RECU1 {
    public partial class App : Application {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App() {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new CapturaDatos(AudioManager.Current));
        }

    }
}
