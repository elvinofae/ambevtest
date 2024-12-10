using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class SaleRegisteredEvent : INotification
    {
        public Sale Sale { get; }

        public SaleRegisteredEvent(Sale user)
        {
            Sale = user;
        }
    }

    public class SaleRegisteredEventHandler : INotificationHandler<SaleRegisteredEvent>
    {
        public Task Handle(SaleRegisteredEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Pedido criado com sucesso! ID: {notification.Sale}, Data: {DateTime.Now}");

            // Exemplo: enviar notifica��o, atualizar kafka, etc.

            return Task.CompletedTask;
        }
    }
}
