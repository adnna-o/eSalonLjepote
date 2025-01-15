using eSalonLjepote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSalonLjepote.Services
{
    public interface IProizvodiService
    {
        List<Proizvodi> GetList();
    }
}
