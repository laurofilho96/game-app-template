namespace Domain.Rules.Users;

public class PlayerRules
{
    public static void ValidateNickname(string nickname)
    {
        if (string.IsNullOrWhiteSpace(nickname)) throw new ArgumentNullException("Nick inválido.");
        if (nickname.Length < 3) throw new ArgumentException("Nick muito pequeno.");
        if (nickname.Length > 25) throw new ArgumentException("Nick muito grande.");
    }
}
