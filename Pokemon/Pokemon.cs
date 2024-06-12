using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon {
    internal class Pokemon {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attakpower { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, int hP, int attakpower, int level) {
            Name = name;
            HP = hP;
            Attakpower = attakpower;
            Level = level;
        }
    }
}
