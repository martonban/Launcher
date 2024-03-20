using BagAtlas.Models;
using System.Text.Json;
using Caliburn.Micro;
using BagAtlas.Utils;
using System.Net;
using System.IO;
using System;


namespace BagAtlas.ViewModels {
    internal class MainWindowViewModel : Conductor<object>{

        private BindableCollection<TestModel> _tests = new BindableCollection<TestModel>();

        public MainWindowViewModel() {
            _tests.Add(new TestModel { Name = "One", Id = 1, Pos = new Vector3f{ x = 1.0f, y = 1.0f, z = 1.0f } });
            _tests.Add(new TestModel { Name = "Two", Id = 2, Pos = new Vector3f { x = 1.0f, y = 1.0f, z = 1.0f } });
            _tests.Add(new TestModel { Name = "Three", Id = 3, Pos = new Vector3f { x = 1.76876f, y = 1.0f, z = 1.0f } }); 
        }

        public void Serialization() {
            // Pretty Print 
            var option = new JsonSerializerOptions();
            option.WriteIndented = true; 

            // Serialization 
            string jsonString = JsonSerializer.Serialize(_tests, option);

            // TO - DO Migrate to file writer class
            File.WriteAllText("serialization.json", jsonString);
           
        }

        public void Deserialization() {
            var serializationJson = File.ReadAllText("serialization.json");
            _tests = JsonSerializer.Deserialize<BindableCollection<TestModel>>(serializationJson);
            Console.WriteLine(_tests[2].Pos.x);
        }
    }
}
