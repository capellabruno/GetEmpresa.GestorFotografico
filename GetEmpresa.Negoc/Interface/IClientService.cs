using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundoDaFoto.Domain;

namespace GetEmpresa.Negoc.Interface
{
    public interface IClientService
    {
        IList<Client> GetAll();
        Client GetById(long id);
        void Add(Client _client);
        void Update(Client _client);
        void Remove(Client _client);
    }
}
