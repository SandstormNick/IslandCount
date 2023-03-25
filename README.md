# IslandCount

A program that handles a challange to count all the islands on a given "map" which is a 2D integer array.

Unit tests have also been added to try cater for as many cases as possible.

## The Challenge:

You will be given a 2d array of integers. These integers will be a representation of a map. '1' will represent land and '0' will represent ocean. Your goal is to find the count of islands that appear on the map.

All land sections (represented by '1') that are immediately adjacent to other land sections count as one land mass. If there is a water section bordering the landmass on all sides it is considered an island. Assume that all sections outside of the given array are water so than a landmass that falls on the border is still an island.

Land sections that are diagonally adjacent do not count as continuous landmasses.

### Example 1:
```
Input: grid = [
  ["0","0","0","1","1"],
  ["0","0","0","1","1"],
  ["0","0","0","0","1"],
  ["0","0","0","0","0"]
]
Output: 1
```

### Example 2:
```
Input: grid = [
  ["0","0","0","1","1"],
  ["0","0","0","1","1"],
  ["0","0","1","0","0"],
  ["1","1","0","0","0"]
]
Output: 3
```