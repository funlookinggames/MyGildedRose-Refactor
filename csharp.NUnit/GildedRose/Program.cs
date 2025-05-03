using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20, Conjured = false},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0, Conjured = false},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7, Conjured = false},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, Conjured = true},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80, Conjured = true},
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20,
                Conjured = false
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49,
                Conjured = false
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49,
                Conjured = false
            },
            // this conjured item does not work properly yet
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, Conjured = true}
        };

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality, conjured?");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality + ", " + items[j].Conjured);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}