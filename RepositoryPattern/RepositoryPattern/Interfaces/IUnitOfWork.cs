using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<tblChatroom> Chatrooms { get; set; }
        void Commit();
    }
}
