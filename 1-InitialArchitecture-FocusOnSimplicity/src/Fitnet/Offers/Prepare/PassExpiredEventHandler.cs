﻿namespace EvolutionaryArchitecture.Fitnet.Offers.Prepare;

using Common.Events;
using Common.Events.EventBus;
using Data;
using Data.Database;
using Passes.MarkPassAsExpired.Events;

internal sealed class PassExpiredEventHandler(
    IEventBus eventBus,
    OffersPersistence persistence,
    TimeProvider timeProvider) : IIntegrationEventHandler<PassExpiredEvent>
{
    public async Task Handle(PassExpiredEvent @event, CancellationToken cancellationToken)
    {
        var nowDate = timeProvider.GetUtcNow();
        var offer = Offer.PrepareStandardPassExtension(@event.CustomerId, nowDate);
        persistence.Offers.Add(offer);
        await persistence.SaveChangesAsync(cancellationToken);

        var offerPreparedEvent = OfferPrepareEvent.Create(offer.Id, offer.CustomerId);
        await eventBus.PublishAsync(offerPreparedEvent, cancellationToken);
    }
}
