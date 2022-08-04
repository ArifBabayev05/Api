﻿using System;
namespace DAL.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}

