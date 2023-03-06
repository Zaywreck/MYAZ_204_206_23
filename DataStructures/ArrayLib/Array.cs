namespace Array;

public class Array
{
    // Object
    // Type : Array
    private Object[] _InnerArray;
    private int _Index = 0;
    public int Count => _Index;
    public int Capacity => _InnerArray.Length;
    public Array()
    {
        _InnerArray = new Object[4];
    }
    public void Add(Object item)
    {
        if(_Index == _InnerArray.Length)
        {
            DoubleArray(_InnerArray);
        }
       
        _InnerArray[_Index] = item;
        _Index++;
      
    }

    private void DoubleArray(object[] array)
    {
        var newArray = new Object[array.Length * 2];
        System.Array.Copy(array, newArray, array.Length);
        _InnerArray = newArray;
    }
}