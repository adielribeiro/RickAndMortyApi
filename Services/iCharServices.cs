using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rm.API.Models;

namespace Rm.API.Services
{
    public interface iCharServices
    {
        Task<Models.Char> GetCharById(int id);
    }
}