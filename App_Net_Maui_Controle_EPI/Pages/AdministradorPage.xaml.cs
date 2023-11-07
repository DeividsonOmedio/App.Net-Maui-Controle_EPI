using App_Net_Maui_Controle_EPI.Pages.AdministradorPages;

namespace App_Net_Maui_Controle_EPI.Pages;

public partial class AdministradorPage : TabbedPage
{
	public AdministradorPage()
	{
		InitializeComponent();

        var pagina1 = new DashboardPage()
        {
            Title = "Dashboard",
            IconImageSource = ""
        };

        var pagina2 = new EpiPage()
        {
            Title = "Epi",
            IconImageSource = ""
        };
        var pagina3 = new FuncionariosPage()
        {
            Title = "Funcionarios",
            IconImageSource = ""
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}
