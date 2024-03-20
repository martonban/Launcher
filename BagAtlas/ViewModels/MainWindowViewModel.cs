using BagAtlas.Models;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Windows.Media.Media3D;
using BagAtlas.Utils;


namespace BagAtlas.ViewModels {
    internal class MainWindowViewModel {

        private BindableCollection<TestModel> _tests = new BindableCollection<TestModel>();

        public MainWindowViewModel() {
            _tests.Add(new TestModel { Name = "One", Id = 1, Pos = new Vector3f{ x = 1.0f, y = 1.0f, z = 1.0f } });
            _tests.Add(new TestModel { Name = "Two", Id = 2, Pos = new Vector3f { x = 1.0f, y = 1.0f, z = 1.0f } });
            _tests.Add(new TestModel { Name = "Three", Id = 3, Pos = new Vector3f { x = 1.76876f, y = 1.0f, z = 1.0f } }); 
        }

        public void Serialization() {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(_tests);
        }

        public void Deserialization() {
            return;
        }
    }
}
