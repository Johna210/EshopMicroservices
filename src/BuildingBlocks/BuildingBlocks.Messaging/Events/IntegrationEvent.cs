﻿namespace BuildingBlocks.Messaging.Events;

public record IntegrationEvent
{
    public Guid Id { get; init; }
    public DateTime OccurendOn  => DateTime.Now;
    public string EventType => GetType().AssemblyQualifiedName;
}
