using System;

using CakeWorld;

public class InvalidFlavourException : Exception
{
    public InvalidFlavourException(string message) : base(message)
    {
        
    }
}