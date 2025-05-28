﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Dto.TeamMemberDtos
{
    public class ResultTeamMemberDto
    {
        public int TeamMemberID { get; set; }
        public string PhotoUrl { get; set; }
        public string MemberName { get; set; }
        public string MemberJob { get; set; }
        public bool MemberIsActive { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
