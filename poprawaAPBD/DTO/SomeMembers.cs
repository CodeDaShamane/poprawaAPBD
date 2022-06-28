using poprawaAPBD.Models;
using System.Collections.Generic;

namespace poprawaAPBD.DTO
{
    public class SomeMembers
    {
        public int MebmerID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string? MemberNickName { get; set; }
        public int OrganizationID { get; set; }

        public ICollection<Membership>? Memberships { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
