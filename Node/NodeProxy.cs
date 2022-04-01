namespace Node
{
    internal class NodeProxy : INode
    {
        public INode Parent { get; set; }
        public string Name { get; set; }
        INode Element{ get; set; }
}
}
