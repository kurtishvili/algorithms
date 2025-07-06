// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Algorithms;
using Algoritihms_DataStruct_Lib;

var ints = In.ReadInts("1kints.txt").ToArray();

var watch = new Stopwatch();
watch.Start();

var triplets = ThreeSum.Count(ints);

watch.Stop();

Console.WriteLine($"the number of triplets {triplets}");
Console.WriteLine($"time taken {watch.Elapsed:g}");

Console.Read();