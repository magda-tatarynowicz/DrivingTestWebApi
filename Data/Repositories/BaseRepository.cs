using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public abstract class BaseRepository
    {
        protected DrivingTestContext Context { get; set; }
        protected BaseRepository(DrivingTestContext context)
        {
            Context = context;
        }
    }
}
