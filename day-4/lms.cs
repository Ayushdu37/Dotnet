class Library
{
    private Dictionary<int, string> library = new Dictionary<int, string>();

    public string this[int id]
    {
        get{return library.ContainsKey(id) ? library[id] : "Books Not Found";} 
        set{library[id] = value;}
    }

    public string this[string title]
    {
        get
        {
            return library.FirstOrDefault(e => e.Value == title).Value;  // collection.FirstOrDefault(element => condition);
        }
    }
}