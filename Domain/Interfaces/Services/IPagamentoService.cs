﻿using Cloudmarket.Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IPagamentoService : IServiceBase<Pagamento>
    {
        Pagamento GetUltimoCartaoCadastrado(string usuarioId);
    }
}
