namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>();

            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                Tree tree = new Tree(random.Next(0, 30), random.Next(0, 30));
                trees.Add(tree);
            }

            Garden garden = new Garden(trees);
            Console.WriteLine("Trees:");
            foreach (Tree tree in trees)
            {
                Console.WriteLine("(" + tree.X + "," + tree.Y + ");");
            }

            Console.WriteLine("Fences:");
            foreach (Fence fence in garden.Fences)
            {
                Console.WriteLine("Start(" + fence.Start.X + ":" + fence.Start.Y + "); End(" + fence.End.X + ":" + fence.End.Y + ");");
            }



        }
    }
}