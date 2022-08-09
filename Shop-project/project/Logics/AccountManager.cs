using project.Models;
using System.Linq;

namespace project.Logics
{
    public class AccountManager
    {
        public Account getAccount(string username,string password)
        {
            Account a;
             using (var context = new Shop_PRNContext())
            {
                a = context.Accounts.FirstOrDefault(x => x.Username.Equals(username) && x.Password == password);
            };
            return a;
        }
        public bool checkExist(string username, string password)
        {
            Account account=getAccount("username","password");
            return account != null;
        }
        public void UpdateInformation(Account account)
        {
            using(var context = new Shop_PRNContext())
            {
                Account x=context.Accounts.FirstOrDefault(x => x.Username.Equals(account.Username));
                x.Name=account.Name;
                if (account.Mobile != null)
                {
                  x.Mobile=account.Mobile;
                }
                x.Address=account.Address;
                x.City=account.City;
                x.Gender=account.Gender;
                x.Dob=account.Dob;
                context.SaveChanges();
            }
        }
      public Account Refresh(string username)
        {
            Account account;
            using(var context =new Shop_PRNContext())
            {
                 account = context.Accounts.FirstOrDefault(x => x.Username.Equals(username));
            }
            return account;
        }
      
      public bool CheckAccount(string user_name,string password)
        {
            Account a;
            using( var context = new Shop_PRNContext())
            {
               a= context.Accounts.FirstOrDefault(x => x.Username.Equals(user_name) && x.Password.Equals(password));
            }
            if (a == null) { return false; }
            else { return true; }
        }
      public void ChangePassword(string user_name, string newPass)
        {
            Account a;
            using ( var context = new Shop_PRNContext())
            {
             
                 a = context.Accounts.FirstOrDefault(x => x.Username.Equals(user_name));
                a.Password=newPass;
                context.SaveChanges();
            }
        }
    }
}
