namespace Array;

public class Array
{
    // Object
    // Type : Array
    private Object[] _InnerArray;
    private int _Index = 0;
    public int Count => _Index++;
    public Array()
    {
        _InnerArray = new Object[4];
    }
    public void Add(Object item)
    {
        if(_Index > _InnerArray.Length)
        {
            Console.WriteLine("Limit exceeded! From now on you will start to override the current content");
            _Index = 0;
        }
        else
        {
            _InnerArray[_Index] = item;
            _Index++;
        }
    }
    public void Delete(int index)
    {
        if(_Index > _InnerArray.Length)
        {
            Console.WriteLine("Please enter a valid value!");
        }
        else
        {
        _InnerArray[index] = "";
        }
    }
    public void Update(int index, Object item)
    {
        if (index > _InnerArray.Length || item == null)
        {
            Console.WriteLine("Please check your values!");
        }
        else
        {
            _InnerArray[index] = item;
        }
    }
}