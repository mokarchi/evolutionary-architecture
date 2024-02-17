﻿namespace EvolutionaryArchitecture.Fitnet.Contracts.SignContract;

using Common.Validation.Requests;
using Data.Database;
using EvolutionaryArchitecture.Fitnet.Common.Events.EventBus;
using EvolutionaryArchitecture.Fitnet.Contracts.PrepareContract.BusinessRules;
using EvolutionaryArchitecture.Fitnet.Contracts.SignContract.Events;

internal static class SignContractEndpoint
{
    internal static void MapSignContract(this IEndpointRouteBuilder app) => app.MapPatch(ContractsApiPaths.Sign,
            async (Guid id, SignContractRequest request,
                ContractsPersistence persistence,
                IEventBus bus,
                TimeProvider timeProvider,
                CancellationToken cancellationToken) =>
            {
                var test = new ContractCanBePreparedOnlyForAdultRule(10);
#pragma warning disable S1481
                var _ = test.Error;
#pragma warning restore S1481

                var contract =
                    await persistence.Contracts.FindAsync(new object[] { id }, cancellationToken: cancellationToken);

                if (contract is null)
                {
                    return Results.NotFound();
                }

                var dateNow = timeProvider.GetUtcNow();
                contract.Sign(request.SignedAt, dateNow);
                await persistence.SaveChangesAsync(cancellationToken);

                var @event = ContractSignedEvent.Create(contract.Id, contract.CustomerId, contract.SignedAt!.Value,
                    contract.ExpiringAt!.Value);
                await bus.PublishAsync(@event, cancellationToken);

                return Results.NoContent();
            })
        .ValidateRequest<SignContractRequest>()
        .WithOpenApi(operation => new(operation)
        {
            Summary = "Signs prepared contract",
            Description = "This endpoint is used to sign prepared contract by customer."
        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status409Conflict)
        .Produces(StatusCodes.Status500InternalServerError);
}
