using System.Collections.Generic;

namespace poprawaAPBD.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDomain { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}
