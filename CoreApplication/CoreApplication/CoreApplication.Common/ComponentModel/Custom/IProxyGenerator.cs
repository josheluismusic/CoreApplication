using System;

namespace CoreApplication.Common.ComponentModel.Custom
{
    public interface IProxyGenerator
    {
        T BuildProxy<T>( string realTypeFullName ) where T : class;
    }
}
