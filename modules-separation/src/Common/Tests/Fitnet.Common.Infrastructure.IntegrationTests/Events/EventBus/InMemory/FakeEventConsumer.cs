namespace EvolutionaryArchitecture.Fitnet.Common.Infrastructure.IntegrationTests.Events.EventBus.InMemory;
using System.Threading.Tasks;

internal sealed class TestEventConsumer : IIntegrationEventHandler<FakeEvent>
{
    public Task Handle(FakeEvent @event, CancellationToken cancellationToken)
    {
        @event.MarkAsConsumed();
        return Task.CompletedTask;
    }
}
