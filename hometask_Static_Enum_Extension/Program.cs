using hometask_Static_Enum_Extension.Interface;

namespace hometask_Static_Enum_Extension
{
    class Program
    {
      
        static void Main(string[] args)
        {
            #region task1
            //IAccount account = new Account
            //{
            //    Email = "test@code.edu.az",
            //    Password = "test12345",
            //    Role = "SuperAdmin"
            //};

            //IAccount accountm = new Account
            //{
            //    Email = "test",
            //    Password = "test",
            //    Role = "Admin"
                
            //};

            //AuthService authService = new AuthService();

            //Console.WriteLine("E-post adresini daxil edin");
            //string email = Console.ReadLine();

            //Console.WriteLine("Sifreni daxil edin");
            //string password = Console.ReadLine();

            //string result = authService.Login(account, email, password);
            //Console.WriteLine(result);

            #endregion

            int? result = (5).Factorial();
            if (result == null)
            {
                Console.WriteLine("Menfi Faktoryal hesablanmir");
            }
            else
            {
                Console.WriteLine("Faktoryal: " + result.Value);
            }

        }

    }
}
