using hometask_Static_Enum_Extension.Interface;
using System.Security.Principal;

public class AuthService
{
    public string Login(IAccount account, string email, string password)
    {
        if (account.Email == email && account.Password == password)
        {
            if (account.Role == "SuperAdmin")
            {
                if (account.Email == "test@code.edu.az" && account.Password == "test12345")
                {
                    return "Welcom SuperAdmin!";
                }
                else
                {
                    return "Icaze verilmedi";
                }
            }
            else if (account.Role == "Admin")
            {
                return "Welcom Admin";
            }
            else if (account.Role == "Member")
            {
                return "Welcom Member!";
            }
            else
            {
                return "Duzgun rol daxil edilmedi !";
            }
        }
        else
        {
            return "Email veya parol sehfdir tekrar cehd edin";
        }
    }

}