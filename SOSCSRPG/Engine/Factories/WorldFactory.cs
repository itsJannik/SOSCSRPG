using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using Engine.Properties;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", "This is your Home", Resources.Home);
            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here with giant rats between them",
                Resources.FarmFields);
            newWorld.AddLocation(0, -1, "Farmer's House",
                "This is the house of your neighbor, farmer Tom",
                Resources.Farmhouse);
            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                Resources.Trader);

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                Resources.TownSquare);

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                Resources.TownGate);

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                Resources.SpiderForest);

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                Resources.HerbalistsHut);

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                Resources.HerbalistsGarden);
            return newWorld;
        }
    }
}
