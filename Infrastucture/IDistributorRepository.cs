using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IDistributorRepository
    {
        Distributor Get(int id);

        void Add(Distributor distributor);
        void Update(Distributor distributor);
        void Remove(Distributor distributor);
        
    }
}