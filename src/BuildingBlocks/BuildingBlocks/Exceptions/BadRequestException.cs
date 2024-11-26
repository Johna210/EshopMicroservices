﻿namespace BuildingBlocks.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
        
    }

    public BadRequestException(string message, string details) : base(message)
    {
        Details = details;
    }

    private string? Details { get; }
}