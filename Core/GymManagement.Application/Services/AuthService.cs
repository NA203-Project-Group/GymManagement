using System;
using System.Threading.Tasks;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Jwt;
using GymManagement.Application.ViewModels.MemberViewModel;

namespace GymManagement.Application.Services
{
    public class AuthService :IAuthService
    {
        public Task<bool> Register(MemberRegisterViewModel registerViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<Token> Login(MemberLoginViewModel loginViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
