# SmallestNumberofCoins
This program works out the least number of coins needed to reach a total. I used a recursive call to accomplish this, with a base case: if the total is less than 0 return.

---
For example:

initialize the amount and a array of coins 
```sh
//initialize the amount wanted to reach
    int total = 86;
    
//initialize coin amounts
    coins[0] = 1;
    coins[1] = 20;
    coins[2] = 4;
    coins[3] = 8;
```

if the total is  86 and coins used are: 1,20,4 and 8, the program will output

```sh
1  used 2  times
4  used 1  times
8  used 0  times
20  used 4  times
to reach a total of 0 so it is possiable
```
