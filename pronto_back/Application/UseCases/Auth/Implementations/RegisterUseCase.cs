using pronto_back.Application.DTOs.Auth;
using pronto_back.Application.UseCases.Auth.Interfaces;
using pronto_back.Domain.Interfaces.Repositories;

namespace pronto_back.Application.UseCases.Auth.Implementations
{
    public class RegisterUseCase : IRegisterUseCase
    {

        // Instancia del repo
        private readonly IUserRepository _userRepository;


        public RegisterUseCase(IUserRepository userRepository)
        {

            _userRepository = userRepository;

        }


        public async Task<AuthReponseDto> Register(RegisterRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
