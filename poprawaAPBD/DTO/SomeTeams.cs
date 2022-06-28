using poprawaAPBD.Models;
using System.Collections.Generic;

namespace poprawaAPBD.DTO
{
    public class SomeTeams
    {
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        public string TeamName { get; set; }
        public string? TeamDescryption { get; set; }

        public ICollection<Membership> Memberships_Teams { get; set; }
        public ICollection<File> Files { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
