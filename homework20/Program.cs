﻿// ТЕКСТ ЗАДАНИЯ
// Написать консольную программу, которая не блокируя основной поток опрашивает сайты
// "http://yandex.ru",
// "http://google.ru",
// "http://vk.com",
// "http://msdn.com",
// c помощью WebClient.DownloadStringTaskAsync и возвращает на экран самый быстропришедший ответ.
// Остальные запросы нужно отменять через CancelationToken. Используя Task и async/await

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace homework20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект Cancelation Token
            CancellationTokenSource _cts = new CancellationTokenSource();

            

            string[] _url = new string[]
            {
                "http://yandex.ru",
                "http://google.ru",
                "http://vk.com",
                "http://msdn.com"
            };

            // string LoadAllData()
            // {
            //     StringBuilder sb = new StringBuilder();
            //     var time = Stopwatch.StartNew();
            //
            //     // sync var 1
            //     foreach (var url in _url)
            //     {
            //         var result = LoadData(url);
            //         sb.AppendLine($"{url}: {result}");
            //     }
            //
            //     time.Stop();
            //     sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds}ms");
            //     return sb.ToString();
            // }


            async Task<string> LoadAllDataByTasks()
            {
                StringBuilder sb = new StringBuilder();
                var time = Stopwatch.StartNew();
            
                foreach (var url in _url)
                {
                    if (_cts.IsCancellationRequested)
                    {
                        sb.AppendLine("Была запрошена отмена операции.");
                        break;
                    }
            
                    var result = await LoadDataAsync(url);
                    sb.AppendLine($"{url}: {result}");
                }
            
                time.Stop();
            
                sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds} ms");
                return sb.ToString();
            }


            // Метод загрузки данных по URL
            // string LoadData(string url)
            // {
            //     var time = Stopwatch.StartNew();
            //     var webClient = new WebClient();
            //     try
            //     {
            //         var result = webClient.DownloadString(url);
            //         time.Stop();
            //         return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds} ms";
            //     }
            //     catch (WebException e)
            //     {
            //         return $"Error load {url}. {e.Message}";
            //     }
            // }

            async Task<string> LoadDataAsync(string url)
            {
                var time = Stopwatch.StartNew();
                var webClient = new WebClient();
                try
                {
                    var result = await webClient.DownloadStringTaskAsync(url);
                    time.Stop();
                    return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds} ms";
                }
                catch (WebException e)
                {
                    return $"Error load {url}. {e.Message}";
                }
            }

            var a = LoadAllDataByTasks();
            Console.WriteLine(String.Join(",", a));
            Console.ReadKey();
        }
    }
}