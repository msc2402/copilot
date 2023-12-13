namespace Copilot.Business
{
    public interface ICreateProductSpec
    {
        string Sku { get; }

        string Name { get; }

        string Description { get; }
    }
}
