// using System;
// using System.Threading;

// namespace C_Learn
// {
//     class Program
//     {
//         /// <summary>
//         /// 将dateTime格式转换为Unix时间戳
//         /// </summary>
//         /// <param name="dateTime"></param>
//         /// <returns></returns>
//         public static int DateTimeToUnixTime(DateTime dateTime)
//         {
//             return (int)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
//         }

//         /// <summary>
//         /// 将Unix时间戳转换为dateTime格式
//         /// </summary>
//         /// <param name="time"></param>
//         /// <returns></returns>
//         public static DateTime UnixTimeToDateTime(int time)
//         {
//             if (time < 0)
//                 throw new ArgumentOutOfRangeException("time is out of range");

//             return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(time);
//         }

//         public static string UnixTimeToDateTime(int time, string timestr)
//         {
//             if (time < 0)
//                 throw new ArgumentOutOfRangeException("time is out of range");

//             return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(time).ToString(timestr);
//         }

//         public static bool IsSameDay(int timeLeft, int timeRight)
//         {
//             DateTime left = UnixTimeToDateTime(timeLeft);
//             DateTime right = UnixTimeToDateTime(timeRight);
//             return left.Date == right.Date;
//         }
//         static void Main(string[] args)
//         {
//             var date1 = DateTime.Now;
//             var unix1 = DateTimeToUnixTime(date1);
//             Thread.Sleep(500);
//             var date2 = DateTime.Now;
//             var unix2 = DateTimeToUnixTime(date2);
//             var isSameDay1 = date1 == date2;
//             //DateTime.Date不带时间，00:00:00
//             //所以可以用来比较是不是同一天
//             var isSameDay2 = date1.Date == date2.Date;
//             var dayStr1 = date1.Date.ToShortDateString();
//             var dayStr2 = date1.Date.ToLongDateString();
//             var dayStr3 = date1.Date.ToShortTimeString();
//             var dayStr4 = date1.Date.ToLongTimeString();
//             var dayInt1 = date1.Date.Second;
//             var dayInt2 = date2.Date.Second;
//             Console.WriteLine("Hello");

//             //https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-5.0
//             DateTime departure = new DateTime(2010, 6, 12, 18, 32, 0);
//             DateTime arrival = new DateTime(2010, 6, 12, 22, 47, 0);
//             TimeSpan travelTime = arrival - departure;
//             //https://docs.microsoft.com/zh-cn/dotnet/api/system.timespan.tostring?view=net-5.0
//             Console.WriteLine(travelTime.ToString("hh\\:mm\\:ss"));

//             // var dateSpan1 = new TimeSpan(0, 0, 5);
//             // 
//             // while (true)
//             // {
//             //     var dateNow = DateTime.Now;
//             //     var tmp = dateNow.Date.AddHours(19);
//             //     var dateFresh = tmp;
//             //     var dateSpan = dateFresh - dateNow;
//             //     Console.WriteLine(dateSpan.ToString("hh\\:mm\\:ss"));
//             //     Thread.Sleep(1000);
//             // }

//             DateTime d1 = new DateTime(2010, 6, 13, 18, 0, 0);
//             DateTime d2 = new DateTime(2010, 6, 12, 22, 0, 0);
//             TimeSpan ds = d1 - d2;
//             Console.WriteLine(d1.ToShortDateString());
//             Console.WriteLine(d1.ToShortTimeString());
//             return;
//         }
//     }
// }