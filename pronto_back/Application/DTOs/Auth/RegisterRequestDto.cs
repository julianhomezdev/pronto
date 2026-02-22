namespace pronto_back.Application.DTOs.Auth
{
    public class RegisterRequestDto
    {

        // Empty es una manera de inicializar vacio ''

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
