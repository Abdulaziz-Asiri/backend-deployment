using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class UserReadDto
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class UserUpdateDto
    {
        public string Name { get; set; }
        public string? Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class UserLogInDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserUpdateRolDto
    {
        public string Role { get; set; }
    }
}