using BagAtlas.Models;
using System.Text.Json;
using Caliburn.Micro;
using BagAtlas.Utils;
using System.Net;


namespace BagAtlas.ViewModels {
    internal class MainWindowViewModel {

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
        }

        public void Deserialization() {
            return;
        }
    }
}
