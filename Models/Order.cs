﻿namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Table { get; set; }
        public Item? Item {  get; set; }
    }
}