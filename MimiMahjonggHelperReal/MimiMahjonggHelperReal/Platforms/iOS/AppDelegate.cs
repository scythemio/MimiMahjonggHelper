using Foundation;
using MimiMahJonggHelperReal; // Ensures MauiProgram is found

namespace MimiMahJonggHelperReal;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}