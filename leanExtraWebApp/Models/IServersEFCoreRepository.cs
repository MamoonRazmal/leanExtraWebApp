using System.Collections.Generic;
using leanExtraWebApp.Data;

namespace leanExtraWebApp.Models
{
    public interface IServersEFCoreRepository
    {
        void AddServer(Server server);
        List<Server> GetServer();
        List<Server> GetServersByCity(string cityName);
        Server GetSetById(int id);
        void UpdateServer(int serverid, Server server);
        void DeleteServer(int serverid);
        List<Server> Search(string searchfilter);
    }
}
