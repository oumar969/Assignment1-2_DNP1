﻿namespace Shared.Dtos;

public class UserCreationDto
{
    public string UserName { get;}

    public UserCreationDto(string userName)
    {
        UserName = userName;
    }
}