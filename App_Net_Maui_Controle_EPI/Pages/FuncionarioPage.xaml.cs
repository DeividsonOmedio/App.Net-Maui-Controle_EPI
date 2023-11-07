using App_Net_Maui_Controle_EPI.Pages.FuncionarioPages;

namespace App_Net_Maui_Controle_EPI.Pages;

public partial class FuncionarioPage : TabbedPage
{
	public FuncionarioPage()
	{
		InitializeComponent();

        var pagina1 = new DashboardPage()
        {
            Title = "Dashboard",
            IconImageSource = ""
        };

        var pagina2 = new SolicitacaoPage()
        {
            Title = "Solicitacao",
            IconImageSource = ""
        };
        var pagina3 = new ListaEpiPage()
        {
            Title = "Lista Epi's",
            IconImageSource = ""
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}
