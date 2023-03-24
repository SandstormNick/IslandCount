using IslandCount;
namespace IslandCountTests
{
    public class IslandCountTests
    {
        [Fact]
        public void Map1_Output1()
        {
            IslandHelper ih = new IslandHelper();

            Assert.Equal(1, ih.IslandFinder(map1));
        }



        static readonly int[][] map1 = new int[][]
        {
            new int[] { 0,0,0,1,1 },
            new int[] { 0,0,0,1,1 },
            new int[] { 0,0,0,0,1 },
            new int[] { 0,0,0,0,0 }
        };

        static readonly int[][] map2 = new int[][]
        {
            new int[] { 0,0,0,1,1 },
            new int[] { 0,0,0,1,1 },
            new int[] { 0,0,1,0,0 },
            new int[] { 1,1,0,0,0 }
        };
    }
}