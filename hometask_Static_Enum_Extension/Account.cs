using hometask_Static_Enum_Extension.Interface;


namespace hometask_Static_Enum_Extension
{
    
        public class Account : IAccount
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    
}
