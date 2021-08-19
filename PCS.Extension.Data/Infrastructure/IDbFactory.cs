using PCS.Extension.Data.EF;
using System;

namespace PCS.Extension.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ExtensionContext Init();
    }
}
