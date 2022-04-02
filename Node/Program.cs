using Node;

Catalog music = new Catalog();
Node.File jackson = new Node.File();

INode proxy = new NodeProxy();
proxy.Name = "good";

music.List = new List<INode>() { jackson };
Console.WriteLine($"File added to catalog");