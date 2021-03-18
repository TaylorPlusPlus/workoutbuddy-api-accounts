using System.Linq;
using domain.models;
using storage;

namespace repo
{
    public class AccountRepo
    {
        //Context
        private WorkOutBuddyContext _db;
    
        //Context Injection
        public AccountRepo(WorkOutBuddyContext _dbContext)
        {
            _db = _dbContext;
        }
        // Methods
        public AccountModel Get(string Email)
        {
            return _db.Accounts.SingleOrDefault(x => x.Email == Email);
        }

    }
}