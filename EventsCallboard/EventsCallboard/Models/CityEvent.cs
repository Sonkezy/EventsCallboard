﻿using System;
using System.IO;
namespace EventsCallboard.Models
{
    public class CityEvent
    {
        public CityEvent(string title, string desc, string image, string date, string[] cats, string grand_cat, string price) {
            Header = title;
            Description = desc;
            Date = date;
            Categories = cats;
            GrandCategoty = grand_cat;
            Price = price;

            byte[] bytes = Convert.FromBase64String(image);
            Stream stream = new MemoryStream(bytes);
            Image = new Avalonia.Media.Imaging.Bitmap(stream);
        }
        public string Header { get; }
        public string Description { get; }
        public Avalonia.Media.Imaging.Bitmap Image { get; }
        public string Date { get; }
        public string Price { get; }

        private readonly string[] Categories;
        private readonly string GrandCategoty;
        public bool CheckCat(string scat)
        {
            foreach (var cat in Categories)
                if (cat == scat) return true;
            return GrandCategoty == scat;
        }
    }
}
