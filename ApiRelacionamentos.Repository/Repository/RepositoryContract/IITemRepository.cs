using ApiRelacionamentos.Domain.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Repository.Repository.RepositoryContract
{
    public interface IITemRepository
    {
        Task AdicionarItem(Item item);
    }
}
