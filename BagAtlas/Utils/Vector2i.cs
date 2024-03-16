using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagAtlas.Utils {
    internal class Vector2i {
        int x;
        int y;

        public Vector2i() {
        
        }

        public Vector2i(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public Vector2i(int value) { 
            this.x = value;
            this.y = value;
        }
    }
}
