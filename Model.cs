using System;
using System.Collections.Generic;
using System.Text;

namespace Symulator
{
    class Model
    {
        private string name;
        public Model(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
