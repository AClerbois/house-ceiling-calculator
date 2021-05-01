using System;
using System.Collections.Generic;

namespace Sot.House.Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            IList<RectangularRoom> Rooms = new List<RectangularRoom>
            {
                new RectangularRoom("Salle de bain main", 177, 520),
                new RectangularRoom("Chambre enfant 1", 378, 321),
                new RectangularRoom("Chambre enfant 2", 378, 321),
                new RectangularRoom("Suite parentale - dressing", 145, 520),
                new RectangularRoom("Suite parentale - chambre", 294, 331),
                new RectangularRoom("Suite parentale - salle de bain", 294, 179),
                new RectangularRoom("Hall", 766, 190),
                new RectangularRoom("Toilette nuit", 138, 90),
                new RectangularRoom("Bureau", 520, 354),
                new RectangularRoom("Cuisine", 520, 426),
                new RectangularRoom("Chaufferie", 327, 229),
                new RectangularRoom("Toilette", 90, 149+178),
                new RectangularRoom("Hall", 242, 189),
                new RectangularRoom("Living", 1169, 524),
            };

            decimal totalCountCrossbarStartInBreadth = 0;
            decimal totalCountCrossbarStartInLength = 0;
            decimal totalCountAttach = 0;
            decimal totalRider = 0;
            decimal totalTotalCrossbar = 0;
            decimal totalTotalCrossbarDistance = 0;
            foreach (var room in Rooms)
            {
                Console.WriteLine($"{string.Format("{0,35}", room.Name)} \t Start : {room.CountCrossbarStartInBreadth}x{room.CountCrossbarStartInLength} \t Attach : {room.CountAttach} \t Rider : {room.Rider} \t Crossbar count : {room.TotalCrossbar} (distance: {room.TotalCrossbarDistance})");
                totalCountCrossbarStartInBreadth += room.CountCrossbarStartInBreadth;
                totalCountCrossbarStartInLength += room.CountCrossbarStartInLength;
                totalCountAttach += room.CountAttach;
                totalRider += room.Rider;
                totalTotalCrossbar += room.TotalCrossbar;
                totalTotalCrossbarDistance += room.TotalCrossbarDistance;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{string.Format("{0,35}", $"Total for {Rooms.Count} room with L:{Constant.MinimalCrossbarInLength} & l:{Constant.MinimalCrossbarInBreadth}")}  \t Start : {totalCountCrossbarStartInBreadth}x{totalCountCrossbarStartInLength} \t Attach : {totalCountAttach} \t Rider : {totalRider} \t Crossbar count : {totalTotalCrossbar} (distance: {totalTotalCrossbarDistance} \t crossbar with recuperation : {Math.Floor(totalTotalCrossbarDistance / Constant.CrossbarSize) + 1 } )");
        }
    }
}
