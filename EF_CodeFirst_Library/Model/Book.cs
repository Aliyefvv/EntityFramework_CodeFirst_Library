﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst_Library.Model
{
    public class Book
    {
        public int Id { get; set; }  
        public string Title { get; set; }
        public Publisher Publisher { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
    }
}
