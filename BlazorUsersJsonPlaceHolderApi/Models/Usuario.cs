namespace BlazorUsersJsonPlaceHolderApi.Models;

public class Usuario
{
    public string Name { get; set; } = "";
    public Endereco Address { get; set; } = new Endereco();
    public Empresa Company { get; set; } = new Empresa();
}
