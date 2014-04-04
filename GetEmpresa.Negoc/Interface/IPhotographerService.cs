using MundoDaFoto.Dominio.Photographer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmpresa.Negoc.Interface {
    public interface IPhotographerService {
        bool HasProfile(string _email);
        PhotographerProfile GetProfile(string _email);
    }// class
}
