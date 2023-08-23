﻿using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Context;

namespace EnvanterUygulaması.Models
{
    public class Bulutlar
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string AnaDevreNo { get; set; }
        public Devreler devreler { get; set; }
    }
}
