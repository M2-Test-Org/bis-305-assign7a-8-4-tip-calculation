# BIS 305 Assignment 7A - Program Exercise 8-4.

This repo is for use to code and debug the BIS 305 Assignment 7A - Program Exercise 8-4.

Create a program named TipCalculation that includes two overloaded (Overloading 
involves the ability to write multiple versions of a method using the same method 
name....When you overload a C# method, you write multiple method implementations 
with the same name but different parameter lists. p322) methods named DisplayTipInfo. 
(The only two requirements to overload methods are the same identifier and different 
parameter lists. p. 324)

One should accept a meal price and a tip as doubles (for example, 30.00 and 0.20, where 
0.20 represents a 20 percent tip).

The other should accept a meal price as a double and a tip amount as an integer (for 
example, 30.00 and 5, where 5 represents a $5 tip).

Each method displays the meal price, the tip as a percentage of the meal price, the tip in 
dollars, and the total of the meal plus the tip. 

Include a Main() method that demonstrates each method.

For example if the input meal price is 30.00 and the tip is 0.20, the output should be:
```html
Meal price: $30.00. Tip percent: 0.20
Tip in dollars: $6.00.  Total bill $36.00
```
In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));