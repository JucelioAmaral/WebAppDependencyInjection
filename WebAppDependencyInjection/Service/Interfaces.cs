using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDependencyInjection.Service
{
    public interface Interfaces
    {

    }
    public interface ITransientService
    {
        Guid GetID();
    }

    public interface IScopedService
    {
        Guid GetID();
    }

    public interface ISingletonService
    {
        Guid GetID();
    }
}
