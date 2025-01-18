using System;

public class CustomList<T>
{
    private T[] _items;
    private int _count;
    private const int DefaultCapacity = 4;

    public CustomList()
    {
        _items = new T[DefaultCapacity];
        _count = 0;
    }

    public int Count => _count;

    public int Capacity => _items.Length;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return _items[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));
            _items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Resize(_items.Length * 2);
        }
        _items[_count++] = item;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        RemoveAt(index);
        return true;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index));

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        _items[_count] = default; // Clear the last element

        if (_count > 0 && _count == _items.Length / 4)
        {
            Resize(_items.Length / 2);
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Equals(_items[i], item))
                return i;
        }

        return -1;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }

    public void Clear()
    {
        for (int i = 0; i < _count; i++)
        {
            _items[i] = default;
        }

        _count = 0;
        Resize(DefaultCapacity);
    }

    private void Resize(int newSize)
    {
        T[] newItems = new T[newSize];
        for (int i = 0; i < _count; i++)
        {
            newItems[i] = _items[i];
        }

        _items = newItems;
    }

    public void PrintAll()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
}
