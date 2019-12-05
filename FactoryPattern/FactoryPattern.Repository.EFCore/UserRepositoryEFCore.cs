using FactoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Repository.EFCore
{
    /// <summary>
    /// EFCore User 仓储，继承User仓储
    /// </summary>
    public class UserRepositoryEFCore : UserRepository
    {
        public override void Add()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Query()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
