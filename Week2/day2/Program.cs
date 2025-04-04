using System;

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = "";
// double total = 0;
//
// foreach (var item in values)
// {
//   bool isDouble = double.TryParse(item, out double result);
//   if (isDouble) {
//     total+=result;
//     continue;
//   }
//   message+=item;
// }
//
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");
// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;
//
// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// var result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
//
// // Your code here to set result2
// var result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
//
// // Your code here to set result3
// var result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
//
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var item in pallets)
// {
//   Console.WriteLine($"-- {item}");
// }
//
// Console.WriteLine("");
// Console.WriteLine("Clear...");
// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//   Console.WriteLine($"After: {pallets[0].ToLower()}");
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("");
// Console.WriteLine("Resized...");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
//
// pallets[4] = "C01";
// pallets[5] = "C02";
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);
//
// Console.WriteLine("");
// result = String.Join(", ", valueArray);
// Console.WriteLine(result);
//
// Console.WriteLine("");
// foreach (var item in result.Split(","))
// {
//   Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] splitted = pangram.Split(" ");
// string reverseString = "";
// foreach (var item in splitted)
// {
//   char[] tempString = item.ToCharArray();
//   Array.Reverse(tempString);
//   reverseString+=$"{new string(tempString)} ";
// }
//
// Console.WriteLine($"pangram: {reverseString}");

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// int validCharLength = 4;
// string[] splitted = orderStream.Split(",");
// Array.Sort(splitted);
// foreach (var item in splitted)
// {
//   string id = item;
//   if (id.Length < validCharLength || id.Length > validCharLength)
//   {
//     id=$"{id}   - Error";
//   }
//   Console.WriteLine(id); 
// }

// string customerName = "Ms. Barros";
//
// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;
//
// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;
//
// // Your logic here
//
// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n");
// Console.WriteLine("Here's a quick comparison:");
//
// string comparisonMessage = $"{currentProduct.PadRight(24)}{currentReturn:P2}{currentProfit:C2}\n";
// comparisonMessage += $"{newProduct.PadRight(24)}{newReturn:P2}{newProfit:C2}";
//
// // Your logic here
//
// Console.WriteLine(comparisonMessage);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
output = input.Remove(input.IndexOf("<div>"), "<div>".Length);
output = output.Remove(output.IndexOf("</div>"), "</div>".Length);
quantity = output.Remove(0, output.IndexOf("<span>") + "<span>".Length);
quantity = quantity.Remove(quantity.IndexOf("</span>"), "</span>".Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
