//using ServiceTest.Models;
//using ServiceTest.Services;

using ServiceTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ServiceTest.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private TriviaService service;
        private string text;
        public ICommand GetText { get; protected set; }
        public string Text { get { return text; } set { if (text != value) {  text= value; OnPropertyChange(); } } }

        public MainPageViewModel(TriviaService t)
        {
            service = t;
            GetText = new Command(async () => { Text = await service.CheckConnection(); });
        }

       
    }


       


    }

