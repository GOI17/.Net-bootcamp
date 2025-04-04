using System;

// System.Console.WriteLine("a" == "a");
// System.Console.WriteLine("a" == "a ");
// System.Console.WriteLine("a" == "A");
// System.Console.WriteLine(1 == 2);
//
// string myValue = "a";
// System.Console.WriteLine(myValue == "a");
//
// string value1 = " a";
// string value2 = "A ";
//
// System.Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// System.Console.WriteLine("a" != "a");
// System.Console.WriteLine("a" != "A");
// System.Console.WriteLine(1 != 2);
//
// string myValue = "a";
// System.Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// Console.WriteLine(pangram.Contains("fox") == false);
//
// // Logical Negation -> !
// Console.WriteLine($"{pangram} Not contains fox? -> {!pangram.Contains("fox")}");
// Console.WriteLine($"{pangram} Not contains cow? -> {!pangram.Contains("cow")}");
//
// int a = 7;
// int b = 6;
// Console.WriteLine($"a != b -> {a != b}");
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine($"s1 != s2 -> {s1 != s2}");
//
// bool flag = true;
// int value = 0;
// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// // int employeeLevel = 200;
// // int employeeLevel = 201;
// int employeeLevel = 100;
// string employeeName = "John Smith";
//
// string title = "";
//
// switch (employeeLevel)
// {
//     // case 100:
//     //     title = "Junior Associate";
//     //     break;
//     // case 200:
//     //     title = "Senior Associate";
//     //     break;
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
//
// Console.WriteLine($"{employeeName}, {title}");


// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine("-------------");
//
// for (int i = 10; i >= 10; i--)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine("-------------");
//
// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine("-------------");
//
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }
//
// Console.WriteLine("-------------");
//
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);
// while (current >= 3) {
//   System.Console.WriteLine(current);
//   current = random.Next(1, 11);
// }
//
// Console.WriteLine($"Last number: {current}");
// do
// {
//     current = random.Next(1, 11);
//
//     if (current >= 8) continue;
//
//     Console.WriteLine(current);
// } while (current != 7);
//
// Console.WriteLine("Signed integral types:");
//
// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// An unsigned type uses its bytes to represent only positive numbers.
// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");
//
// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
