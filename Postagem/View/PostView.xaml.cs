
using Postagem.ViewModels;

namespace Postagem.View;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
        BindingContext = new PostViewModel();

    }
}