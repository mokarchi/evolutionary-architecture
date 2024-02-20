namespace EvolutionaryArchitecture.Fitnet.Common.Infrastructure.IntegrationTests.Events.EventBus.InMemory;
using System.Reflection;
using System.Threading.Tasks;
using Common.IntegrationTests.TestEngine.Configuration;
using EvolutionaryArchitecture.Fitnet.Common.Infrastructure.Events.EventBus;
using EvolutionaryArchitecture.Fitnet.Common.IntegrationTests.TestEngine;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

public sealed class InMemoryEventBusTests(
    FitnetWebApplicationFactory<Program> applicationInMemoryFactory) : IClassFixture<
    FitnetWebApplicationFactory<Program>>
{
    private WebApplicationFactory<Program> ApplicationInMemory => applicationInMemoryFactory
        .WithFakeConsumers(Assembly.GetExecutingAssembly());

    [Fact]
    internal async Task Given_valid_event_published_Then_event_should_be_consumed()
    {
        // Arrange
        var eventBus = ApplicationInMemory.Services.GetRequiredService<IEventBus>();
        var fakeEvent = FakeEvent.Create();

        // Act
        await eventBus.PublishAsync(fakeEvent, CancellationToken.None);

        // Assert
        fakeEvent.Consumed.Should().BeTrue();
    }
}
