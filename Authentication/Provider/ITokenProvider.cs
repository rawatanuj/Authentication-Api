using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

using Authentication.Models;

namespace Authentication.Provider
{
	public interface ITokenProvider
	{
		public JwtSecurityToken GenerateJWTToken(Login model);
	}
}
