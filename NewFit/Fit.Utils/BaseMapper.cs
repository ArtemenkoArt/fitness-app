using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit.NewFit
{
    abstract class BaseMapper
    {
        public int Id = 0;

        abstract protected Dictionary<string, object> GetData();

        abstract protected int Insert(BaseMapper baseMapper);

        abstract protected void Update(BaseMapper baseMapper);

        abstract protected void Delete(int id);

        abstract protected BaseMapper GetDetails(int id);

        abstract protected BaseMapper GetClientLast(int id);
    }
}
