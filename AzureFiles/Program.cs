// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using System.Text;



//Encoding.UTF8.GetBytes("AsWB5z/WMp52hPed5hg7TUlKNG7UXBnXaIZfO3luNT9EZ2YbipT26w2FO3QxrFxhd/1ZEh/yfnEN+AStLFb/AQ==");
HMACSHA256 hasher = new HMACSHA256(Convert.FromBase64String("AsWB5z/WMp52hPed5hg7TUlKNG7UXBnXaIZfO3luNT9EZ2YbipT26w2FO3QxrFxhd/1ZEh/yfnEN+AStLFb/AQ=="));
Console.WriteLine(Convert.ToBase64String(hasher.Key));
