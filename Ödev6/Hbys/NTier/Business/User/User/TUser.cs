using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{

    public struct TUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class TUserProcess : IUserProcess
    {
        private TUser User;
        public TUserProcess()
        {
            User = new TUser();
        }

        public TUserProcess(int UserId)
        {
            User = new TUser();
            User.Id = UserId;
        }

        public TUserProcess(TUser User)
        {
            this.User = User;
        }

        public bool AddUser(TUser user, out string OMessage, out int UserId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int UserId, out string OMessage)
        {
            throw new NotImplementedException();
        }

        public List<TUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<TUser> GetUsers(int UserId)
        {
            throw new NotImplementedException();
        }

        public List<TUser> GetUsers(string UserName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(TUser user, out string OMessage)
        {
            throw new NotImplementedException();
        }
    }

}
