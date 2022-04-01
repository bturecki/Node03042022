namespace Node
{
    internal class Catalog : Node
    {
        public override INode Parent { get; set; }
        public override string Name { get; set; }
        public List<INode> List { get; set; }
    }
}
