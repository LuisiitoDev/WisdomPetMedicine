namespace WisdomPetMedicine.Common.Implementations;

public class DomainEvent<T>
{
    private List<Action<T>> Actions { get; } = new();

    public void Register(Action<T> callback)
    {
        if (Actions.Any(a => a.Method == callback.Method))
            return;

        Actions.Add(callback);
    }

    public void Publish(T args)
    {
        foreach (var action in Actions) 
            action.Invoke(args);
    }
}
