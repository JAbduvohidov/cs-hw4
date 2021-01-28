using System;

namespace homework4
{
    public class TrafficLight
    {
        public bool IsRed { get; private set; }

        public bool IsYellow { get; private set; } = true;
        public bool IsGreen { get; private set; }

        public enum Color
        {
            Red = 1,
            Yellow = 2,
            Green = 3
        }

        public Color GetCurrentColor()
        {
            if (IsRed)
                return Color.Red;

            return IsYellow ? Color.Yellow : Color.Green;
        }

        public void PrintCurrentColor()
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = GetCurrentColor() switch
            {
                Color.Red => ConsoleColor.Red,
                Color.Yellow => ConsoleColor.Yellow,
                Color.Green => ConsoleColor.Green,
                _ => ConsoleColor.White
            };
            Console.Write(GetCurrentColor());
            Console.ForegroundColor = currentColor;
        }

        public void SetCurrentColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    IsRed = true;
                    IsYellow = false;
                    IsGreen = false;
                    break;
                case Color.Yellow:
                    IsRed = false;
                    IsYellow = true;
                    IsGreen = false;
                    break;
                case Color.Green:
                    IsRed = false;
                    IsYellow = false;
                    IsGreen = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(color), color, "color not found");
            }
        }
    }
}