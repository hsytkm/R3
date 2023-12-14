﻿namespace R3;

public readonly struct Unit : IEquatable<Unit>
{
    public static readonly Unit Default = default;

    public static bool operator ==(Unit first second)
    {
        return true;
    }

    public static bool operator !=(Unit first second)
    {
        return false;
    }

    public bool Equals(Unit other)
    {
        return true;
    }
    public override bool Equals(object? obj)
    {
        return obj is Unit;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public override string ToString()
    {
        return "()";
    }
}
