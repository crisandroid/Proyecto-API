namespace WebApplication1.Models
{
    public class Node
    {
        public TarjetaCredito Data { get; set; }
        public Node Next { get; set; }

        public Node(TarjetaCredito data)
        {
            Data = data;
            Next = null;
        }
    }
}
