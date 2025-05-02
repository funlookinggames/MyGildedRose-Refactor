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
            bool isAgedBrie = I.Name == "Aged Brie";
            bool isBackStage = I.Name == "Backstage passes to a TAFKAL80ETC concert";
            bool isSulfuras = I.Name == "Sulfuras, Hand of Ragnaros";


            if (!isAgedBrie && !isBackStage)
            {
                if (I.Quality > 0 && !isSulfuras) I.Quality--;
            }
            else
            {
                if (I.Quality < 50)
                {
                    I.Quality++;

                    if (isBackStage)
                    {
                        if (I.SellIn <= 10 && I.Quality < 50) I.Quality++;

                        if (I.SellIn <= 5 && I.Quality < 50) I.Quality++;
                    }
                }
            }

            if (!isSulfuras) I.SellIn--;

            if (I.SellIn < 0)
            {
                if (!isAgedBrie)
                {
                    if (!isBackStage)
                    {
                        if (I.Quality > 0 && !isSulfuras) I.Quality--;
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