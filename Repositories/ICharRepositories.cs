using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rm.API.Models;

namespace Rm.API.Repositories
{
    public interface ICharRepositories 
    {
        public void  SalvarChar(Models.Char novChar);
    }
}