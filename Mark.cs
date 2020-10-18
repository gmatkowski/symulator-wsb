using System;
using System.Collections.Generic;
using System.Text;

namespace Symulator
{
    class Mark
    {
       private string name;
        public Mark(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
