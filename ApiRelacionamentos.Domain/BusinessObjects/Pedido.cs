using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Domain.BusinessObjects
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public float ValorTotal { get; set; }
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
