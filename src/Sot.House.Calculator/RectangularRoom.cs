using System;

namespace Sot.House.Calculator
{
    public class RectangularRoom
    {
        public RectangularRoom(string name, decimal length, decimal breadth)
        {
            Name = name;
            Length = length;
            Breadth = breadth;
        }

        /// <summary>
        /// Longueur
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Longueur
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// Largeur
        /// </summary>
        public decimal Breadth { get; set; }

        /// <summary>
        /// Cavalier
        /// </summary>
        public decimal Rider => CountCrossbarStartInLength * CountCrossbarStartInBreadth;

        /// <summary>
        /// Attach
        /// </summary>
        public decimal CountAttach => (CountAttachInLength * CountCrossbarStartInLength) + (CountCrossbarStartInBreadth * CountAttachInBreath);

        /// <summary>
        /// Nombre de traverse
        /// </summary>
        public decimal StartCrossbarCount => CountCrossbarStartInLength * CountCrossbarStartInBreadth;

        public decimal CountCrossbarStartInLength => Math.Floor(Length / Constant.MinimalCrossbarInLength);

        public decimal CountCrossbarStartInBreadth => Math.Floor(Breadth / Constant.MinimalCrossbarInBreadth);

        public decimal CountAttachInLength => Math.Floor(Breadth / Constant.CrossbarSize);

        public decimal CountAttachInBreath => Math.Floor(Length / Constant.CrossbarSize);

        public decimal TotalCrossbarDistance => (Length * CountCrossbarStartInLength) + (Breadth * CountCrossbarStartInBreadth);

        public decimal TotalCrossbarInBreath => CountCrossbarStartInBreadth * (1 + CountAttachInBreath);

        public decimal TotalCrossbarInLength => CountCrossbarStartInLength * (1 + CountAttachInLength);

        public decimal TotalCrossbar => TotalCrossbarInBreath + TotalCrossbarInLength;

        public object TotalLengthCrossbar => Breadth * CountCrossbarStartInBreadth + Length * CountCrossbarStartInLength;
    }
}
