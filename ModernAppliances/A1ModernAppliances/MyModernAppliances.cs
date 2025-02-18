using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Authors:Connor Yasinski, David Cadena </remarks>
    /// <remarks>Date:Febuary 18, 2025 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout() //Writen by Connor Yasinski
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance");
            // Create long variable to hold item number
            long applianceNumber;
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            applianceNumber = Convert.ToInt64(Console.ReadLine());
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;
            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (var appliance in Appliances) 
            {
                if (appliance.ItemNumber == applianceNumber)
                {
                    // Break out of loop (since we found what need to)
                    foundAppliance = appliance;
                    break;
                }
            }
            

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance is null)
            {
                Console.WriteLine("No appliances found with that number");
            }
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            else 
            {
                if (foundAppliance.IsAvailable == true)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out");
                    // Write "Appliance has been checked out."
                }
                else 
                {
                    Console.WriteLine("The appliance is not availible to be checked out");
                    // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
                }
            }


        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find() //Written by David Cadena
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");
            // Create string variable to hold entered brand
            string selectedBrand;
            // Get user input as string and assign to variable.
            selectedBrand = Convert.ToString(Console.ReadLine());
            // Create list to hold found Appliance objects
            var userfoundAppliances = new List<Appliance>();
            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {

            // Test current appliance brand matches what user entered
            if (selectedBrand == appliance.Brand) {
            // Add current appliance in list to found list
            userfoundAppliances.Add(appliance);
            }

        }
            // Display found appliances
            DisplayAppliancesFromList(userfoundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators() //Written by David Cadena
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int numDoors;
            // Get user input as string and assign to variable
            string userInputDoors = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            numDoors = Convert.ToInt32(userInputDoors);
            // Create list to hold found Appliance objects
            var refrideratorfoundAppliances = new List<Appliance>();
            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances) {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if ((numDoors == 0) || (numDoors == refrigerator.Doors)) { 
                    // Add current appliance in list to found list
                    refrideratorfoundAppliances.Add(appliance);
                }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(refrideratorfoundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums() //Written by David Cadena
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");
            // Get user input as string and assign to variable
            string vacType = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            // Test input is "0"
            if (vacType == "0")
            {
                // Assign "Any" to grade
                grade = "Any";
            }
            // Test input is "1"
            if (vacType == "1")
            {
                // Assign "Residential" to grade
                grade = "Residential";
            }
            // Test input is "2"
            if (vacType == "2")
            {
                // Assign "Commercial" to grade
                grade = "Commercial";
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid Options");
                // Return to calling (previous) method
                return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage");
            // Get user input as string
            string voltageInput = Console.ReadLine();
            // Create variable to hold voltage
            int voltage;
            // Test input is "0"
            if (voltageInput == "0")
            {
                // Assign 0 to voltage
                voltage = 0;
            }
            // Test input is "1"
            if (voltageInput == "1")
            {
                // Assign 18 to voltage
                voltage = 18;
            }
            // Test input is "2"
            if (voltageInput == "2")
            {
                // Assign 24 to voltage
                voltage = 24;
            }
            else
            {
                // Otherwise
                // Write "Invalid option."
                Console.WriteLine("Invalid Option");
                // Return to calling (previous) method
                return;
            }
            // Create found variable to hold list of found appliances.
            var vacuumfoundAppliances = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum) { }
                // Down cast current Appliance to Vacuum object
                Vacuum vacuum = (Vacuum)appliance;

                // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                if (grade == "Any" || (grade ==  vacuum.Grade && voltage == 0) || voltage == vacuum.BatteryVoltage) {
                    // Add current appliance in list to found list
                    vacuumfoundAppliances.Add(appliance);
                }
                // Display found appliances
                DisplayAppliancesFromList(vacuumfoundAppliances, 0);
            }
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves() //Writen by Connor Yasinski
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options");
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");
            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string userRoomType = Console.ReadLine();
            // Create character variable that holds room type
            char roomtype;
            // Test input is "0"
            // Assign 'A' to room type variable
            if (userRoomType == "0")
            {
                roomtype = 'A';
            }
            // Test input is "1"
            // Assign 'K' to room type variable
            if (userRoomType == "1")
            {
                roomtype = 'K';
            }
            // Test input is "2"
            // Assign 'W' to room type variable
            if (userRoomType == "2")
            {
                roomtype = 'W';
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }

            
            // Create variable that holds list of 'found' appliances
            var microwaveFoundApplianceList = new List<Appliance>();
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    // Add current appliance in list to found list
                    if (roomtype == 'A')
                    {
                        microwaveFoundApplianceList.Add(microwave);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(microwaveFoundApplianceList, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers() //Writen by Connor Yasinski
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");
            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string userSoundRating = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;
            // Test input is "0"
            // Assign "Any" to sound rating variable
            if (userSoundRating == "0")
            {
                soundRating = "Any";
            }
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            if (userSoundRating == "1")
            {
                soundRating = "Qt";
            }
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            if (userSoundRating == "2")
            {
                soundRating = "Qr";
            }
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            if (userSoundRating == "3")
            {
                soundRating = "Qu";
            }
            // Test input is "4"
            // Assign "M" to sound rating variable
            if (userSoundRating == "4")
            {
                soundRating = "M";
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }
            // Create variable that holds list of found appliances
            var dishwasherFoundApplianceList = new List<Appliance>();
            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    // Add current appliance in list to found list
                    if ((soundRating == "Any") || (dishwasher.SoundRating == soundRating))
                    {
                        dishwasherFoundApplianceList.Add(dishwasher);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(dishwasherFoundApplianceList, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList() //Writen by Connor Yasinski
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 - Refrigerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 - Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 - Microwaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 - Dishwashers");
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance");
            // Get user input as string and assign to appliance type variable
            string userApplianceType = Console.ReadLine();
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances:");
            // Get user input as string and assign to variable
            // Convert user input from string to int
            int userNumAppliances = Convert.ToInt32(Console.ReadLine());

            // Create variable to hold list of found appliances
            var randomFoundApplianceList = new List<Appliance>();
            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test inputted appliance type is "0"
                // Add current appliance in list to found list
                if (userApplianceType == "0")
                {
                    randomFoundApplianceList.Add(appliance);
                }
                // Test inputted appliance type is "1"
                // Test current appliance type is Refrigerator
                // Add current appliance in list to found list
                if (userApplianceType == "1")
                {
                    randomFoundApplianceList.Add(appliance);
                }
                // Test inputted appliance type is "2"
                // Test current appliance type is Vacuum
                // Add current appliance in list to found list
                if (userApplianceType == "2")
                {
                    randomFoundApplianceList.Add(appliance);
                }
                // Test inputted appliance type is "3"
                // Test current appliance type is Microwave
                // Add current appliance in list to found list
                if (userApplianceType == "3")
                {
                    randomFoundApplianceList.Add(appliance);
                }
                // Test inputted appliance type is "4"
                // Test current appliance type is Dishwasher
                // Add current appliance in list to found list
                if (userApplianceType == "4")
                {
                    randomFoundApplianceList.Add(appliance);
                }
            }
            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            randomFoundApplianceList.Sort(new RandomComparer());
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(randomFoundApplianceList, userNumAppliances);
        }
    }
}
