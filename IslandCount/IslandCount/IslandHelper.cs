﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandCount
{
    public class IslandHelper
    {
        public static int IslandFinder(int[][] gridInput)
        {
            int islandCount = 0;

            for (int outer = 0; outer < gridInput.Length; outer++)
            {
                for (int inner = 0; inner < gridInput[outer].Length; inner++)
                {
                    bool isEdge = false;
                    //cater for co-ordinates on the edge
                    if (outer == 0 || inner == 0)
                    {
                        isEdge = true;
                    }

                    //isEdge flag deals with map points on top and left
                    //Don't need to check above
                    if (isEdge && outer == 0)
                    {
                        //Top left corner
                        if (gridInput[outer][inner] == 1 && inner == 0)
                        {
                            islandCount++;
                        }

                        //Top left corner has been handled - check previous co-ord to the left
                        if (gridInput[outer][inner] == 1 && inner != 0 && gridInput[outer][inner - 1] != 1)
                        {
                            islandCount++;
                        }
                    }

                    //Don't need to check left + ignore the top row (it has been handled)
                    if (isEdge && inner == 0 && outer != 0)
                    {
                        //check previous co-ord above
                        if (gridInput[outer][inner] == 1 && gridInput[outer - 1][inner] != 1)
                        {
                            islandCount++;
                        }
                    }

                    //All the other co-ordinates that have isEdge as false

                    //Check row length above to cater for jagged arrays
                    if (!isEdge && inner < gridInput[outer - 1].Length)
                    {
                        //Check the co-ord above && to left
                        if (gridInput[outer][inner] == 1 && 
                            gridInput[outer - 1][inner] != 1 &&
                            gridInput[outer][inner - 1] != 1)
                        {
                            islandCount++;
                        }
                    }

                    //If current inner co-ord is greater than above row
                    if (!isEdge && inner > gridInput[outer - 1].Length - 1)
                    {
                        //Only Check the co-ord to the left
                        if (gridInput[outer][inner] == 1 && gridInput[outer][inner - 1] != 1)
                        {
                            islandCount++;
                        }
                    }
                }
            }
            return islandCount;
        }

        //ChatGBT's version of handling the problem
        //1. The HashSet class keeps track of visited cells.
        //2. The Dfs function is declared as an inner function
        //3. It makes use of recursion to set the visited value in the HashSet

        //THE EXPECTED OUTCOME DOES NOT WORK THOUGH
        //It might be that it did not understand the question correctly.
        //WIth some guidance it might have eventually got there.
        public static int CountIslands(int[][] grid)
        {
            int numRows = grid.Length;
            int numCols = grid[0].Length;
            HashSet<(int, int)> visited = new HashSet<(int, int)>();
            int numIslands = 0;

            void Dfs(int row, int col)
            {
                if (row < 0 || row >= numRows || col < 0 || col >= numCols)
                {
                    return;
                }
                if (visited.Contains((row, col)))
                {
                    return;
                }
                if (grid[row][col] == 0)
                {
                    return;
                }
                visited.Add((row, col));
                Dfs(row + 1, col);
                Dfs(row - 1, col);
                Dfs(row, col + 1);
                Dfs(row, col - 1);
            }

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (grid[row][col] == 1 && !visited.Contains((row, col)))
                    {
                        numIslands++;
                        Dfs(row, col);
                    }
                }
            }
            return numIslands;
        }
    }
}
