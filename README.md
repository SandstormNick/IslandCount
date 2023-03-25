# IslandCount

A program that handles a challange to count all the islands on a given "map" which is a 2D integer array.

Unit tests have also been added to try cater for as many cases as possible.

## The Challenge:

You will be given a 2d array of integers. These integers will be a representation of a map. '1' will represent land and '0' will represent ocean. Your goal is to find the count of islands that appear on the map.

You will be given a 2d array of integers. These integers will be a representation of a map. '1' will represent land and '0' will represent ocean. Your goal is to find the count of islands that appear on the map.

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