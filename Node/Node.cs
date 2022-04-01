namespace Node
{
    internal abstract class Node : INode
    {
        public abstract INode Parent { get; set; }
        public abstract string Name { get; set; }

    }
}
