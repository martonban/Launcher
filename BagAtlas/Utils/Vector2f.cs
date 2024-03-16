using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagAtlas.Utils {
    internal class Vector2f {
        public float x;
        public float y;

        public Vector2f() {
        
        }

        public Vector2f(float value) {
            this.x = value;
            this.y = value;
        }

        public Vector2f(float x, float y) {
            this.x = x;
            this.y = y;
        }
    }
}
