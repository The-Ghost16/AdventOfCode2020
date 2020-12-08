using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Models;
using AdventOfCode2020.Models.Day7;

namespace AdventOfCode2020
{
    public class Day7 : Day<Day7Input>
    {
        private List<Bag> assignment1Result = new List<Bag>();

        public Day7() : base(7)
        { 
        }

        protected override void Assignment1()
        {
            var parentBags = data.Bags.Where(b => b.ChildBags.ContainsKey("shiny gold")).ToList();
            assignment1Result.AddRange(parentBags);

            GetBags(parentBags);

            var uniqueBags = assignment1Result.Distinct();

            Console.WriteLine($"There are {uniqueBags.Count()} bags that can contain a shiny gold bag.");
        }

        protected override void Assignment2()
        {
            var shinyGoldBag = data.Bags.Single(b => b.Name == "shiny gold");
            var numberOfChildBags = CountBags(shinyGoldBag);

            Console.WriteLine($"There are {numberOfChildBags} child bags required for the shiny gold bag.");
        }

        protected override Day7Input ConvertInput(IList<string> input)
        {
            var result = new Day7Input();

            foreach(var line in input)
            {
                var bag = ParseLine(line);

                result.Bags.Add(bag);
            }

            return result;
        }

        private Bag ParseLine(string line)
        {
            var bag = new Bag();

            var x = " bags contain";
            var nameEnd = line.IndexOf(x);
            var name = line.Substring(0, nameEnd);

            var start = name.Length + x.Length;
            var subBagInfo = line.Substring(start).Trim();

            var bags = subBagInfo.Split(", ");
            foreach(var tempBag in bags)
            {
                var split = tempBag.Trim().Split(' ');
                if(int.TryParse(split[0], out var amount))
                {
                    var colorInfo = tempBag.Substring(split[0].Length).Trim();
                    var colorEnd = colorInfo.IndexOf(" bag");
                    var color = colorInfo.Substring(0, colorEnd);
                    bag.ChildBags.Add(color, amount);
                }
            }

            bag.Name = name;

            return bag;
        }

        private void GetBags(IList<Bag> bags)
        {
            foreach(var bag in bags)
            {
                var extraBags = data.Bags.Where(b => b.ChildBags.ContainsKey(bag.Name)).ToList();
                assignment1Result.AddRange(extraBags);

                GetBags(extraBags);
            }
        }

        private int CountBags(Bag bag)
        {
            var count = 0;
            foreach(var childBagKV in bag.ChildBags)
            {
                var result = 1;
                var childBag = data.Bags.Single(b => b.Name == childBagKV.Key);
                if(childBag.ChildBags.Any()) 
                {
                    result += CountBags(childBag);
                } 

                count += childBagKV.Value * result;
            }

            return count;
        }
    }
}