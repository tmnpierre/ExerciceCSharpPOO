using System;
using System.Collections.Generic;

public class Pile<T>
{
    private readonly List<T> _elements = new List<T>();

    public int Count => _elements.Count;

    public void Empiler(T element)
    {
        _elements.Add(element);
    }

    public T Depiler()
    {
        if (_elements.Count == 0)
            throw new InvalidOperationException("La pile est vide.");

        var item = _elements[^1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public T Recuperer(int index)
    {
        if (index < 0 || index >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index est hors des limites de la pile.");

        return _elements[index];
    }
}
