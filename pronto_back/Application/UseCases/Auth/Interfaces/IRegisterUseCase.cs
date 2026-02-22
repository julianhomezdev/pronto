using pronto_back.Application.DTOs.Auth;

namespace pronto_back.Application.UseCases.Auth.Interfaces
{
    public interface IRegisterUseCase
    {

        Task<AuthReponseDto> Register(RegisterRequestDto request);

    }
}
