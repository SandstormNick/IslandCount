using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandCount
{
    public class IslandHelper
    {
        public int IslandFinder(int[][] gridInput)
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
                    
                    //deal with co-ordinates on top and left
                    if (isEdge)
                    {
                        //Don't need to check above
                        if (outer == 0) 
                        { 
                            if (gridInput[outer][inner] == 1)
                            {
                                //Top left corner
                                if (inner == 0)
                                {
                                    islandCount++;
                                }

                                //Top left corner has been handled - check previous co-ord to the left
                                if (inner != 0 && gridInput[outer][inner - 1] != 1)
                                {
                                    islandCount++;
                                }
                            }
                        }

                        //Don't need to check left + ignore the top row (it has been handled)
                        if (inner == 0 && outer != 0) 
                        {
                            if (gridInput[outer][inner] == 1)
                            {
                                //check previous co-ord above
                                if (gridInput[outer - 1][inner] != 1)
                                {
                                    islandCount++;
                                }
                            }
                        }
                    }

                    //All the other co-ordinates
                    if (!isEdge)
                    {
                        //Check row length above to cater for jagged arrays
                        if (inner < gridInput[outer - 1].Length)
                        {
                            if (gridInput[outer][inner] == 1)
                            {
                                //Check the co-ord above && to left
                                if (gridInput[outer - 1][inner] != 1 &&
                                    gridInput[outer][inner - 1] != 1)
                                {
                                    islandCount++;
                                }
                            }
                        }

                        //If current inner co-ord is greater than above row
                        if (inner > gridInput[outer - 1].Length - 1)
                        {
                            if (gridInput[outer][inner] == 1)
                            {
                                //Only Check the co-ord to the left
                                if (gridInput[outer][inner - 1] != 1)
                                {
                                    islandCount++;
                                }
                            }
                        }
                    }
                }
            }
            return islandCount;
        }
    }
}
