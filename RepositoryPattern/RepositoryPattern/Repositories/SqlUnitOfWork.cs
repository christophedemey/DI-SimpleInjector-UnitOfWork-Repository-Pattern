using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private DbContext context = null;

        public SqlUnitOfWork(DbContext dbContext, IRepository<tblChatroom> chatrooms)
        {
            context = dbContext;
            Chatrooms = chatrooms;
        }

        public IRepository<tblChatroom> Chatrooms { get; set; }

        public void Commit()
        {
            if (context.ChangeTracker.HasChanges())
            {
                context.SaveChanges();
            }
        }
    }
}
