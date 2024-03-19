using Microsoft.VisualStudio.ApplicationInsights.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagAtlas.Utils {
    public class Vector3f : IJsonSerializable {
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

        public void Serialize(IJsonWriter writer) {
            writer.WriteStartObject();
            writer.WritePropertyName("x");
            writer.WriteValue(X);
            writer.WritePropertyName("y");
            writer.WriteValue(Y);
            writer.WritePropertyName("z");
            writer.WriteValue(Z);
            writer.WriteEndObject();
        }
    }
}
