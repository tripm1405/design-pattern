using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ByCotton
{
    class Account
    {
        public string username;
        public string name;
        public string email;
        public Nullable<bool> gender;
        public string address;
        public string phone;

        public Account()
        {
            this.username = null;
            this.name = null;
            this.email = null;
            this.gender = null;
            this.address = null;
            this.phone = null;
        }
    }

    class Product
    {
        public string name;
        public int amount;
        public string image;
        public int price;
    }
    
    class Validation
    {
        //check khoảng trắng
        public Boolean checkSpace(String s)
        {
            if(s.Trim() == "")
            {
                return false;
            }
            return true;
        }
        //check độ dài
        public Boolean checkLength(String s)
        {
            if (s.Length < 6)
            {
                return false;
            }
            return true;
        }
        //check email
        public Boolean checkEmail(String s)
        {

            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(s))
                return (true);
            else
                return (false);
        
        }

        //check sdt
        public Boolean checkPhoneNumber(String s)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
             Regex re = new Regex(strRegex);
            if (re.IsMatch(s))
                return (true);
            else
                return (false);
        }
        //check tất cả là số
        public Boolean checkAllNumbers(String s)
        {
            string strRegex = @"^-?[0-9][0-9,\.]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(s))
                return (true);
            else
                return (false);
        }
       
    }

    static class Global
    {
        public static string IMAGE_PATH = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\public\\images\\";
        public static string DATABASE = "Data Source=LAPTOP-5HLVG267;Initial Catalog=BY_COTTON;Integrated Security=True";

        public static Account account = null;
        public static Dictionary<string, Product> cart = new Dictionary<string, Product>();

        public static int invoiceID;
    }
}
