using eGaraz.Models;
using eGaraz.ViewModels;
using System;
using System.Threading.Tasks;

namespace eGaraz.Services.Interfaces
{
    public interface IFiremenService
    {
        /// <summary>
        /// Adds firemen to the database and replace property CreatedAt with current DateTime, property CreateBy with current logged user.
        /// </summary>
        /// <param name="firemen">Firemen entity</param>
        /// <exception cref="ArgumentNullException">When Firemen entity will be null</exception>
        /// <exception cref="Exception">When Firemen won't be updated in database</exception>
        Task<FiremenVM> CreateFiremenAsync(Firemen firemen);

        /// <summary>
        /// Updates firemen in the database and replace property UpdatedAt with current DateTime, property UpdatedBy with current logged user.
        /// </summary>
        /// <param name="firemen">Firemen entity</param>
        /// <exception cref="ArgumentNullException">When Firemen entity will be null</exception>
        /// <exception cref="ArgumentException">When Firemen ID won't be greather than zero</exception>
        /// <exception cref="Exception">When Firemen will not found</exception>
        /// <exception cref="Exception">When Firemen won't be updated in database</exception>
        Task<FiremenVM> UpdateFiremenAsync(Firemen firemen);

        /// <summary>
        /// Marks firemen as deleted in the database(property Deleted=true) and replace property DeletedAt with current DateTime, property DeletedBy with current logged user.
        /// </summary>
        /// <param name="id">Firemen id</param>
        /// <exception cref="ArgumentException">When Firemen ID won't be greather than zero</exception>
        /// <exception cref="Exception">When Firemen will not found</exception>
        /// <exception cref="Exception">When Firemen has been already deleted</exception>
        /// <exception cref="Exception">When Firemen won't be updated in database</exception>
        Task DeleteFiremenAsync(int id);

        /// <summary>
        /// Gets a firemen from the database
        /// </summary>
        /// <param name="id">Firemen id</param>
        /// <exception cref="ArgumentException">When Firemen ID won't be greather than zero</exception>
        /// <exception cref="Exception">When Firemen will not found</exception>
        Task<FiremenVM> GetFiremenByIdAsync(int id);
    }
}
