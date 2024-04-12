using ApiRelacionamento.Service.ServiceContract;
using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamento.Service.ServiceImplementacion;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IClienteRepository _clienteRepository;
    private readonly IITemRepository _itemRepository;
    public PedidoService(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository, IITemRepository itemRepository)
    {
        _pedidoRepository = pedidoRepository;
        _clienteRepository = clienteRepository;
        _itemRepository = itemRepository;
    }
    public async Task CriarPedido(int idCliente, Item itemNovo)
    {
        try
        {
            var pedidoAberto = await _pedidoRepository.BuscarPedidoPorCliente(idCliente);
            if (pedidoAberto != null)
            {
                itemNovo.PedidoId = pedidoAberto.IdPedido;
                itemNovo.Pedido = pedidoAberto;
                await _itemRepository.AdicionarItem(itemNovo);


            }
            else
            {
                var cliente = await _clienteRepository.BuscarClientePorId(idCliente);
                var novoPedido = new Pedido()
                {
                    Cliente = cliente,
                    Status = "Aberto",
                    Items = new List<Item>() { itemNovo }
                };
                await _pedidoRepository.AdicionarPedido(novoPedido);
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
}
