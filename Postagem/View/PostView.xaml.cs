//importar para que o view converce com o viewModel
using Postagem.ViewModels; 

namespace Postagem.View;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		//relacionamento com a view e viewModel
        BindingContext = new PostViewModel();

    }
}