using Application.Dto.Account;
using Application.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfacez.IServices
{
    public interface IAccountServices
    {
        Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin);
        Task SignOutAsync();
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
    }
}
