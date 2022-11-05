using E_Commerce_V2.Data.Base;
using E_Commerce_V2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class SubLineasService : EntityBaseRepository<SubLinea>, ISubLineasService
    {
        public SubLineasService(AppDbContext context): base(context)
        {
        }

     
    }
}
