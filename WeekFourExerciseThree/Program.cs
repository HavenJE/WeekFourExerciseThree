

// Exercise 3 
// Write a program called DeliveryCharges for the package delivery service in Exercise
// 2. The program should again use an array that holds the 10 zip codes of areas to which the company makes deliveries.
// Create a parallel array containing 10 delivery charges that differ for each zip code. Prompt the user to enter a zip code,
// and then display either a message indicating the price of delivery to that zip code,or a message indicating that the company does not deliver
// to the requested code.

class DeliveryCharges
{
    static void Main(string[] args)
    {
        string userZipCode;
        bool isValid = false;
        double userPrice = 0;
        double roundedPrice;

        string[] serviceCodes = { "4001", "5002", "6003", "3204", "1205", "4606", "1207", "2208", "3409", "4510" };
        double[] servicePrices = { 2.40, 3.00, 3.50, 4.00, 4.50, 5.00, 5.25, 6.50, 7.00, 7.30 };

        Console.WriteLine("Hi! Enter your delivery zipcode below: ");
        userZipCode = Convert.ToString(Console.ReadLine());

        for (int i = 0; i < serviceCodes.Length; i++)
        {
            if (userZipCode == serviceCodes[i]) 
                userPrice = servicePrices[i];
            isValid = true;
        }
        if (isValid) 
        {
            Console.WriteLine("For a deliver to your zip code {0}, price is ({1})", userZipCode, userPrice.ToString("C"));
        }
        else
        {
            Console.WriteLine("Sorry! Your zipcode {0} is not within our delivery range!", userZipCode);
        }
    }
}