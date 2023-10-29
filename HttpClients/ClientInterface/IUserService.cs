﻿using Shared.Dtos;
using Shared.Models;

namespace HttpClients.ClientInterface;

public interface IUserService
{
    Task<User> Create(UserCreationDto dto);
    Task<IEnumerable<User>> GetUsers(string? usernameContains = null);
}