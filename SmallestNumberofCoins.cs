using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Coins
{
    public class SmallestNumberofCoins
    {
         public static void Main(string[] args)
        {
            //initialize the amount wanted to reach
            int total = 100;
            //variable showing if it is possiable to reach total given the coins
            String result = "not possiable";
            //array holding coins
            int[] coins = new int[4];
            //array holding the number of times a coin is used
            int[] amount = new int[coins.Length];
            //initialize coin amounts
            coins[0] = 1;
            coins[1] = 0;
            coins[2] = 0;
            coins[3] = 0;
            
            //sort coins is ascending order 
            Array.Sort(coins);
            
            //iterate through coins starting at largest amount
            for(int i=coins.Length-1;i>0;i--){
               
                //if coins amount is greater than 0, call decrease method
                if(coins[i] > 0){
                     amount[i]=decrease(coins[i],ref total);
                }
               
                //if total is 0, it is possiable, so break out of loop as no more coins are needed
                 if(total == 0){
                    result = "possiable";
                    break;
                }
            
            }
            
            //iterate through coins array displaying each coins and number of times used
            for(int i=0;i<coins.Length;i++){
                Console.WriteLine(coins[i] + "  used " + amount[i] + "  times");
            
            }
            //display if total could be reached
            Console.WriteLine("to reach a total of " + total + " so it is " + result);
           
            
        }
        
        //method that decrease the total by the coin amount, takes two parameters coin amount and total
        public static int decrease(int coin, ref int total){
           
            //if total minus coin amount is less than 0, return
            if(total-coin < 0 ){
                return 0;
            }
            //minus coin from total
            total = total - coin;
            //call the decrease method again, when it unwinds it pluses 1 (number of times coin is used)
            return 1 + decrease(coin,ref total);
        
        }
    }
}