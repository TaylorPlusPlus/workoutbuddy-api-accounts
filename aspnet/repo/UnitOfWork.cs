using storage;

namespace repo
{
    public class UnitOfWork
    {
        // context
        WorkOutBuddyContext db_context;

        // collection of repos
        AccountRepo accountRepo;
        CardRepo cardRepo;  
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

        public CardRepo CardRepo
        {
            get
            {
                if(cardRepo == null)
                {
                    cardRepo = new CardRepo(db_context);
                }
                return cardRepo;
            }
        }
        

    }
}