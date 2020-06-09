﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Art
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public Art(string path)
        {
            Path = path;
        }

        public Art()
        {
        }
    }
}