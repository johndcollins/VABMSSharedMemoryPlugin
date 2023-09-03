namespace VAF4BMSPlugin
{
    public interface ISimOutput
    {
        string FriendlyName { get; }
        bool HasListeners { get; }
        string Id { get; }
    }
}
