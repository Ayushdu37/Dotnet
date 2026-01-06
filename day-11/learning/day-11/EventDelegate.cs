class Button
{
    public delegate void ClickHandler();

    public event ClickHandler Clicked;

    public void Click()
    {
        Clicked?.Invoke();
    }
}

public partial class Program
{
    public static void ButtonDemo()
    {
        Button btn = new Button();
        btn.Clicked += () => Console.WriteLine("Button is Clicked");
        btn.Click();
    }
}