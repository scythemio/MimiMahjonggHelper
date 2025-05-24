// Platforms/Windows/App.xaml.cs
// (This is the Windows-specific App.xaml.cs file)
using Microsoft.UI.Xaml;
using MimiMahJonggHelperReal; // Add this using directive

namespace MimiMahJonggHelperReal.WinUI; // This is a typical WinUI namespace

public partial class App : MauiWinUIApplication
{
    public App()
    {
        this.InitializeComponent();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // Now MauiProgram should be found
}