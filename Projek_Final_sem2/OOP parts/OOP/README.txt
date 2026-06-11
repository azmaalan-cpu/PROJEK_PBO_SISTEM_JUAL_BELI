Examples demonstrating how to apply 4 pillars of OOP to the project:

- Abstraction: interfaces ITransaksiDAO, ITransaksiService, IPayment.
- Inheritance: BaseDAO abstract class used by TransaksiDAO.
- Encapsulation: CartItem model with private setter and validation, BaseDAO hides DB details.
- Polymorphism: IPayment and different payment implementations; TransaksiService uses ITransaksiDAO interface.

Files added in this folder:
- DAO/ITransaksiDAO.cs
- DAO/BaseDAO.cs
- DAO/TransaksiDAO.cs (example implementation)
- Models/CartItem.cs
- Services/ITransaksiService.cs
- Services/TransaksiService.cs
- Payments/IPayment.cs
- Payments/CashPayment.cs

These files are for demonstration only and do not modify existing project files. To integrate, move/merge into appropriate namespaces and update using statements as needed.