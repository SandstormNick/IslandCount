using IslandCount;

int[][] gridInput = new int[][]
{
    new int[] { 0,0,0,1,1 },
    new int[] { 0,0,0,1,1 },
    new int[] { 0,0,0,0,1 },
    new int[] { 0,0,0,0,0 }
};

IslandHelper ih = new();

Console.WriteLine(ih.IslandFinder(gridInput));