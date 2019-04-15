using MVVMCustomPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCustomPresentation.Services
{
    class BoardApiResponse
    {
        public Guid Id { get; set; }
        public string Description {get;set;}

        public User Owner { get; set; }
    }
}
