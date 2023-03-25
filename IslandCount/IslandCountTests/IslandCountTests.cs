using IslandCount;
namespace IslandCountTests
{
    public class IslandCountTests
    {
        [Fact]
        public void Map1_IslandFinder_1Island()
        {
            //All rows are of equal length
            Assert.Equal(1, IslandHelper.IslandFinder(map1));
        }

        [Fact]
        public void Map2_IslandFinder_3Islands()
        {
            //All rows are of equal length
            Assert.Equal(3, IslandHelper.IslandFinder(map2));
        }

        [Fact]
        public void MapOuterPerimeter_IslandFinder_3Islands()
        {
            //All rows are of equal length
            Assert.Equal(1, IslandHelper.IslandFinder(mapOuterPerimeter));
        }

        [Fact]
        public void MapCircles_IslandFinder_3Islands()
        {
            //All rows are of equal length
            Assert.Equal(2, IslandHelper.IslandFinder(mapCircles));
        }

        [Fact]
        public void MapOnlyColumns_IslandFinder_3Islands()
        {
            //All rows are of equal length
            Assert.Equal(3, IslandHelper.IslandFinder(mapOnlyColumns));
        }

        [Fact]
        public void MapOnlyRows_IslandFinder_3Islands()
        {
            //All rows are of equal length
            Assert.Equal(2, IslandHelper.IslandFinder(mapOnlyRows));
        }

        [Fact]
        public void Map1RowOnly_IslandFinder_2Islands()
        {
            //Testing the logic for the top row
            Assert.Equal(2, IslandHelper.IslandFinder(map1RowOnly));
        }

        [Fact]
        public void Map1ColumnOnly_IslandFinder_2Islands()
        {
            //Testing the logic for left column
            Assert.Equal(2, IslandHelper.IslandFinder(map1ColumnOnly));
        }

        [Fact]
        public void MapCheckLeftLogic_IslandFinder_3Islands()
        {
            //Testing the logic to check co-ords to the left
            Assert.Equal(3, IslandHelper.IslandFinder(mapCheckLeftLogic));
        }

        [Fact]
        public void MapCheckTopLogic_IslandFinder_3Islands()
        {
            //Testing the logic to check co-ords above
            Assert.Equal(3, IslandHelper.IslandFinder(mapCheckTopLogic));
        }

        [Fact]
        public void MapJagged1_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            Assert.Equal(4, IslandHelper.IslandFinder(mapJagged1));
        }

        [Fact]
        public void MapJaggedE_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            Assert.Equal(4, IslandHelper.IslandFinder(mapJaggedE));
        }

        [Fact]
        public void MapJaggedPyramid_IslandFinder_4Islands()
        {
            //Testing for Jagged Maps
            Assert.Equal(6, IslandHelper.IslandFinder(mapJaggedPyramid));
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

        static readonly int[][] mapOuterPerimeter = new int[][]
        {
            new int[] { 1,1,1,1,1 },
            new int[] { 1,0,0,0,1 },
            new int[] { 1,0,0,0,1 },
            new int[] { 1,1,1,1,1 }
        };

        static readonly int[][] mapCircles = new int[][]
        {
            new int[] { 1,1,1,1,1,1,1 },
            new int[] { 1,0,0,0,0,0,1 },
            new int[] { 1,0,1,1,1,0,1 },
            new int[] { 1,0,1,0,1,0,1 },
            new int[] { 1,0,1,1,1,0,1 },
            new int[] { 1,0,0,0,0,0,1 },
            new int[] { 1,1,1,1,1,1,1 }
        };

        static readonly int[][] mapOnlyColumns = new int[][]
        {
            new int[] { 1,0,1,0,1 },
            new int[] { 1,0,1,0,1 },
            new int[] { 1,0,1,0,1 },
            new int[] { 1,0,1,0,1 }
        };

        static readonly int[][] mapOnlyRows = new int[][]
        {
            new int[] { 1,1,1,1,1 },
            new int[] { 0,0,0,0,0 },
            new int[] { 1,1,1,1,1 },
            new int[] { 0,0,0,0,0 }
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