using FactoryPattern.Core;
using System;

namespace FactoryPattern.Repository.Sugar
{
    /// <summary>
    /// Sugar 仓储子工厂
    /// 用来生产各个实体仓储
    /// </summary>
    public class SugarRepositoryFactory : AbstractFactory
    {
        public override PermissionRepository PermissionRepository()
        {
            return new PermissionRepositorySugar();
        }

        public override RoleRepository RoleRepository()
        {
            return new RoleRepositorySugar();
        }

        public override UserRepository UserRepository()
        {
            return new UserRepositorySugar();
        }
    }
}
