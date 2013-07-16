using System;


namespace CompanyManager
{
    class CompanyManager
    {
        static void Main()
        {
            string companyName, companyAddress, companyPhone, companyFax, companySite;
            string mngFirstName, mngLastName, mngPhone;
            int mngAge;
            Console.WriteLine("Enter company name: ");
            companyName = Console.ReadLine();
            Console.WriteLine("Enter company address: ");
            companyAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone: ");
            companyPhone = Console.ReadLine();
            Console.WriteLine("Enter company Fax: ");
            companyFax = Console.ReadLine();
            Console.WriteLine("Enter company site: ");
            companySite = Console.ReadLine();
            Console.WriteLine("Enter manager first name: ");
            mngFirstName = Console.ReadLine();
            Console.WriteLine("Enter manager last name: ");
            mngLastName = Console.ReadLine();
            Console.WriteLine("Enter manager phone: ");
            mngPhone = Console.ReadLine();
            Console.WriteLine("Enter manager age: ");
            mngAge = int.Parse(Console.ReadLine());
            Console.WriteLine("The company details are: ");
            Console.WriteLine("Name: {0}", companyName + "\n" + "Address: " + companyAddress + "\n" + "phone: " + companyPhone + "\n" + "fax: " + companyFax + "\n" + "site: " + companySite);
            Console.WriteLine("The company manager details are: " + "\n" + "Name: {0} {1}", mngFirstName, mngLastName + "\n" + "phone: " + mngPhone + "\n" + "age: " + mngAge);
        }
    }
}
