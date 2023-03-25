using IslandCount;

int[][] gridInput = new int[][]
{
    new int[] { 0,0,0,1,1 },
    new int[] { 0,0,0,1,1 },
    new int[] { 0,0,0,0,1 },
    new int[] { 0,0,0,0,0 }
};

Console.WriteLine(IslandHelper.IslandFinder(gridInput));