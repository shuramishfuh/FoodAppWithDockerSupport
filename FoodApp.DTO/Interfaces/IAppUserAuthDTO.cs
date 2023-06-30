namespace FoodApp.DTO.Interfaces
{
    public interface IAppUserAuthDTO
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string? RefreshToken { get; set; }
        public bool RefreshTokenIsActive { get; set; }

    }
}
