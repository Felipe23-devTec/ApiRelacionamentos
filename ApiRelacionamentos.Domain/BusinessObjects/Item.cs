using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Domain.BusinessObjects
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
