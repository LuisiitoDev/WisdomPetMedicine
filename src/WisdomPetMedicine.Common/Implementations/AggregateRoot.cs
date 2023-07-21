using WisdomPetMedicine.Common.Interfaces;

namespace WisdomPetMedicine.Common.Implementations;

public abstract class AggregateRoot
{
    private readonly List<IDomainEvent> changes;
    public int Version { get; private set; }

    public AggregateRoot()
    {
        changes = new();
        Version = -1;
    }

    public IEnumerable<IDomainEvent> GetChanges() => changes;
    public void ClearChanges() => changes.Clear();
    protected void ApplyDomainEvent(IDomainEvent domainEvent)
    {
        ChangeStateByUsingDomainEvent(domainEvent);
        VAlidateState();
        changes.Add(domainEvent);
    }

    public void Load(IEnumerable<IDomainEvent> history)
    {
        foreach (IDomainEvent domainEvent in history)
        {
            ApplyDomainEvent(domainEvent);
            Version++;
        }
        ClearChanges();
    }
    protected abstract void ChangeStateByUsingDomainEvent(IDomainEvent domainEvent);
    protected abstract void VAlidateState();
}
