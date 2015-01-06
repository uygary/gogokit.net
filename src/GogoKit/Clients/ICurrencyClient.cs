﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GogoKit.Resources;

namespace GogoKit.Clients
{
    public interface ICurrencyClient
    {
        Task<IReadOnlyList<Currency>> GetAllCurrenciesAsync();
    }
}