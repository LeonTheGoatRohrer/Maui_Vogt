using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

/*
    Maui steht für Multiple Application User Interface.
    Es handelt sich um ein plattformübergreifendes Framework von Microsoft,
    
    unterstützte Plattformen:
    - Android
    - iOS
    - Windows
    - macOS
    - Tizen



MVVM (Model-View-ViewModel) entspricht dem MVC Architekturmuster
Model: Datenklassen in c#
View: Darstllung xaml --> XML for Application Markup Language
ViewModel: Beinhaltet die Funktionalität der View mit den Models

Komponenten:
Aus ihnen weredn Pages zusammengebaut
Pages: Ist eine Komplette Seite die aus Komponenten besteht

Bsp für Komponenten:
- Labels
- Buttons
- Entrys (Textfelder)
- Datepicker,...





Layoutmanager:
Spezielle Komponenten 
VerticalStackLayout: Die Komponenten werden untereinander angeordnet
HorizontalStackLayout: Die Komponenten werden nebeneinander angeordnet
grid: Die Komponenten werden in Tabellenform also in Zeilen und Spalten angeordnet

Sinn von layoutmanagern:
Die Layoutmanager berechnen für uns den notwendigen Platz pro Komponenten 
    -Angepasst an das jeweilige Endgerät(Android,iOS,Windows,Tizen...)
Tizen: Betriebssystem für Smart TVs und Wearables


View- Viewmodel Bindung:
zu jeder View(Darstellung) gibt es ein zugehöriges Viewmodel(Funktionalität)

z.B. ArticlePage    ->ArticleViewModel

für das VIewmodel werden 2 Nuget Pakete benötigt:
- CommunityToolkit.Mvvm
- CommunityToolkit.Maui.Mvvm

Diese beiden Pakete erleichtern die Arbeit mit MVVM in MAUI erheblich.


*/


namespace Maui_Basics
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
