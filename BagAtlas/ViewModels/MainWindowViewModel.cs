using BagAtlas.Models;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;


namespace BagAtlas.ViewModels {
    internal class MainWindowViewModel {

        private BindableCollection<TestModel> _tests = new BindableCollection<TestModel>();

        public MainWindowViewModel() {
            _tests.Add(new TestModel { Name = "One", Id = 1, Pos = new Utils.Vector3f(1.0f, 1.0f, 1.0f) });
            _tests.Add(new TestModel { Name = "Two", Id = 2, Pos = new Utils.Vector3f(2.0f, 2.0f, 2.0f) });
            _tests.Add(new TestModel { Name = "Three", Id = 3, Pos = new Utils.Vector3f(3.0f, 3.0f, 3.0f) });

        }

        public void Serialization() {
            string jsonString = JsonSerializer.Serialize(_tests);    
        }
    }
}
