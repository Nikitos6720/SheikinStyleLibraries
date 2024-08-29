namespace SSDll.controllers;

public abstract class Controller<T> : IDisposable where T : class
{
    private List<T> _values;

    protected List<T> Values => _values;

    public bool Creates(T obj)
    {
        if (obj is null)
            return false;


        Guid id = (Guid) typeof(T).GetProperty("Id")!.GetValue(obj)!;
        if (FindsById(id) is null)
            return false;

        return true;
    }

    public bool Removes(T obj)
    {
        if (obj is null)    
            return false;

        return true;
    }

    public bool RemovesById(Guid id)
    {
        if (id == Guid.Empty)
            return false;

        
        return true;
    }

    public T? FindsById(Guid id)
    {
        if (id == Guid.Empty) 
            return null;

        
        return null;
    }

    public T? FindsByParam(Predicate<T> x)
    {
        return _values.Find(x);
    }

    public void Dispose()
    {
        SaveChanges();
    }

    private bool SaveChanges()
    {
        return false;
    }
}