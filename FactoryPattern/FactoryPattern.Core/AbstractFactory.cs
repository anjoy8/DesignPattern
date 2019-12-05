using System;

namespace FactoryPattern.Core
{
    /// <summary>
    /// 抽象工厂类，提供创建不同仓储接口
    /// </summary>
    public abstract class AbstractFactory
    {
        // 抽象工厂提供创建一系列产品的接口
        public abstract UserRepository UserRepository();
        public abstract RoleRepository RoleRepository();
        public abstract PermissionRepository PermissionRepository();
    }
}
