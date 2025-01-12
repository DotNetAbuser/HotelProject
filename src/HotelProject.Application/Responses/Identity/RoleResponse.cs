﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.Application.Responses.Identity;

public class RoleResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
