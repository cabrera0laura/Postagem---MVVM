using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagem.ViewModels
{
    internal class PostViewModel : ObservableObject
    {
        [ObservableObject]
        private string titulo;

        [ObservableObject]
        private string corpo;


    }
}
