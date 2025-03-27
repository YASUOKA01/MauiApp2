namespace MauiApp2;

public partial class ListaProdutoPage : ContentPage
{
    public ListaProdutoPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstProduto.ItemsSource = null;  
        lstProduto.ItemsSource = Produto.Lista;  
    }

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProdutoPage() { BindingContext = ((ViewCell)sender).BindingContext });
    }
}
