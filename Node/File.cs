namespace Node
{
    internal class File : Node
    {
        public override INode Parent { get; set; }
        public override string Name { get; set; }
        public byte[] Content { get; set; }
    }
}
