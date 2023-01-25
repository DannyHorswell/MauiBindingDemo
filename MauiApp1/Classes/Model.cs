using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Classes
{

    public class Item
    {
        public string Name { get; set; }
    }

    public class VerticalObject
    {
        /// <summary>
        /// A collection of items stacked horozontally
        /// </summary>
        public HorizontalObjectCollection HozItems { get; set; } = new HorizontalObjectCollection();
    }


    public class Model
    {
        /// <summary>
        /// A collection of items stacked vertically
        /// </summary>
        public VerticalObjectCollection VertItems { get; set; } = new VerticalObjectCollection();

        int thingCount;

        public string NextThingName()
        {
            return "Thing " + thingCount++;
        }

        public void AddSomeData()
        {
            var vert = new VerticalObject();

            vert.HozItems.Add(new Item() { Name = NextThingName() });
            vert.HozItems.Add(new Item() { Name = NextThingName() });


            VertItems.Add(vert);

            vert = new VerticalObject();

            vert.HozItems.Add(new Item() { Name = NextThingName() });
            vert.HozItems.Add(new Item() { Name = NextThingName() });

            VertItems.Add(vert);
        }
    }
}
