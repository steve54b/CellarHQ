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
        private string wineType;
        private string stillOrSparkling;
        private string color;
        private string dryness;
        private string containerType;
        private int containerVolume;
        private string containerVolUnits;
        //private string producerLocation;
        //private string comments;

        public int    WineID { get; }
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
        public string WineType { get; set; } //array validation
        public string StillOrSparkling { get; set; } // array validation
        public string Color { get; set; } // array validation
        public string Dryness { get; set; } // array validation
        public string ContainerType { get; set; } // array validation
        public int ContainerVolumeAmount { get; set; } // code to validate "reasonable" number
        public string ContainerVolUnits { get; set; } // array validation
        //public string ProducerLocation
        //public string Comments { get; set; }

        public WineProfile() { }

        public WineProfile(int wineID, string vintage, string producer, string country,
            string region, string appellation, string label, string varietal1,
            int varietal1Pct, string varietal2, int varietal2Pct, string varietal3,
            int varietal3Pct, string wineType, string stillOrSparkling, string color,
            string dryness, string containerType, int containerVolumeAmount,
            string containerVolUnits)
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
            StillOrSparkling = stillOrSparkling;
            Color = color;
            Dryness = dryness;
            ContainerType = CONTAINER_TYPE;
            ContainerVolumeAmount = CONTAINER_VOLUME;
            ContainerVolUnits = CONTAINER_VOL_UNITS;
        }

        public WineProfile BuildWineProfile(int lastWineID)
        {
            int intResponse;
            int intVintage = 0;

            UserInterface.DisplayMessage("Creating new wine profile:");

            wineID = lastWineID;
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

            UserInterface.DisplayPrompt("Country of Origin? ");
            country = UserInterface.GetString();

            UserInterface.DisplayPrompt("Producer Name? ");
            producer = UserInterface.GetString();

            UserInterface.DisplayPrompt("Country of origin? ");
            country = UserInterface.GetString();

            UserInterface.DisplayPrompt("Region of Origin? ");
            region = UserInterface.GetString();

            UserInterface.DisplayPrompt("Appellation? ");
            appellation = UserInterface.GetString();

            UserInterface.DisplayPrompt("Varietal #1 name? ");
            varietal1 = UserInterface.GetString();

            UserInterface.DisplayPrompt("Varietal #1 percent? ");
            varietal1Pct = UserInterface.GetInteger();

            UserInterface.DisplayPrompt("Varietal #2 name? ");
            varietal2 = UserInterface.GetString();

            UserInterface.DisplayPrompt("Varietal #2 percent? ");
            varietal2Pct = UserInterface.GetInteger();

            UserInterface.DisplayPrompt("Varietal #3 name? ");
            varietal3 = UserInterface.GetString();

            UserInterface.DisplayPrompt("Varietal #3 percent? ");
            varietal3Pct = UserInterface.GetInteger();

            UserInterface.DisplayPrompt("Wine Label? ");
            label = UserInterface.GetString();

            UserInterface.DisplayPrompt("Color? ");
            intResponse = UserInterface.GetInteger();

            UserInterface.DisplayPrompt("Wine dryness? " +
                "(0 = Dry, 1 = Off-dry, 2 = Sweet, 3 = Other) ");
            intResponse = UserInterface.GetInteger();

            WineProfile thisWine = new WineProfile(wineID, vintage, country, appellation,
                 producer, label, color, dryness, comments);

            return thisWine;
        }

        public static void ConfirmNewProfileAdded(WineProfile thisWine)
        {
            UserInterface.DisplayMessage($"\nTHE FOLLOWING WINE PROFILE HAS BEEN ADDED TO YOUR CELLAR:" +
                $"\n{thisWine.ToString()}\n");
        }

        // NOT YET INTEGRATED INTO MAIN PROGRAM
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
            string header = "CURRENT INVENTORY:\n";
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
            string profileString = $"Wine ID#: {WineID}\nVintage:  {Vintage}\n" +
                $"Country:  {Country}\nAppellation:  {Appellation}\nProducer:  " +
                $"{Producer}\nLabel:  {Label}\nStill or Sparkling/Frizzante  {StillOrSparkling}\n" +
                $"Color: { Color}\nDryness:  { Dryness}\nContainer Type:  {ContainerType}\n" +
                $"Current Bottle Count:  {CurrentBottleCount}";

            return profileString;
        }

        // NOT YET INTEGRATED INTO MAIN PROGRAM
        public static void LogTransaction(int wineID, string addOrRemove, int numberOfBottles)
        {
            string transaction = $"{wineID},{DateTime.Now},{addOrRemove}, {numberOfBottles}";
        }
    }
}
