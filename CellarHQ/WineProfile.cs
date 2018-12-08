using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineProfile
    {
        // FOR THIS PHASE, hard-coded to 750 ml bottle
        public const string CONTAINER_TYPE = "bottle";
        public const int CONTAINER_VOLUME = 750;
        public const string CONTAINER_VOL_UNITS = "ml";

        private int wineID;
        private string wineType;
        private string vintage;
        private string producer;
        private string country;
        private string region;
        private string appellation;
        private string label;
        private string varietal1;
        private int varietal1Pct;
        private string varietal2;
        private int varietal2Pct;
        private string varietal3;
        private int varietal3Pct;
        private string stillSparkFriz;
        private string color;
        private string dryness;
        private string containerType;
        private int containerVolume;
        private string containerVolUnits;
        private int currentBottleCount;
        //private string producerLocation;
        //private string comments;

        public int    WineID { get; }
        public string WineType { get; set; } //array validation
        public string Vintage { get; set; }  // code to validate 4-digit year
        public string Producer { get; set; } // table validation
        public string Country { get; set; }  // table validation
        public string Region { get; set; }   // table validation
        public string Appellation { get; set; } // table validation
        public string Label { get; set; } // free-form
        public string Varietal1 { get; set; }
        public int    Varietal1Pct { get; set; }
        public string Varietal2 { get; set; }
        public int    Varietal2Pct { get; set; }
        public string Varietal3 { get; set; }
        public int    Varietal3Pct { get; set; }
        public string StillSparkFriz { get; set; } // array validation
        public string Color { get; set; } // array validation
        public string Dryness { get; set; } // array validation
        public string ContainerType { get; set; } // array validation
        public int    ContainerVolumeAmount { get; set; } // code to validate "reasonable" number
        public string ContainerVolUnits { get; set; } // array validation
        public int    CurrentBottleCount;  
        //public string ProducerLocation
        //public string Comments { get; set; }

        public WineProfile() { }

        public WineProfile(int wineID, string vintage, string producer, string country,
            string region, string appellation, string label, string varietal1,
            int varietal1Pct, string varietal2, int varietal2Pct, string varietal3,
            int varietal3Pct, string wineType, string stillOrSparkling, string color,
            string dryness, int currentBottleCount)
        {
            WineID = wineID;
            Vintage = vintage;
            Producer = producer;
            Country = country;
            Region = region;
            Appellation = appellation;
            Label = label;
            Varietal1 = varietal1;
            Varietal1Pct = varietal1Pct;
            Varietal2 = varietal2;
            Varietal2Pct = varietal2Pct;
            Varietal3 = varietal3;
            Varietal3Pct = varietal3Pct;
            WineType = wineType;
            StillSparkFriz = stillSparkFriz;
            Color = color;
            Dryness = dryness;
            CurrentBottleCount = currentBottleCount;
            ContainerType = CONTAINER_TYPE;
            ContainerVolumeAmount = CONTAINER_VOLUME;
            ContainerVolUnits = CONTAINER_VOL_UNITS;
        }

        public WineProfile BuildWineProfile(int lastWineID)
        {
            int intResponse;
            int intVintage = 0;
            string[] wineTypeArray = new string[] { "Table", "Sparkling", "Dessert", "Port", "Other" };
            string[] ssfArray = new string[] { "Still", "Sparkling", "Frizzante" };
            string[] colorArray = new string[] { "Red", "White", "Rose" };
            string[] drynessArray = new string[] { "Dry", "Off-dry", "Sweet", "Other" };

            UserInterface.DisplayMessage("Creating new wine profile:");

            wineID = lastWineID;

            // EXCEPTION HANDLING WILL BE ADDED TO REPROMPT IF ENTRY OUT OF RANGE
            UserInterface.DisplayPrompt("Table=1, Sparkling=2, Dessert=3, Port=4, Other=5: ");
            intResponse = UserInterface.GetInteger();
            wineType = wineTypeArray[intResponse-1];

            UserInterface.DisplayPrompt("Is this a non-vintage wine? (Y/N) ");
            string stringResponse = UserInterface.GetString();
            if (stringResponse.ToUpper() == "Y")
                vintage = "NV";
            else
            {
                UserInterface.DisplayPrompt("Vintage? ");
                try
                {
                    intVintage = UserInterface.GetInteger();
                }
                catch
                {

                }
                vintage = intVintage.ToString();
            }
            
            UserInterface.DisplayPrompt("Producer Name? ");
            producer = UserInterface.GetString();

            UserInterface.DisplayPrompt("Label? ");
            label = UserInterface.GetString();

            UserInterface.DisplayPrompt("Country of origin? ");
            country = UserInterface.GetString();

            UserInterface.DisplayPrompt("Region of Origin? ");
            region = UserInterface.GetString();

            UserInterface.DisplayPrompt("Appellation? ");
            appellation = UserInterface.GetString();

            //
            // NEXT PHASE: won't need this kloo-gee stuff for
            //  varietals & percentages - they will be stored in the
            //  "VarietalPercentage" table
            //
            UserInterface.DisplayPrompt("Varietal #1 name? ");
                varietal1 = UserInterface.GetString();
            if (varietal1 != "")
            {
                UserInterface.DisplayPrompt("Varietal #1 percent? ");
                try
                {
                    varietal1Pct = UserInterface.GetInteger();
                }
                catch
                {
                    varietal1Pct = 0;
                }
                UserInterface.DisplayPrompt("Varietal #2 name? ");
                varietal2 = UserInterface.GetString();
                if (varietal2 != "")
                {
                    UserInterface.DisplayPrompt("Varietal #2 percent? ");
                    try
                    {
                        varietal2Pct = UserInterface.GetInteger();
                    }
                    catch
                    {
                        varietal2Pct = 0;
                    }
                    UserInterface.DisplayPrompt("Varietal #3 name? ");
                    varietal3 = UserInterface.GetString();
                    if (varietal3 != "")
                    { 
                        UserInterface.DisplayPrompt("Varietal #3 percent? ");
                        try
                        {
                            varietal3Pct = UserInterface.GetInteger();
                        }
                        catch
                        {
                            varietal3 = "";
                            varietal3Pct = 0;
                        }
                    
                    }
                    
                }
            }

            // FOR stillSparkFriz, color, and dryness,
            // EXCEPTION HANDLING TO REPROMPT IF ENTRY OUT OF RANGE
            UserInterface.DisplayPrompt("Still Wine=1, Sparkling=2, Frizzante=3: ");
            intResponse = UserInterface.GetInteger();
            try
            {
                stillSparkFriz = ssfArray[intResponse - 1];
            }
            catch
            {
                stillSparkFriz = "";
            }

            UserInterface.DisplayPrompt("Red=1, White=2, Rose=3: ");
            intResponse = UserInterface.GetInteger();
            try
            {
                color = colorArray[intResponse - 1];
            }
            catch
            {
                color = "";
            }

            UserInterface.DisplayPrompt("Dry=1, Off-dry=2, Sweet=3, Other=4: ");
            intResponse = UserInterface.GetInteger();
            try
            {
                dryness = drynessArray[intResponse - 1];
            }
            catch
            {
                dryness = "";
            }

            UserInterface.DisplayPrompt("How may bottles? ");
            currentBottleCount = UserInterface.GetInteger();
            
            WineProfile thisWine = new WineProfile(wineID, vintage, producer, country,
                region, appellation, label, varietal1, varietal1Pct, varietal2, varietal2Pct,
                varietal3, varietal3Pct, wineType, stillSparkFriz, color, dryness, currentBottleCount);

            return thisWine;
        }

        public static void ConfirmNewProfileAdded(WineProfile thisWine)
        {
            UserInterface.DisplayMessage($"\nWINE PROFILE:\n============\n" +
                "{thisWine.ToString()}\n WAS JUST ADDED TO YOUR CELLAR\n");
        }

        // NOT YET INTEGRATED INTO APPLICATION
        public void AddOrRemoveBottles(int wineID)
        {
            string addOrRemove = "";
            int numberOfBottles = 0;
            bool transactionCompleted = true;

            if (addOrRemove == "add")
                currentBottleCount += numberOfBottles;
            else
            {
                if (numberOfBottles <= currentBottleCount)
                    currentBottleCount -= numberOfBottles;
                else
                    transactionCompleted = false;
                UserInterface.DisplayMessage(
                    $"You currently have {currentBottleCount} bottle(s) of this wine. " +
                        $"You cannot remove {numberOfBottles} bottles.");
            }
            if (transactionCompleted)
            {
                string hasHave = "have";
                if (numberOfBottles == 1)
                    hasHave = "has";
                string addedRemoved = "added";
                if (addOrRemove == "remove")
                    addedRemoved = "removed";
                UserInterface.DisplayMessage($"{numberOfBottles} bottles of " +
                        $"wine #{wineID} {hasHave} been {addedRemoved} from your collection");
                LogTransaction(wineID, addOrRemove, numberOfBottles);
            }
        }

        public static void ListCellarContents(List<WineProfile> inventoryList)
        {
            string header = "\nCURRENT INVENTORY:\n==================" +
                $"(You have {inventoryList.Count} wines in your cellar)";
            UserInterface.DisplayMessage(header);
            foreach (WineProfile thisWine in inventoryList)
            {
                string summaryString = $"Wine ID: {thisWine.WineID}  Vintage: {thisWine.Vintage}  " +
                    $"Producer: {thisWine.Producer}  Label: {thisWine.Label}";
                Console.WriteLine(summaryString);
            }
        }

        public override string ToString()
        {
            string profileString = $"Wine ID#: {WineID}\n" +
                $"Wine Type: {WineType}\nVintage:  {Vintage}\n" +
                $"Producer: {Producer}\nCountry:  {Country}\nRegion: {Region}, " +
                $"Appellation: {Appellation}\nLabel: {Label}\n" +
                $"Varietal #1: {Varietal1}, {Varietal1Pct}%\n" +
                $"Varietal #2: {Varietal2}, {Varietal2Pct}%\n" +
                $"Varietal #3: {Varietal3}, {Varietal3Pct}%\n" +
                $"StillSparkling/Frizzante: {StillSparkFriz}\n" +
                $"Color: { Color}\nDryness:  { Dryness}\nContainer Type:  {ContainerType}\n" +
                $"Current Bottle Count: {CurrentBottleCount}";

            return profileString;
        }

        // NOT YET INTEGRATED INTO APPLICATION
        public static void LogTransaction(int wineID, string addOrRemove, int numberOfBottles)
        {
            string transaction = $"{wineID},{DateTime.Now},{addOrRemove},{numberOfBottles}";
        }
    }
}
