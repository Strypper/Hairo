using System;
using System.Collections.Generic;
using System.Text;

namespace Hario.Shared.Models
{
    public class HairoStory
    {
        public string HairoStoryId { get; set; }
        public string StoreName { get; set; }
        public string StoreLogo { get; set; }
        public string StoryUrl { get; set; }
        public string Service { get; set; }
        public decimal ServicePrice { get; set; }
    }

    public class DemoHairoStoryData
    {
        public static List<HairoStory> GetData()
        {
            var data = new List<HairoStory>();
            data.Add(new HairoStory { HairoStoryId = "HS1", StoreName = "30Shine", StoreLogo = "ms-appx:///Assets/DemoPurpose/Logo30Shine.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS2", StoreName = "ACE LONDON HAIR", StoreLogo = "ms-appx:///Assets/DemoPurpose/ACELONDONHAIR.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair1.jpg", Service = "Under cut", ServicePrice = 110000 });
            data.Add(new HairoStory { HairoStoryId = "HS3", StoreName = "GENTLEMAN", StoreLogo = "ms-appx:///Assets/DemoPurpose/GENTLEMAN.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair2.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS4", StoreName = "ACE LONDON HAIR", StoreLogo = "ms-appx:///Assets/DemoPurpose/ACELONDONHAIR.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair3.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS5", StoreName = "TONI AND GUY", StoreLogo = "ms-appx:///Assets/DemoPurpose/TONIANDGUY.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair4.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS6", StoreName = "GENTLEMAN", StoreLogo = "ms-appx:///Assets/DemoPurpose/GENTLEMAN.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair5.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS7", StoreName = "GENTLEMAN", StoreLogo = "ms-appx:///Assets/DemoPurpose/GENTLEMAN.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair6.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS8", StoreName = "30Shine", StoreLogo = "ms-appx:///Assets/DemoPurpose/Logo30Shine.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair7.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS9", StoreName = "ACE LONDON HAIR", StoreLogo = "ms-appx:///Assets/DemoPurpose/ACELONDONHAIR.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair8.jpg", Service = "Under cut", ServicePrice = 70000 });
            data.Add(new HairoStory { HairoStoryId = "HS10", StoreName = "TONI AND GUY", StoreLogo = "ms-appx:///Assets/DemoPurpose/TONIANDGUY.png", StoryUrl = "ms-appx:///Assets/DemoPurpose/MenHair9.jpg", Service = "Under cut", ServicePrice = 70000 });
            return data;
        }
    }
}
