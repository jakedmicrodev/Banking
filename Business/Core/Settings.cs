using System;
using System.Configuration;

namespace Business.Core
{
    public static class Settings
    {
        private static string bankingConnectionString = string.Empty;

        public static string BankingConnectionString
        {
            get
            {
                if (String.IsNullOrWhiteSpace(bankingConnectionString))
                {
                    bankingConnectionString = ConfigurationManager.ConnectionStrings["BANKING"].ToString();
                }
                return bankingConnectionString;
            }
        }
    }
}