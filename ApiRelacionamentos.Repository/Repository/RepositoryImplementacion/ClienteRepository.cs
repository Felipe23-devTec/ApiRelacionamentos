﻿using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.DataContext;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRelacionamentos.Repository.Repository.RepositoryImplementacion;

public class ClienteRepository : IClienteRepository
{
    private readonly Context _context;

    public ClienteRepository(Context context)
    {
        _context = context;
    }
    public async Task AdicionarCliente(Cliente cliente)
    {
        try
        {
            await _context.tb_Cliente.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex.InnerException);
        }

    }
    public async Task<Cliente> BuscarClientePorId(int idCliente)
    {
        try
        {
            var cliente = await _context.tb_Cliente.Where(x => x.IdCliente == idCliente).FirstOrDefaultAsync();
            return cliente;
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
}
