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
            // MAKE CONJURED ITEMS TAKE DOUBLE DAMAGE IN QUALITY LOL

            // if (!isSulfuras) I.SellIn--;

            if (I.SellIn < 0)
            {
                switch (I.Name)
                {
                    case "Aged Brie":
                        I.Quality = 0;
                        break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        I.Quality = 0;
                        break;

                    case "Sulfuras, Hand of Ragnaros":
                        // do nothing;
                        break;

                    default:
                        if (I.Quality > 1) I.Quality-=2;
                        else I.Quality = 0;
                            break;
                }
            }
        }
    }
}