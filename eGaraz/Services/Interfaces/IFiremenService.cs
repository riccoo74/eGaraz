using eGaraz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGaraz.Services.Interfaces
{
    interface IFiremenService
    {
        Task<Result> CreateFiremenAsync(Firemen firemen);
    }
}
