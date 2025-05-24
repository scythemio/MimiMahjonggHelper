using Foundation;
using MimiMahJonggHelperReal; // CRITICAL: This 'using' directive makes MauiProgram visible

namespace MimiMahJonggHelperReal; // CRITICAL: Namespace should match

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // This line causes the error if MauiProgram is not found
}