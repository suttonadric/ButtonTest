﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonTest
{
    public partial class AddPageViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoMainPage()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
