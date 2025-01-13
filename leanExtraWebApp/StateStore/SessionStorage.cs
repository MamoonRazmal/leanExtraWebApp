using leanExtraWebApp.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace leanExtraWebApp.StateStore
{
    public class SessionStorage
    {
        private readonly ProtectedSessionStorage protectedSessionStorage;
        public SessionStorage(ProtectedSessionStorage protectedSessionStorage)
        {
            this.protectedSessionStorage = protectedSessionStorage;
        }
        public async Task<Server?> GetServerAsync()
        {
            var result = await this.protectedSessionStorage.GetAsync<Server>("server");
            if(result.Success)
            return result.Value;
            else return null;
        }
        public async  Task SetServerAsync(Server server)
        {
            await this.protectedSessionStorage.SetAsync("server",server);
        }

         public async Task<Server> GetCityAsync()
        {
            var result = await this.protectedSessionStorage.GetAsync<Server>("city");
            if(result.Success)
            return result.Value;
            else return null;
        }
        public async Task SetCityAsync(String ? city)
        {
            await this.protectedSessionStorage.SetAsync("server",city);
        }
    }
}