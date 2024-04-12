using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.DataContext;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Repository.Repository.RepositoryImplementacion
{
    public class ItemRepository : IITemRepository
    {
        private readonly Context _context;

        public ItemRepository(Context context)
        {
            _context = context;
        }
        
        public async Task AdicionarItem(Item item)
        {
            try
            {
                await _context.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<Pedido> BuscarPedidoPorCliente(int idCiente)
        {
            var pedidoAberto = await _context.tb_Pedidos
                .Where(x => x.ClienteId == idCiente && x.Status == "Aberto")
                //.Include(x => x.Cliente)
                //.Include(x => x.Items)
                .FirstOrDefaultAsync();
            return pedidoAberto;
        }
    }
}
