﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Classes
{
    public class UserResponse
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }

        public string Picture { get; set; }

        public string Email { get; set; }

        public string NickName { get; set; }

        public int FavoriteTeamId { get; set; }

        public int Points { get; set; }

        public Team FavoriteTeam { get; set; }

        //public List<Group> UserGroups { get; set; }

        //public List<GroupUser> GroupUsers { get; set; }

        //public List<Prediction> Predictions { get; set; }

    }
}