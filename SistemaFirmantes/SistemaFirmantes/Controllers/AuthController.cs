﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaFirmantes.Interfaces;
using SistemaFirmantes.Models;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<LoginModelRespomse> Login(LoginModel model)
    {
        var usuario = model.Usuario;
        var contrasena = model.Contrasena;

        var isAuthenticated = await _authService.AuthenticateUser(usuario, contrasena);

        if (isAuthenticated)
        {
            return new LoginModelRespomse { Usuario = usuario };
        }

        return new LoginModelRespomse { Error="Credenciales invalidas"}; // Cambia esto según tus necesidades
    }
}
