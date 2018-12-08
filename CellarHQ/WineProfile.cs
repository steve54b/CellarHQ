using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineProfile
    {
        // FOR THIS PHASE, hard-coded to 750 ml bottle
        public const int VOLUME_AMT = 750;
        public const string VOLUME_UNITS = "ml";
        public const string CONTAINER_TYPE = "bottle";

        private int wineID;
        private string vintage;
        private string country;
        private string appellation;
        private string producer;
        private string label;
        private string color;
        private string wineType;
        private string stillSparklingFrizzante;
        private string dryness;
        private string comments;
        private int currentBottleCount = 0;

        public int WineID { get; }
        public string Vintage { get; set; }  // code to validate 4-digit year
        public string Country { get; set; }  // table validation
        public string Appellation { get; set; } // table validation
        public string Producer { get; set; } // table validation
        public string ProducerLocation { get; set; } // table validation
        public string Label { get; set; } // free-form
        public string WineType { get; set; } //array validation
        public string Color { get; set; } // array validation
        public string StillSparklingFrizzante { get; set; } // array validation
        public string Dryness { get; set; } // array validation
        public string Comments { get; set; }
        public string ContainerType { get; set; } // array validation
        public int ContainerVolumeAmount { get; set; } // code to validate "reasonable" number
        public string ContainerVolumeUnits { get; set; } // array validation
        public int CurrentBottleCount { get; set; }

        public WineProfile() { }

        public WineProfile(int wineID, string vintage, string country,
            string appellation, string producer, string label,
            string color, string dryness, string stillSparklingFirzzante,
            string comments, int currentBottleCount = 0)
        {
            WineID = wineID;
            ContainerVolumeAmount = VOLUME_AMT;
            ContainerVolumeUnits = VOLUME_UNITS;
            Vintage = vintage;
            Country = country;
            Appellation = appellation;
            Producer = producer;
            Label = label;
            Color = color;
            Dryness = dryness;
            Comments = comments;
            ContainerType = CONTAINER_TYPE;
            CurrentBottleCount = currentBottleCount;
        }

        public WineProfile BuildWineProfile(int lastWineID)
        {
            int intResponse;
            int intVintage;

            UserInterface.DisplayMessage("Creating new wine profile:");

            wineID = lastWineID;
            UserInterface.DisplayPrompt("Is this a non-vintage wine? (Y/N) ");
            string stringResponse = UserInterface.GetString();
            if (stringResponse.ToUpper() == "Y")
                vintage = "NV";
            else
            {
                UserInterface.DisplayPrompt("Vintage? ");
                intVintage = UserInterface.GetInteger();
                vintage = intVintage.ToString();
            }

            UserInterface.DisplayPrompt("Country of Origin? ");
            country = UserInterface.GetString();

            UserInterface.DisplayPrompt("Region of Origin? ");
            appellation = UserInterface.GetString();

            UserInterface.DisplayPrompt("Producer Name? ");
            producer = UserInterface.GetString();

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
