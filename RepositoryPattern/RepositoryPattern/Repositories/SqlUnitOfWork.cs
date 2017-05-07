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

        public SqlUnitOfWork()
        {
            this.context = new sacEntities();

            SqlRepository<tblChatroom> chatRooms = new SqlRepository<tblChatroom>();
            chatRooms.Setup(context);

            this.Chatrooms = chatRooms;
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
