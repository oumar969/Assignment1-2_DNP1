﻿using Shared.Auth;

namespace WebApi.Services;

public interface IAuthService
{
    Task<User> ValidateUser(string username, string password);
    Task RegisterUser(User user);
}