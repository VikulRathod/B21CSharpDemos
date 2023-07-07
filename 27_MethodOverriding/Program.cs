//Customer c1 = new Customer() { FirstName = "Anil", LastName = "Rathod" };
//c1.Print(); // Customer Print()

//SilverCustomer sc1 = new SilverCustomer() { FirstName = "Rahul", LastName = "Rathod" };
//sc1.Print(); // SilverCustomer Print()

//c1 = new SilverCustomer() { FirstName = "Anup", LastName = "Rathod"};
//c1.Print();  // Customer Print()

Customer c1 = new Customer() { FirstName = "Anil", LastName = "Rathod" };
c1.Print();
Customer c2 = new SilverCustomer() { FirstName = "Rahul", LastName = "Rathod" };
c2.Print();
Customer c3 = new GoldCustomer() { FirstName = "Anup", LastName = "Rathod" };
c3.Print();
Customer c4 = new AdvancedSilverCustomer() { FirstName = "Vihaan", LastName = "Rathod" };
c4.Print();

Console.ReadLine();