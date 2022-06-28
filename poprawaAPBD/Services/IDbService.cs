using poprawaAPBD.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poprawaAPBD.Services
{

        public interface IDbService
        { 
            Task<IEnumerable<SomeTeams>> zespoly(int TeamID); 
        }
        
    
}
