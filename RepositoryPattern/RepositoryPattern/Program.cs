using RepositoryPattern.Interfaces;
using RepositoryPattern.Repositories;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = ComposeRoot();

            IUnitOfWork unitOfWork = container.GetInstance<IUnitOfWork>();
            IRepository<tblChatroom> repository = unitOfWork.Chatrooms;

            //Add row and commit.
            repository.Add(new tblChatroom() { ChatroomName = "woopx" });
            unitOfWork.Commit();

            //Find row and update and commit.
            tblChatroom chatroom = repository.Find(row => row.ChatroomName == "woopx").FirstOrDefault();
            chatroom.ChatroomName = "nope";
            unitOfWork.Commit();

            //Find row again and delete it.
            tblChatroom chatroomAgain = repository.Find(row => row.ChatroomName == "nope").FirstOrDefault();
            repository.Remove(chatroomAgain);
            unitOfWork.Commit();

            //Check to see if row is actually deleted.
            tblChatroom chatroomAx = repository.Find(row => row.ChatroomName == "nope").FirstOrDefault();
            int x = 1 + 1;

            using (ThreadScopedLifestyle.BeginScope(container))
            {

            }

            ////Create context + repository.
            //DbContext entities = new sacEntities();
            //IRepository<tblChatroom> repository = new SqlRepository<tblChatroom>(entities);

            ////Create unit of work.
            //IUnitOfWork unitOfWork = new SqlUnitOfWork(entities, repository);

            ////Add row and commit.
            //repository.Add(new tblChatroom() { ChatroomName = "woopx" });
            //unitOfWork.Commit();

            ////Find row and update and commit.
            //tblChatroom chatroom = repository.Find(row => row.ChatroomName == "woopx").FirstOrDefault();
            //chatroom.ChatroomName = "nope";
            //unitOfWork.Commit();

            ////Find row again and delete it.
            //tblChatroom chatroomAgain = repository.Find(row => row.ChatroomName == "nope").FirstOrDefault();
            //repository.Remove(chatroomAgain);
            //unitOfWork.Commit();

            ////Check to see if row is actually deleted.
            //tblChatroom chatroomAx = repository.Find(row => row.ChatroomName == "nope").FirstOrDefault();
            //int x = 1 + 1;
        }

        private static Container ComposeRoot()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();

            //Bussines Logic controllers.
            container.Register<DbContext>(() => new sacEntities(), Lifestyle.Scoped);
            container.Register<IRepository<tblChatroom>, SqlRepository<tblChatroom>>(Lifestyle.Transient);
            container.Register<IUnitOfWork, SqlUnitOfWork>(Lifestyle.Transient);

            container.Verify();

            return container;
        }
    }
}
