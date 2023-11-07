using App_Net_Maui_Controle_EPI.Context;
using App_Net_Maui_Controle_EPI.Data;
using App_Net_Maui_Controle_EPI.Model;
using App_Net_Maui_Controle_EPI.Pages;

namespace App_Net_Maui_Controle_EPI;

public partial class App : Application
{
	
	public App()
	{
		InitializeComponent();
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
        }
        MainPage = new NavigationPage(new LoginPage());
	}
}
