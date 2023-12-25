using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.DataAccess.EntityFramework;
using Zust.DataAccess.Abstract;
using Zust.Entities.Models;

namespace Zust.DataAccess.Concrete.EFEntityFramework
{
    public class EFFriendshipDal : EFEntityFrameworkRepositoryBase<Friendship, CustomIdentityDbContext>, IFriendshipDal
    {
    }
}
