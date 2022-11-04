using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class LineasService :EntityBaseRepository<Linea>,  ILineasService
    {
        public LineasService(AppDbContext context): base(context) {}

    }
}
