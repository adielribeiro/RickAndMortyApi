using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Rm.API.Models;
using Rm.API.Context;
using Microsoft.EntityFrameworkCore;

namespace Rm.API.Repositories
{
    public class CharRepositories : ICharRepositories
    {
        public readonly AppDBContext _context;
        public CharRepositories(AppDBContext context)
        {
            _context = context;
        }

        public void SalvarChar(Models.Char novoChar)
        {
            _context.Char2.Add(novoChar);
            _context.SaveChanges();
        }
    }
}