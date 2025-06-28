using CommunityToolkit.Mvvm.ComponentModel;
using Postagem.Models;
using Postagem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Postagem.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        //importar
        List<PostModel> postagens;


        [ObservableProperty]
        private string titulo;

        [ObservableProperty]
        private string corpo;
        // Esses comandos
        //fornecem o comportamento de comando para elementos de interface
        //do usuário, como um Windows Runtime XAML Button
        public ICommand DisplayPostsCommand { get;private set; }

        //Construtor:
        public PostViewModel() 
        {
            DisplayPostsCommand = new Command(DisplayPosts);
        }

        public async void DisplayPosts()
        {
            //sem "S" mas corretamente deveria ser PLURAR
            PostService postservice = new PostService();
            //classe para postagens quem ira buscar os dados e utilizara o postservice
            postagens = await postservice.getPost();
            //postagens = await postservice.getPost();
            Titulo = postagens[0].Titulo;
            Corpo = postagens[0].corpo;
        }
    }
}
