using Game.GameAccount;
using System.Collections.Generic;

namespace Game.DB
{

    public interface IUserService
    {
        List<BaseAccount> Get();
        void Add(BaseAccount User);
    }
}
