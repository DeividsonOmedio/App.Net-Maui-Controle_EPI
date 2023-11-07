using App_Net_Maui_Controle_EPI.Context;
using App_Net_Maui_Controle_EPI.Data;
using App_Net_Maui_Controle_EPI.Model;

namespace App_Net_Maui_Controle_EPI.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        try
        {

            using (var db = new AppDbContext())
            {
                var items = db.users.FirstOrDefault(x => x.Name == "Admin");
                if (items == null)
                {
                    Usuario userAdmin = new Usuario();
                    userAdmin.Name = "Admin";
                    userAdmin.Senha = "admin123";
                    userAdmin.Codigo = 123;
                    userAdmin.Funcao = "admin";

                    db.users.Add(userAdmin);
                    db.SaveChanges();
                }

                

            }

        }
        catch
        {
            return;
        }
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string senha = txtSenha.Text;

        if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(senha))
        {
            using (var db = new AppDbContext())
            {
                var response = db.users.FirstOrDefault(x => x.Name == user && x.Senha == senha);
                if (response == null)
                {
                    await DisplayAlert("Ateñção", "Email ou Senha Invalido", "Fechar");
                    return;
                }
                else
                {
                    await Navigation.PushAsync(new AdministradorPage());
                }
            }
        }
    }


    private void btnEntrarAdm_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AdministradorPage());
    }



    private void btnEntrarAlm_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AlmoxarifePage());
    }

    private void btnEntrar_Func_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FuncionarioPage());
    }

    
}