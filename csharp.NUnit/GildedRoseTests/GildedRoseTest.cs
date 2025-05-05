using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Testes()
    {
        // Escrevendo meus próprios testes
        var items = new List<Item> 
        { 
            new Item { Name = "Normal Item", SellIn = 10, Quality = 20, Conjured = false},
            new Item { Name = "Normal Conjured Item", SellIn = 5, Quality = 20, Conjured = true},
            new Item { Name = "Aged Brie", SellIn = 7, Quality = 0, Conjured = false},
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20, Conjured = false},
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, Conjured = false },
            new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, Conjured = true}
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Name, Is.EqualTo("Normal Item"));
        Assert.That(items[1].Name, Is.EqualTo("Normal Conjured Item"));
        Assert.That(items[2].Name, Is.EqualTo("Aged Brie"));
        Assert.That(items[3].Name, Is.EqualTo("Backstage passes to a TAFKAL80ETC concert"));
        Assert.That(items[4].Name, Is.EqualTo("Sulfuras, Hand of Ragnaros"));
        Assert.That(items[5].Name, Is.EqualTo("Conjured Mana Cake"));

        foreach (Item I in items) {
            Assert.That(I.SellIn, Is.GreaterThanOrEqualTo(0));
            if (!(I.Name.Contains("Sulfuras")))
            {
                Assert.That(I.Quality, Is.LessThanOrEqualTo(50));
            } else
            {
                Assert.That(I.SellIn, Is.EqualTo(0));
                Assert.That(I.SellIn, Is.EqualTo(80));
            }
        }
        //var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0, Conjured = false } };
        //var app = new GildedRose(items);
        //app.UpdateQuality();
        //Assert.That(items[0].Name, Is.EqualTo("foo"));
    }
}