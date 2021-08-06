using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDependencyInjection.Service;

namespace WebAppDependencyInjection.Models
{
    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public SomeService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
