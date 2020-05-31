using eGaraz.Models;
using eGaraz.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGaraz.Services
{
    public class FiremenService : IFiremenService
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public FiremenService(AppDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Adding firemen to the database and replece property CreatedAt with current DateTime, property CreateBy with current logged user.
        /// </summary>
        /// <param name="firemen">Firemen entity</param>
        /// <returns></returns>
        public async Task<Result> CreateFiremenAsync(Firemen firemen)
        {
            if (firemen == null)
                throw new ArgumentNullException("Firemen entity cannot be null.");

            firemen.CreatedAt = DateTime.Now;
            firemen.CreatedBy = await userManager.FindByNameAsync(httpContextAccessor.HttpContext.User.Identity.Name);

            await context.Set<Firemen>().AddAsync(firemen);

            bool result = await context.SaveChangesAsync() > 0;

            if (result)
                return new Result { Succedeed = true };
            else
                return new Result { Succedeed = false, ErrorMessage = "Wystąpił problem, spróbuj ponownie później." };
        }
    }
}
