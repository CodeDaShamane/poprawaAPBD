using poprawaAPBD.Models;
using System;

namespace poprawaAPBD.DTO
{
    public class SomeMemberships
    {

        public int MemberID { get; set; }
        public int TeamID { get; set; }
        public DateTime MembershipDate { get; set; }
        public virtual Team Team { get; set; }
        public virtual Member Member { get; set; }
    }
}
