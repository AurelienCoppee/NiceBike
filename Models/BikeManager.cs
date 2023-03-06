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

        bikeModels["Adventure"].Add("StrengthenedFrame", new List<string>());
        bikeModels["Adventure"]["StrengthenedFrame"].Add("1");

        bikeModels["Adventure"].Add("FrameSize", new List<string>());
        bikeModels["Adventure"]["FrameSize"].Add("S");
        bikeModels["Adventure"]["FrameSize"].Add("L");

        bikeModels["Adventure"].Add("FrameColor", new List<string>());
        bikeModels["Adventure"]["FrameColor"].Add("Red");
        bikeModels["Adventure"]["FrameColor"].Add("Blue");
        bikeModels["Adventure"]["FrameColor"].Add("Black");

        bikeModels["Adventure"].Add("MudguardSize", new List<string>());
        bikeModels["Adventure"]["MudguardSize"].Add("S");
        bikeModels["Adventure"]["MudguardSize"].Add("L");

        bikeModels["Adventure"].Add("MudguardColor", new List<string>());
        bikeModels["Adventure"]["MudguardColor"].Add("Red");
        bikeModels["Adventure"]["MudguardColor"].Add("Blue");
        bikeModels["Adventure"]["MudguardColor"].Add("Black");

        bikeModels["Adventure"].Add("RimSize", new List<string>());
        bikeModels["Adventure"]["RimSize"].Add("S");
        bikeModels["Adventure"]["RimSize"].Add("L");

        bikeModels["Adventure"].Add("TyreSize", new List<string>());
        bikeModels["Adventure"]["TyreSize"].Add("S");
        bikeModels["Adventure"]["TyreSize"].Add("L");

        bikeModels["Adventure"].Add("WheelHub", new List<string>());
        bikeModels["Adventure"]["WheelHub"].Add("1");

        // Notes:
        // - City and Explorer bike models have information about frame size, fork size, mudguard size, mudguard color, and rim size.
        // - City bike model has information about frame color.
        // - Explorer bike model has information about large mudguard size, large mudguard color, large tire size, lighting, luggage carrier, pedals kit, rear sprocket, and reflector.
        // - Adventure bike model has information about strengthened bike frame, frame size, frame color, mudguard size, mudguard color, rim size, tyre size, and wheel hub.






    }

}
