﻿namespace R3;

public static partial class Event
{
    public static Event<T> Throw<T>(Exception exception)
    {
        return ReturnOnCompleted<T>(Result.Failure(exception));
    }

    public static Event<T> Throw<T>(Exception exception, TimeProvider timeProvider)
    {
        return ReturnOnCompleted<T>(Result.Failure(exception), timeProvider);
    }

    public static Event<T> Throw<T>(Exception exception, TimeSpan dueTime, TimeProvider timeProvider)
    {
        return ReturnOnCompleted<T>(Result.Failure(exception), dueTime, timeProvider);
    }
}


