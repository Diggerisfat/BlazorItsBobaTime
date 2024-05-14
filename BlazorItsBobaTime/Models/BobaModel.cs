namespace BlazorItsBobaTime.Models;
using System;
using System.Collections.Generic;

    public class BobaModel
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public int Boba { get; set; }
        public int Ice { get; set; }
        public int Sugar { get; set; }
        public int Temperature { get; set; }

        public int Toppings { get; set; }

        public override string ToString()
        {
            string toppingsList = string.Join(", ", Toppings);
            return $"ID: {Id}\nSize: {Size}\nType: {Type}\nBoba: {Boba}\nIce: {Ice}\nSugar: {Sugar}\nTemperature: {Temperature}\nToppings: {toppingsList}";
        }
    }
