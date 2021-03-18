using storage;

namespace repo
{
    public class UnitOfWork
    {
        // context
        WorkOutBuddyContext db_context;

        // collection of repos
        AccountRepo accountRepo;
        // constructor with context injection

        public UnitOfWork(WorkOutBuddyContext db_context)
        {
            this.db_context = db_context;
        }
        // methods that use the repos
        public AccountRepo AccountRepo
        {
            get
            {
                if(accountRepo == null)
                {
                    accountRepo = new AccountRepo(db_context);
                }
                return accountRepo;
            }
        }
        

    }
}