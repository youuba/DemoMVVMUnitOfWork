# **DemoMVVMUnitOfWork**

This .NET WPF application exemplifies best practices in software development by adhering to the MVVM architectural pattern and utilizing the Unit of Work pattern to manage database transactions,With the integration of MaterialDesignThemes library to provide a sleek and modern polished user interface.Additionally, the inclusion of validation ensures data accuracy and reliability. By combining these design patterns and libraries, This application represents a prime example of how to create high-quality a robust WPF application that meet the highest standards of software development.

### **Technologies Used**

. C#

. NET 7

. WPF

. MVVM pattern

. Entity Framework Core 7

. Unit of Work pattern


### **Architecture**

The application follows the MVVM pattern, which separates the presentation logic from the business logic and the data access layer. The View communicates with the ViewModel through data bindings, and the ViewModel communicates with the Model through the Unit of Work pattern.

The Unit of Work pattern is used to manage database transactions, ensuring that changes are made to the database only when all the necessary changes have been made. This helps to maintain data integrity and consistency.
