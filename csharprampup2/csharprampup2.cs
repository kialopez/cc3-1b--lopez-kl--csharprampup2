using System;

class csharprampup2
{
    static void Main()
    {
        // Part 1: Conversion and Output

        // Pounds to Kilograms
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Weight in pounds(lbs): {pounds}");
        Console.WriteLine($"Weight in kilograms(kg): {kilograms}");
        Console.WriteLine("============================================");

        // Miles to Kilometers
        Console.Write("Enter distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Distance in miles(mi): {miles}");
        Console.WriteLine($"Distance in kilometers(km): {kilometers}");
        Console.WriteLine("============================================");

        // Fahrenheit to Celsius
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in fahrenheit(°F): {fahrenheit}");
        Console.WriteLine($"Temperature in celsius(°C): {celsius}");
        Console.WriteLine("============================================");

        // Average Age Calculation
        int totalAge = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter age of student {i}: ");
            int age = Convert.ToInt32(Console.ReadLine());
            totalAge += age;
        }
        double averageAge = (double)totalAge / 10;
        Console.WriteLine($"Average Age of the students is: {averageAge:F2}");
        Console.WriteLine("============================================");

        // Part 2: STORY
        // Hero and Characters
        string hero = "Kurt";
        string kontrabida = "Malik";
        string heropet = "Nuggets";
        string wizards = "Cordillera";
        string love = "Belle";

        // Powers
        string heropower = "Sagada Shadowmeld";
        string kontrabidapower = "Dark Sorcery";
        string petpower = "Darkness Bark";
        string wizardpower = "Wisdom of the Mountains";
        string lovelook = "Beauty";

        // Weapons
        string petarmas = "Crescent Shield";
        string loveitem = "Heart necklace";

        // Story
        string story = $@"
    In the magical city of Baguio, known for its misty mountains and cool breeze, lived a brave hero named {hero}. His extraordinary ability, {heropower}, brought light to the darkest corners of the city.

    Yet, beneath the shadows, an evil villain named {kontrabida} wielded the power of {kontrabidapower}, spreading chaos across Baguio.

    Alongside {hero} on his quest was his loyal dog companion, {heropet}, who possessed the power of {petpower} and a trusty {petarmas}. Together, they embarked on a historic mission to defeat the forces of evil.

    Guiding their steps was the wise wizard, {wizards}, whose mastery of {wizardpower} provided invaluable knowledge. He taught {hero} the secrets of his abilities and the path to victory.

    Amidst their battles, {hero} found love in the heart of {love}, a woman blessed with {lovelook}. The {loveitem} symbolized his affection for her.

    Will the forces of good prevail over the darkness in the heart of Baguio?";

        Console.WriteLine(story);
        Console.WriteLine("============================================");

        // PART 2


        // TRIANGLE
        Console.Write("Enter a positive number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        else
        {
            Console.WriteLine("Number Pattern:");
            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        // SUM SUM SUM
        Console.Write("Enter a positive number: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Check for valid input
        if (userNumber <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        else
        {
            // Print the number pattern and calculate the sum
            int sum = 0;
            Console.WriteLine($"Input: {userNumber}");

            Console.Write("Formula: ");
            for (int i = 1; i <= userNumber; i++)
            {
                Console.Write(i);
                sum += i;

                if (i < userNumber)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Output: {sum}");
        }
        // INVERSE TRIANGLE
        Console.Write("Enter a positive number: ");
        int userInp = Convert.ToInt32(Console.ReadLine());

        // Check for valid input
        if (userInp <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        else
        {
            // Print the number pattern
            for (int i = userInp; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
