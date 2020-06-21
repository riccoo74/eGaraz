using eGaraz.Models;
using eGaraz.Services.Interfaces;
using eGaraz.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        public async Task<FiremenVM> CreateFiremenAsync(Firemen firemen)
        {
            if (firemen == null)
                throw new ArgumentNullException("Firemen entity cannot be null.");

            firemen.CreatedAt = DateTime.Now;
            firemen.CreatedBy = await userManager.FindByNameAsync(httpContextAccessor.HttpContext.User.Identity.Name);

            await context.Set<Firemen>().AddAsync(firemen);

            bool result = await context.SaveChangesAsync() > 0;

            if (result)
                return new FiremenVM { Firemen = firemen };
            else
                throw new Exception($"Firemen entity(ID: {firemen.Id}) was not updated in database");
        }


        public async Task<FiremenVM> UpdateFiremenAsync(Firemen firemen)
        {
            if (firemen == null)
                throw new ArgumentNullException("Firemen entity cannot be null");

            if (firemen.Id <= 0)
                throw new ArgumentException("Firemen ID must be greather than zero");

            Firemen firemenToUpdate = await context.Firemens
                .AsNoTracking()
                .Where(w => w.Deleted != true)
                .FirstOrDefaultAsync(f => f.Id == firemen.Id);

            if (firemenToUpdate == null)
                throw new Exception("Firemen was not found");

            firemen.UpdatedAt = DateTime.Now;
            firemen.UpdatedBy = await userManager.FindByNameAsync(httpContextAccessor.HttpContext.User.Identity.Name);

            context.Firemens.Attach(firemen).State = EntityState.Modified;

            bool result = await context.SaveChangesAsync() > 0;

            if (result)
                return new FiremenVM { Firemen = firemen };
            else
                throw new Exception(@"Firemen entity(ID: {firemen.Id}) was not updated in database");
        }

        public async Task DeleteFiremenAsync(int id)
        {
           if (id <= 0)
                throw new ArgumentException("ID must be greather than zero");

            var firemen = await context.Firemens.FindAsync(id);

            if (firemen == null)
                throw new Exception("Firemen was not found");

            if (firemen.Deleted.HasValue && firemen.Deleted.Value)
                throw new Exception($"Firemen has been already deleted by {(firemen.DeletedBy != null ? firemen.DeletedBy.UserName : "null")}" +
                    $" at {(firemen.DeletedAt.HasValue ? firemen.DeletedAt.Value.ToString("yyyy-MM -dd") : "null")}");

            firemen.Deleted = true;
            firemen.DeletedBy = await userManager.FindByNameAsync(httpContextAccessor.HttpContext.User.Identity.Name);
            firemen.DeletedAt = DateTime.Now;

            if (await context.SaveChangesAsync() < 0)
                throw new Exception($"Firemen entity(ID: {firemen.Id}) was not updated in database");
        }
    }
}
