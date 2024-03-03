namespace EvolutionaryArchitecture.Fitnet.Contracts.Application;

using MediatR;

public interface ICommand<out TResult> : IRequest<TResult>
{ }

public interface ICommand : IRequest
{ }
