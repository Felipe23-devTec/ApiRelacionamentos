using ApiRelacionamentos.Domain.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Repository.Repository.RepositoryContract;

public interface IPedidoRepository
{
    Task<Pedido> BuscarPedidoPorCliente(int idCiente);
    Task AdicionarPedido(Pedido pedido);
    Task AtualizarPedido(Pedido pedido);
}
