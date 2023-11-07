using App_Net_Maui_Controle_EPI.Pages.AlmoxarifePages;

namespace App_Net_Maui_Controle_EPI.Pages;

public partial class AlmoxarifePage : TabbedPage
{
	public AlmoxarifePage()
	{
		InitializeComponent();

        var pagina1 = new DashboardPage()
        {
            Title = "Dashboard",
            IconImageSource = ""
        };

        var pagina2 = new EmprestadosPage()
        {
            Title = "Emprestados",
            IconImageSource = ""
        };
        var pagina3 = new EpiPage()
        {
            Title = "Epi's",
            IconImageSource = ""
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}
