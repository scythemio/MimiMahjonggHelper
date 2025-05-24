// Platforms/Android/MainApplication.cs
// This entire block should be the content of your Platforms/Android/MainApplication.cs file
using Android.App;
using Android.Runtime;

// Ensure this namespace matches your project's root namespace
namespace MimiMahJonggHelperReal; 

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

    // The MauiProgram class should be in the MimiMahJonggHelperReal namespace
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); 
}