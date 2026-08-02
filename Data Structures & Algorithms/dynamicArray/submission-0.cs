

public class DynamicArray
{
    int[] Data;
    int Capacity;
    int Count;
    public DynamicArray(int capacity)
    {
        if(capacity > 0) Data = new int[capacity];
        Count = 0;
        Capacity = capacity;

    }

    public int Get(int i)
    {
        if (i < Capacity)
            return Data[i];
        return 0;
    }

    public void Set(int i, int n)
    {
        if (i < Capacity)
            Data[i] = n;
    }

    public void PushBack(int n)
    {
        if (Capacity == Count)
        {
            Resize();
        }
        
        Data[Count] = n;
        Count++;
        
    }

    public int PopBack()
    {
        int popped = Data[Count - 1];

        Data[Count - 1] = 0;
        --Count;
        
        return popped;
    }

    private void Resize()
    {
        int[] newArray = new int[Capacity * 2];
        for(int i = 0; i < Data.Length; ++i)
            newArray[i] = Data[i];
        Data = newArray;
        Capacity *= 2;
    }

    public int GetSize()
    {
        return Count;
    }

    public int GetCapacity()
    {
        return Capacity;
    }
}
