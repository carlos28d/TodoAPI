using TodoApi.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.API.Interfaces
{
    public interface ITokenService
    {
        //Clase vs. clase abstracta vs. interfaz/interface
        string CreateToken(AppUser user);
    }
}