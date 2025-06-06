﻿namespace Owners.Types;

public class Owner
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
}
