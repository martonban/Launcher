using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagAtlas.Utils {
    internal class Vector3i {
        int x;
        int y; 
        int z;

        public Vector3i() { 
        
        }

        public Vector3i(int x, int y, int z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3i(int value) { 
            this.x = value;
            this.y = value;
            this.z = value;
        }
    }
}
