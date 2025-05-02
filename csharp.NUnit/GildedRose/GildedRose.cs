using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item I in Items)
        {

            if (I.Name != "Aged Brie" && I.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (I.Quality > 0 && I.Name != "Sulfuras, Hand of Ragnaros") I.Quality--;
            }
            else
            {
                if (I.Quality < 50)
                {
                    I.Quality++;

                    if (I.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (I.SellIn <= 10 && I.Quality < 50) I.Quality++;

                        if (I.SellIn <= 5 && I.Quality < 50) I.Quality++;
                    }
                }
            }

            if (I.Name != "Sulfuras, Hand of Ragnaros") I.SellIn--;

            if (I.SellIn < 0)
            {
                if (I.Name != "Aged Brie")
                {
                    if (I.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (I.Quality > 0 && I.Name != "Sulfuras, Hand of Ragnaros") I.Quality--;
                    }
                    else
                    {
                        I.Quality = 0;
                    }
                }
                else
                {
                    if (I.Quality < 50) I.Quality++;
                }
            }
        }
    }
}