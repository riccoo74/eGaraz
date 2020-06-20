using eGaraz.Models;
using eGaraz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGaraz.Services.Interfaces
{
    public interface IFiremenService
    {
        Task<FiremenVM> CreateFiremenAsync(Firemen firemen);
        Task<FiremenVM> UpdateFiremenAsync(Firemen firemen);
    }
}
