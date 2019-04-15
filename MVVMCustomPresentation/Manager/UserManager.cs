using MVVMCustomPresentation.Models;
using MVVMCustomPresentation.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCustomPresentation.Manager
{
    class UserManager
    {
        private RestClient Client { get; }

        public UserManager()
        {
            Client = new RestClient("https://localhost:44320/api");
        }

        /*public async Task<List<User>> GetAllUsersAsync()
        {
            var req = new RestRequest("/Users/", Method.GET);

            IRestResponse<List<UserApiResponse>> res = Client.Execute<List<UserApiResponse>>(req);

            List<User> users = new List<User>();

            foreach (var user in res.Data)
            {
                users.Add(new User
                {
                    Id = user.Id,
                    Username = user.Username,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Boards = await Task.Run(() => GetBoardsFromSingleUser(user.Id))
                });
            }

            return await Task.Run(() => users);


        }*/

        public async Task<List<Guid>> GetAllUsersGuid()
        {
            var req = new RestRequest("/Users/Guids", Method.GET);

            IRestResponse<List<Guid>> res = Client.Execute<List<Guid>>(req);

            return await Task.Run(() => res.Data);
        }


        public Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Guid>> GetBoardsGuidFromSingleUserAsync(Guid id)
        {
            var req = new RestRequest($"/Users/{id}/boards");

            IRestResponse<List<Guid>> res = Client.Execute<List<Guid>>(req);

            return await Task.Run(() => res.Data);
        }

        public Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}
