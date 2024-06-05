namespace Integrify.Integrations.Orders.Model.Enums;

public enum OrderStatus
{
    Pending,        // Order has been created but not yet processed
    Confirmed,      // Order has been confirmed
    Shipped,        // Order has been shipped
    Delivered,      // Order has been delivered to the customer
    Canceled,       // Order has been canceled
    Returned        // Order has been returned by the customer
}