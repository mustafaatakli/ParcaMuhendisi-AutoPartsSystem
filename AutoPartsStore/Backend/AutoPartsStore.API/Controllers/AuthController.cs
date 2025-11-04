using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;
using AutoPartsStore.API.Services;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;
        private readonly JwtService _jwtService;

        public AuthController(AutoPartsDbContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        // POST: api/Auth/register
        [HttpPost("register")]
        public async Task<ActionResult<AuthResponse>> Register(RegisterDto dto)
        {
            // Check if email already exists
            if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
            {
                return BadRequest(new { message = "Bu email adresi zaten kullanılıyor." });
            }

            var user = new User
            {
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                FullName = dto.FullName,
                Phone = dto.Phone ?? string.Empty,
                Role = "User",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var token = _jwtService.GenerateToken(user);

            return Ok(new AuthResponse
            {
                Token = token,
                User = new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    FullName = user.FullName,
                    Phone = user.Phone,
                    Role = user.Role
                }
            });
        }

        // POST: api/Auth/login
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(LoginDto dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return Unauthorized(new { message = "Email veya şifre hatalı." });
            }

            if (!user.IsActive)
            {
                return Unauthorized(new { message = "Hesabınız devre dışı bırakılmış." });
            }

            var token = _jwtService.GenerateToken(user);

            return Ok(new AuthResponse
            {
                Token = token,
                User = new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    FullName = user.FullName,
                    Phone = user.Phone,
                    Role = user.Role
                }
            });
        }

        // GET: api/Auth/me
        [HttpGet("me")]
        [Authorize]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            // Get user ID from token claims
            var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return Unauthorized();
            }

            var userId = int.Parse(userIdClaim.Value);
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Phone = user.Phone,
                Role = user.Role
            });
        }

        // PUT: api/Auth/update-profile
        [HttpPut("update-profile")]
        [Authorize]
        public async Task<ActionResult<UserDto>> UpdateProfile(UpdateProfileDto dto)
        {
            // Get user ID from token claims
            var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return Unauthorized();
            }

            var userId = int.Parse(userIdClaim.Value);
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            // Check if email is being changed and if new email already exists
            if (dto.Email != user.Email && await _context.Users.AnyAsync(u => u.Email == dto.Email))
            {
                return BadRequest(new { message = "Bu email adresi zaten kullanılıyor." });
            }

            // Update user information
            user.FullName = dto.Name;
            user.Email = dto.Email;
            user.Phone = dto.Phone ?? string.Empty;

            await _context.SaveChangesAsync();

            return Ok(new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Phone = user.Phone,
                Role = user.Role
            });
        }
    }

    // DTOs
    public class RegisterDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
    }

    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class AuthResponse
    {
        public string Token { get; set; } = string.Empty;
        public UserDto User { get; set; } = null!;
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }

    public class UpdateProfileDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
    }
}
