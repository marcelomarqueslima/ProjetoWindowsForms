using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pais : IIdentityEntity
    {
        public int PaisId { get; set; }
        public string DescricaoPais { get; set; }
    }
}
