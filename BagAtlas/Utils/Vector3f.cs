using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagAtlas.Utils {
    internal class Vector3f {
        public float x;
        public float y;
        public float z;

        // Constractors
        public Vector3f() { }

        public Vector3f(float value) { 
            this.x = value;
            this.y = value;
            this.z = value;
        }

        public Vector3f(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
