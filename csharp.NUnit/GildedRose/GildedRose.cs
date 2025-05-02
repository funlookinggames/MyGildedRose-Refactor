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
                if (I.Quality > 0)
                {
                    if (I.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        I.Quality = I.Quality - 1;
                    }
                }
            }
            else
            {
                if (I.Quality < 50)
                {
                    I.Quality = I.Quality + 1;

                    if (I.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (I.SellIn < 11)
                        {
                            if (I.Quality < 50)
                            {
                                I.Quality = I.Quality + 1;
                            }
                        }

                        if (I.SellIn < 6)
                        {
                            if (I.Quality < 50)
                            {
                                I.Quality = I.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (I.Name != "Sulfuras, Hand of Ragnaros")
            {
                I.SellIn = I.SellIn - 1;
            }

            if (I.SellIn < 0)
            {
                if (I.Name != "Aged Brie")
                {
                    if (I.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (I.Quality > 0)
                        {
                            if (I.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                I.Quality = I.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        I.Quality = I.Quality - I.Quality;
                    }
                }
                else
                {
                    if (I.Quality < 50)
                    {
                        I.Quality = I.Quality + 1;
                    }
                }
            }
        }
    }
}