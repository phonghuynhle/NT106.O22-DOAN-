﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Player
    {
        private string name;
        private Image mark;

        public string Name { get => name; set => name = value; }



        public Image Mark { get => mark; set => mark = value; }



        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;

        }
        public Player(string name) { this.Name = name; }
    }
}
