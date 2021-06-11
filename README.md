# EF-DynamicConnectionString
Example of implementing a dynamic database connection string using the Entity Framework

[ENG]
This project provides an implementation of a dynamic database connection string through the Entity Framework.
For this, two classes were created, located in the "Models" folder.
The ConnectionString class represents a connection string model that can be extended with the required parameters.
The ConnectionHelper class contains functions and properties that make it easier to work with the ConnectionString model.
The Database folder contains the EFContext class, which shows an example of using a dynamic connection string.
The MainWindow.xaml.cs file provides an example of using the function to create a configuration file.

!!!IMPORTANT: when using a dynamic connection string, it becomes impossible to use migrations, since they are based on a static connection string. Therefore, it is recommended to work with migrations and database development before implementing a dynamic connection string.!!!

[RU]
В этом проекте представлена реализация динамической строки подключения к базе данных посредством Entity Framework.
Для этого были созданы два класса расположенные в папке "Models".
Класс ConnectionString представляет модель строки подключения, которую можно расширять необходимыми параметрами.
Класс ConnectionHelper содержит функции и свойства облегчающие работу с моделью ConnectionString.
В папке "Database" расположен класс EFContext, в котором показан пример использования динамической строки подключения.
В файле MainWindow.xaml.cs представлен пример использования функции создания файла конфигурации.

!!!ВАЖНО: при использовании динамической строки подключения становится невозможным использование миграций, так как они основываются на статичной строке подключения. Поэтому рекомендуется работы с миграциями и разработкой базы данных проводить до внедрения динамической строки подключения.!!!
