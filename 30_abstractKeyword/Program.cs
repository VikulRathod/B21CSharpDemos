//Customer c1 = new SilverCustomer();
//c1.Shows();

//Customer c2 = new GoldCustomer();
//c2.Shows();

//// Customer c = new Customer(); // error

//Customer c = new SilverCustomer();
//c.Shows(); // Customer method
//c.Ticket(); // SilverCustomer method

//Customer cc = new GoldCustomer();
//cc.Shows(); // Customer method
//cc.Ticket(); // SilverCustomer method

Customer[] customers = new Customer[3];
customers[0] = new SilverCustomer();
customers[1] = new GoldCustomer();
customers[2] = new Enquiry();

for (int i = 0; i < customers.Length; i++)
{
    customers[i].Shows();
    customers[i].Ticket();
}

Console.ReadLine();

