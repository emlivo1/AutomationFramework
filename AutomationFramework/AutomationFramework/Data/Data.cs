using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Data
{
    public class Data
    {
        #region Elements
        private static string randomUniqueString = "";
        private static string uniqueEmail = "";
        private static string uniquePassword = "test123";
        private static string firstName = "Meho";
        private static string lastName = "Suljic";
        private  Dictionary<string, string> dataList= new Dictionary<string, string>();
        #endregion

        public Data()
        {
            dataList.Add("firstName", "Meho");
            dataList.Add("lastName", "Suljic");
            dataList.Add("pass", "test123");
            dataList.Add("company", "Bingo");
            dataList.Add("address1", "Trg solidarnosti, 2, SyVe");
            dataList.Add("city", "Bugojno");
            dataList.Add("postcode", "77230");
            dataList.Add("phone_number", "+38761111222");
            dataList.Add("address_alias", "delilaamra@test.com");
            dataList.Add("days", "4");
            dataList.Add("months", "3");
            dataList.Add("years", "1998");
            dataList.Add("state", "5");
        }

        public Dictionary<string, string> getDictionary()
        {
            return dataList;
        }

        #region Public methods
        public string GenerateUniqueText()
        {
            randomUniqueString = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
            return randomUniqueString;
        }
    
        public string GenerateEmail()
        {
            randomUniqueString = GenerateUniqueText();
            uniqueEmail = randomUniqueString + "@test.com";
            return uniqueEmail;
        }

        public string GetUniqueEmail()
        {
            return uniqueEmail;
        }

        public string GetPass()
        {
            return uniquePassword;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }



        #endregion
    }
}
