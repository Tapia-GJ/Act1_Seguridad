using Domain.DTO;
using Domain.Entities;

namespace Act1_Seguridad.Services.IServices
{
    public interface IJwtServices
    {
        public Task<LoginResponse?> Autenticacion(LoginRequest request);
    }
}
