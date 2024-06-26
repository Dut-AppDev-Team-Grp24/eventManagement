using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace EventManagement.Helper
{
    public class JwtHelper
    {

        const string Token = "verversecretToken:)";
        public string CreateAuthenticationTicket(User user)
        {

            var key = Encoding.ASCII.GetBytes(Token);
            var jwtToken = new JwtSecurityToken(
            issuer: "www.example.com",
            audience: "www.example.com",
            claims: GetUserClaims(user),
            notBefore: new DateTimeOffset(DateTime.Now).DateTime,
            expires: new DateTimeOffset(DateTime.Now.AddDays(1)).DateTime,
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        );

            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;
        }


        private IEnumerable<Claim> GetUserClaims(User user)
        {
            List<Claim> claims = new List<Claim>();
            Claim _claim;
            _claim = new Claim(ClaimTypes.Name, user.Name);
            claims.Add(_claim);

            string role = user.RoleId;

            _claim = new Claim(ClaimTypes.Role, role);
            claims.Add(_claim);

            return claims.AsEnumerable();
        }
    }




}