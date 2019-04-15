using MVVMCustomPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCustomPresentation.Manager
{
    class BoardManager
    {

        public BoardManager()
        {

        }

        public Task<User> GetAdminUserFromSingleBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersFromSingleBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IItem>> GetAllItemsFromSingleBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Board> CreateBoard(User claimant)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBoard(Guid id, User claimant)
        {
            throw new NotImplementedException();
        }

        public Task<Board> UpdateBoard(User claiment, Board updated)
        {
            throw new NotImplementedException();
        }

    }
}
