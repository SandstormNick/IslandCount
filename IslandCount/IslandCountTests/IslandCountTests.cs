using IslandCount;
namespace IslandCountTests
{
    public class IslandCountTests
    {
        [Fact]
        public void Map1_IslandFinder_1Island()
        {
            //All rows are of equal length
            IslandHelper ih = new IslandHelper();
            Assert.Equal(1, ih.IslandFinder(map1));
        }

        [Fact]
        public void Map2_IslandFinder_3Islands()
        {
            //All rows are of equal length
            IslandHelper ih = new IslandHelper();
            Assert.Equal(3, ih.IslandFinder(map2));
        }

        [Fact]
        public void Map1RowOnly_IslandFinder_2Islands()
        {
            //Testing the logic for the top row
            IslandHelper ih = new IslandHelper();
            Assert.Equal(2, ih.IslandFinder(map1RowOnly));
        }

        [Fact]
        public void Map1ColumnOnly_IslandFinder_2Islands()
        {
            //Testing the logic for left column
            IslandHelper ih = new IslandHelper();
            Assert.Equal(2, ih.IslandFinder(map1ColumnOnly));
        }

        [Fact]
        public void MapCheckLeftLogic_IslandFinder_3Islands()
        {
            //Testing the logic to check co-ords to the left
            IslandHelper ih = new IslandHelper();
            Assert.Equal(3, ih.IslandFinder(mapCheckLeftLogic));
        }

        [Fact]
        public void MapCheckTopLogic_IslandFinder_3Islands()
        {
            //Testing the logic to check co-ords above
            IslandHelper ih = new IslandHelper();
            Assert.Equal(3, ih.IslandFinder(mapCheckTopLogic));
        }

        [Fact]
        public void MapJagged1_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            IslandHelper ih = new IslandHelper();
            Assert.Equal(4, ih.IslandFinder(mapJagged1));
        }

        [Fact]
        public void MapJaggedE_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            IslandHelper ih = new IslandHelper();
            Assert.Equal(4, ih.IslandFinder(mapJaggedE));
        }

        [Fact]
        public void MapJaggedPyramid_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            IslandHelper ih = new IslandHelper();
            Assert.Equal(6, ih.IslandFinder(mapJaggedPyramid));
        }

        #region TestInput
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

        static readonly int[][] map1RowOnly = new int[][]
        {
            new int[] { 1,0,0,1,1 }
        };

        static readonly int[][] map1ColumnOnly = new int[][]
        {
            new int[] { 1 },
            new int[] { 0 },
            new int[] { 0 },
            new int[] { 1 },
            new int[] { 1 }
        };

        static readonly int[][] mapCheckLeftLogic = new int[][]
        {
            new int[] { 0,1,0 },
            new int[] { 0 },
            new int[] { 0 },
            new int[] { 1 },
            new int[] { 0,1,1,0,0 }
        };

        static readonly int[][] mapCheckTopLogic = new int[][]
        {
            new int[] { 1,0 },
            new int[] { 0,1 },
            new int[] { 0,0 },
            new int[] { 1,0 },
            new int[] { 1,0 }
        };

        static readonly int[][] mapJagged1 = new int[][]
        {
            new int[] { 0,0,0,1 },
            new int[] { 1,0,0,1,1 },
            new int[] { 0,1,0,1,0,1 },
            new int[] { 0,1,0,0 }
        };

        static readonly int[][] mapJaggedE = new int[][]
        {
            new int[] { 1,1,0,0,1 },
            new int[] { 1 },
            new int[] { 1,1,0,0,0 },
            new int[] { 0 },
            new int[] { 0,1,0,1,0 }
        };

        static readonly int[][] mapJaggedPyramid = new int[][]
        {
            new int[] { 1 },
            new int[] { 0,0 },
            new int[] { 0,1,1 },
            new int[] { 1,0,1,0 },
            new int[] { 0,1,0,0,1 },
            new int[] { 0,1,1,1 },
            new int[] { 1,0,0 },
            new int[] { 1,1 },
            new int[] { 1 }
        };
        #endregion TestInput
    }
}