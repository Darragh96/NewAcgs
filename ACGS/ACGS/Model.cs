using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACGS
{



    /*public interface imodel
    {
        bool login(string name, string password);
        void tearDown();
    }
    internal class Model 
    {
        
        private List<IUser> userList;
        private IUser currentUser;
        public interface IUser
        {
            string Name { get; set; }
            string Password { get; set; }
            string UserType { get; set; }
            int UserID { get; set; }
            string email { get; set; }
            int age { get; set; }
            int phone { get; set; }
        }

        public Boolean login(String name, String password)
        {

            //foreach (User user in userList) // now using template so can simplify this code as shown below
            //{
            //    if (name == user.Name && password == user.Password)
            //    {

            //        CurrentUser=user;
            //        return true;
            //    }
            //}
            //return false;

            IUser matchUser = userList.FirstOrDefault(user => user.Name == name && user.Password == password);
            if (matchUser == null)
            {
                return false;
            }
            else
            {
                CurrentUser = matchUser;
                return true;
            }
          
        }
        public String getUserTypeForCurrentuser()
        {
            return currentUser.UserType;
        }

        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }
    }*/
}
