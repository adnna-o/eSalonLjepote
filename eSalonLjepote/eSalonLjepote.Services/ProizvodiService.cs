using eSalonLjepote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSalonLjepote.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public List<Proizvodi> List = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvodId = 1,
                Naziv="Četka za kosu",
                Cijena=29
            },
            new Proizvodi()
            {
                ProizvodId= 2,
                Naziv="Sprej za rasčešljavanje",
                Cijena=15
            }
        };
        public List<Proizvodi> GetList()
        {
        return List;
        }
    }
}
