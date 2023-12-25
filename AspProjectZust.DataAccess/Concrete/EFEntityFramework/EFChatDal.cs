using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.DataAccess.EntityFramework;
using Zust.Entities.Models;

namespace Zust.DataAccess.Concrete.EFEntityFramework
{
    public class EFChatDal
    {
        public EFChatDal():EFEntityFrameworkRepositoryBase<Chat>
        {
        }
    }
}
