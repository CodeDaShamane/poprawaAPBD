using Microsoft.EntityFrameworkCore;
using poprawaAPBD.DTO;
using poprawaAPBD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poprawaAPBD.Services

{
    public class dbService : IDbService

    {
        private readonly dbContext _context;
        private IDbService _dbServiceImplementation;

        public dbService(dbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SomeTeams>> zespoly(int TeamID)
        {
            return await _context.Teams.Where(t => t.TeamID == TeamID).Select(a => new SomeTeams
            {
                TeamID = a.TeamID,
                TeamName = a.TeamName,
                TeamDescryption = a.TeamDescryption,
                Organization = new Organization
                {
                    OrganizationID = a.OrganizationID,
                   OrganizationName = a.Organization.OrganizationName
                }

            }).OrderBy(t => t.TeamID).ToListAsync();
        }

    }
}
