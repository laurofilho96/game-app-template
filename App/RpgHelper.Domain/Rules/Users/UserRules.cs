namespace Domain.Rules.Users;

public class UserRules
{
    public static void VerifyName(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException("Nome inválido.");
    }
    public static void VerifyPassword(string password) 
    {
        if(string.IsNullOrWhiteSpace(password))
            throw new ArgumentNullException("Senha inválida.");
    }
    public static void VerifyEmail(string email) 
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("email inválido.");
    }
}
