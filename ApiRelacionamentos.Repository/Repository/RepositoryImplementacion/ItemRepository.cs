using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.DataContext;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
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
    }
}
