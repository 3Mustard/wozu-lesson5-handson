#Problem 1

Create an application named SalesTransactionDemo that declares several SalesTransaction objects and displays their values and their sum.

The SalesTransaction class contains fields for a salesperson name, sales amount, commission, and a read-only field that stores the commission rate. Include three constructors for the class.

One constructor accepts values for the name, sales amount, and rate, and when the sales value is set, the constructor computes the commission as sales value times commission rate.

The second constructor accepts a name and sales amount but sets the commission rate to 0.

The third constructor accepts a name and sets all the other fields to 0. An overloaded + operator adds the sales values for two SalesTransaction objects.

#Problem 2

Create an Employee class that represents several types of employees within a company.

Have the program prompt the user to enter the type of employee (from a list of employee types). The program should also prompt the user to enter the number of meals being purchased.

Depending on the type of employee chosen, the program should calculate their cafeteria dues for the current month.

Employees: Temp = 2.75 per day, Full Time= free, Part Time =1.50
