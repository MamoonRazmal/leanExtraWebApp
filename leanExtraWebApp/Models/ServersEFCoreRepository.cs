using leanExtraWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace leanExtraWebApp.Models
{
    public class ServersEFCoreRepository : IServersEFCoreRepository
    {
        private readonly IDbContextFactory<ServerManagmentContext> contextFactory;

        public ServersEFCoreRepository(IDbContextFactory<ServerManagmentContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void AddServer(Server server)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.Servers.Add(server);
            db.SaveChanges();
        }

        public List<Server> GetServer()
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Servers.ToList();
        }

        public List<Server> GetServersByCity(string cityName)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Servers.Where(x => x.City != null && x.City.ToLower().IndexOf(cityName.ToLower()) >= 0).ToList();
        }

        public Server GetSetById(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            var server = db.Servers.Find(id);
            if (server is not null) return server;
            return new Server();
        }

        public void UpdateServer(int serverid, Server server)
        {
            if (server is null) throw new ArgumentNullException(nameof(server));
            if (serverid != server.ServerId) return;

            using var db = this.contextFactory.CreateDbContext();
            var serverToUpdate = db.Servers.Find(serverid);
            if (serverToUpdate is not null)
            {
                serverToUpdate.IsOnline = server.IsOnline;
                serverToUpdate.Name = server.Name;
                serverToUpdate.City = server.City;
                db.SaveChanges();
            }
        }

        public void DeleteServer(int serverid)
        {
            using var db = this.contextFactory.CreateDbContext();
            var server = db.Servers.Find(serverid);
            if (server is null) return;

            db.Servers.Remove(server);
            db.SaveChanges();
        }

        public List<Server> Search(string searchfilter)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Servers.Where(x => x.Name != null && x.Name.ToLower().IndexOf(searchfilter.ToLower()) >= 0).ToList();
        }
    }
}
