using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Models
{
    public class Pedido
    {
        public Usuario usuario { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
