using System;
using System.Collections.Generic;
using System.Security.Claims;
using GymManagement.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace GymManagement.Application.Jwt
{
    public class TokenGenerator
    {

        public Token CreateToken(Member member, List<string> memberRoles)
        {
            var exp = DateTime.Now.AddMinutes(30);
            var token = new Token {Expiration = exp};

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,member.UserName),
                new Claim(ClaimTypes.Name,member.Id)
            };

            foreach (var role in memberRoles)
            {
                if (role is not null)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role,Convert.ToString(role)));
                }
            }

            //var securityKey = new SymmetricSecurityKey()


        }
    }
}
