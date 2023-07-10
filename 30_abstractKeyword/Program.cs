Customer c1 = new SilverCustomer();
c1.Shows();

Customer c2 = new GoldCustomer();
c2.Shows();

// Customer c = new Customer(); // error

Customer c = new SilverCustomer();
c.Shows(); // Customer method
c.Ticket(); // SilverCustomer method

Customer cc = new GoldCustomer();
cc.Shows(); // Customer method
cc.Ticket(); // SilverCustomer method


Console.ReadLine();

