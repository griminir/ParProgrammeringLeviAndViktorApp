using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon {
    internal class Trainer {
        public string Name { get; set; }
        public List<Pokemon> _Pokemon { get; set; }

        public Trainer(string name, Pokemon starter)
        {
            Name = name;
            _Pokemon = new List<Pokemon>()
            {
                starter
            };
        }
    }
}
