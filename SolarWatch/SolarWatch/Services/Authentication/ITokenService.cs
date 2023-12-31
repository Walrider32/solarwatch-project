﻿using Microsoft.AspNetCore.Identity;

namespace SolarWatch.Services.Authentication
{
    public interface ITokenService
    {
        public string CreateToken(IdentityUser user, IList<string> roles);
    }
}
