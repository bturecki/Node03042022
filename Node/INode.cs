namespace Node
{
    internal interface INode
    {
        INode Parent { get; set; }
        string Name { get; set; }
    }
}
