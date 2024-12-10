using MediatR;

namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class SaleDeletedEvent : INotification
    {
        public Guid SaleId { get; }

        public SaleDeletedEvent(Guid id)
        {
            SaleId = id;
        }
    }

    public class SaleDeletedEventHandler : INotificationHandler<SaleDeletedEvent>
    {
        public Task Handle(SaleDeletedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Pedido removido com sucesso! ID: {notification.SaleId}, Data: {DateTime.Now}");

            // Exemplo: enviar notificação, atualizar kafka, etc.

            return Task.CompletedTask;
        }
    }
}
