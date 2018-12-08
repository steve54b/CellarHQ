using System;
using System.Collections.Generic;

namespace CellarHQ
{
    class Program
    {
        static void Main(string[] args)
        {
            WineProfile newWineProfile = new WineProfile();
            InventoryList myInventoryList = new InventoryList();

            int lastWineID = 1000;

            bool addAnotherWine = true;

            while (addAnotherWine)
            {
                lastWineID += 1;
                newWineProfile = newWineProfile.BuildWineProfile(lastWineID);
                myInventoryList.inventoryList.Add(newWineProfile);
                WineProfile.ConfirmNewProfileAdded(newWineProfile);

                UserInterface.DisplayPrompt("Add another wine? (Y/N) ");
                string response = UserInterface.GetString();
                if (response.ToUpper() != "Y")
                {
                    addAnotherWine = false;
                    UserInterface.DisplayMessage("\nEND OF NEW WINE ENTRY\n");
                }
            }

            WineProfile.ListCellarContents(myInventoryList.inventoryList);

            UserInterface.PromptForExit();  // to preserve console output
        }
    }
}
