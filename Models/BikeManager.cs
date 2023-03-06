using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

internal class BikeManager
{
    private Dictionary<string, Dictionary<string, List<string>>> bikeModels = new Dictionary<string, Dictionary<string, List<string>>>();

    public BikeManager()
    {
        
        // Adding information for City bike model
        bikeModels.Add("City", new Dictionary<string, List<string>>());

        bikeModels["City"].Add("FrameSize", new List<string>());
        bikeModels["City"]["FrameSize"].Add("S");
        bikeModels["City"]["FrameSize"].Add("L");

        bikeModels["City"].Add("FrameColor", new List<string>());
        bikeModels["City"]["FrameColor"].Add("Red");
        bikeModels["City"]["FrameColor"].Add("Blue");
        bikeModels["City"]["FrameColor"].Add("Black");

        bikeModels["City"].Add("ForkSize", new List<string>());
        bikeModels["City"]["ForkSize"].Add("S");
        bikeModels["City"]["ForkSize"].Add("L");

        bikeModels["City"].Add("MudguardSize", new List<string>());
        bikeModels["City"]["MudguardSize"].Add("S");
        bikeModels["City"]["MudguardSize"].Add("L");

        bikeModels["City"].Add("MudguardColor", new List<string>());
        bikeModels["City"]["MudguardColor"].Add("Red");
        bikeModels["City"]["MudguardColor"].Add("Blue");
        bikeModels["City"]["MudguardColor"].Add("Black");

        bikeModels["City"].Add("RimSize", new List<string>());
        bikeModels["City"]["RimSize"].Add("S");
        bikeModels["City"]["RimSize"].Add("L");

        // Adding information for Explorer bike model
        bikeModels.Add("Explorer", new Dictionary<string, List<string>>());

        bikeModels["Explorer"].Add("FrameSize", new List<string>());
        bikeModels["Explorer"]["FrameSize"].Add("S");
        bikeModels["Explorer"]["FrameSize"].Add("L");

        bikeModels["Explorer"].Add("ForkSize", new List<string>());
        bikeModels["Explorer"]["ForkSize"].Add("S");
        bikeModels["Explorer"]["ForkSize"].Add("L");

        bikeModels["Explorer"].Add("LargeMudguardSize", new List<string>());
        bikeModels["Explorer"]["LargeMudguardSize"].Add("S");
        bikeModels["Explorer"]["LargeMudguardSize"].Add("L");

        bikeModels["Explorer"].Add("LargeMudguardColor", new List<string>());
        bikeModels["Explorer"]["LargeMudguardColor"].Add("Black");

        bikeModels["Explorer"].Add("ForkSize", new List<string>());
        bikeModels["Explorer"]["ForkSize"].Add("S");
        bikeModels["Explorer"]["ForkSize"].Add("L");

        bikeModels["Explorer"].Add("RimSize", new List<string>());
        bikeModels["Explorer"]["RimSize"].Add("S");
        bikeModels["Explorer"]["RimSize"].Add("L");

        bikeModels["Explorer"].Add("TyreSize", new List<string>());
        bikeModels["Explorer"]["TyreSize"].Add("S");
        bikeModels["Explorer"]["TyreSize"].Add("L");

        bikeModels["Explorer"].Add("LargeTyreSize", new List<string>());
        bikeModels["Explorer"]["LargeTyreSize"].Add("S");
        bikeModels["Explorer"]["LargeTyreSize"].Add("L");


        bikeModels.Add("Adventure", new Dictionary<string, List<string>>());

        bikeModels["Adventure"].Add("StrengthenedFrameSize", new List<string>());
        bikeModels["Adventure"]["StrengthenedFrameSize"].Add("S");
        bikeModels["Adventure"]["StrengthenedFrameSize"].Add("L");

        bikeModels["Adventure"].Add("StrengthenedFrameColor", new List<string>());
        bikeModels["Adventure"]["StrengthenedFrameColor"].Add("Red");
        bikeModels["Adventure"]["StrengthenedFrameColor"].Add("Blue");
        bikeModels["Adventure"]["StrengthenedFrameColor"].Add("Black");

        bikeModels["Adventure"].Add("RimSize", new List<string>());
        bikeModels["Adventure"]["RimSize"].Add("S");
        bikeModels["Adventure"]["RimSize"].Add("L");

        bikeModels["Adventure"].Add("LargeTyreSize", new List<string>());
        bikeModels["Adventure"]["LargeTyreSize"].Add("S");
        bikeModels["Adventure"]["LargeTyreSize"].Add("L");

        bikeModels["Adventure"].Add("ForkSize", new List<string>());
        bikeModels["Adventure"]["ForkSize"].Add("S");
        bikeModels["Adventure"]["ForkSize"].Add("L");

    }

}
