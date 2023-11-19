using System;
using System.Collections.Generic;

class Program
{
    // Sample data (You can replace this with your actual data)
    static List<Tuple<int, int, int, string>> data = new List<Tuple<int, int, int, string>>
    {
        Tuple.Create(27, 46, 2, "East"),
        Tuple.Create(40, 50, 4, "West"),
        Tuple.Create(28, 42, 1, "North"),
        Tuple.Create(14, 29, 15, "South")
    };

    static List<Tuple<int, int, int, string>> VisiblePoints(Tuple<int, int, int, string> referencePoint, int coneAngle, int maxDirection)
    {
        List<Tuple<int, int, int, string>> visiblePoints = new List<Tuple<int, int, int, string>>();

        foreach (var point in data)
        {
            int deltaX = point.Item1 - referencePoint.Item1;
            int deltaY = point.Item2 - referencePoint.Item2;

            // Calculate the direction in degrees
            double direction = Math.Atan2(deltaY, deltaX) * (180.0 / Math.PI);

            // Calculate the angle difference between the direction and the max direction
            double angleDifference = Math.Abs(direction - maxDirection);

            // Ensure the direction is within the specified cone
            if (angleDifference <= coneAngle / 2)
            {
                visiblePoints.Add(point);
            }
        }

        return visiblePoints;
    }


    static void Main()
    {
        Tuple<int, int, int, string> referencePoint = Tuple.Create(1, 45, 20, "North");
        int coneAngle = 45;
        int maxDirection = 20;

        List<Tuple<int, int, int, string>> result = VisiblePoints(referencePoint, coneAngle, maxDirection);

        foreach (var point in result)
        {
            Console.WriteLine($"{point.Item1}, {point.Item2}, {point.Item3}, {point.Item4}");
        }
    }
}

