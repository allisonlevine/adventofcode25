string filePath = @"thtpath.txt";

var instructions = File.ReadAllLines(filePath)
                       .Select(line => (
                           Direction: line[0],
                           Distance: int.Parse(line.Substring(1))
                       ))
                       .ToList();

int currentPos1 = 50;
int currentPos2 = 50;

int endPointMatches = 0;
int pathMatches = 0;

foreach (var move in instructions)
{
    int stepDirection = (move.Direction == 'L') ? -1 : 1;

    currentPos1 += (stepDirection * move.Distance);

    if (currentPos1 % 100 == 0)
    {
        endPointMatches++;
    }

    for (int i = 0; i < move.Distance; i++)
    {
        currentPos2 += stepDirection;

        if (currentPos2 % 100 == 0)
        {
            pathMatches++;
        }
    }
}

Console.WriteLine(endPointMatches); 
Console.WriteLine(pathMatches);    
