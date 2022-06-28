using poprawaAPBD.Models;
using System.Collections.Generic;

namespace poprawaAPBD.DTO
{
    public class SomeOrganizations
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDomain { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
