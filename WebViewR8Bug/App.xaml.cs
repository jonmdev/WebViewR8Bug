namespace WebViewR8Bug {
    public partial class App : Application {
        public App() {

            ContentPage mainPage = new();
            this.MainPage = mainPage;

            AbsoluteLayout absRoot = new();
            mainPage.Content = absRoot;

            WebView webView = new();
            webView.WidthRequest = 300; 
            webView.HeightRequest = 300;
            webView.Source = "https://google.com";
            
            absRoot.Add(webView);
        }
    }
}