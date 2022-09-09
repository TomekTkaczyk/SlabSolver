namespace SlabSolver.Model.Smart
{
    public class LoadCapacity
    {
        public int Span { get; private set; }
        public float Pd { get; private set; }
        public float Pk2a { get; private set; }
        public float Pk2b { get; private set; }
        public float Pka2b { get; private set; }

        public LoadCapacity(int span, float pd, float pk2a, float pk2b, float pka2b)
        {
            Span = span;
            Pd = pd;
            Pk2a = pk2a;
            Pk2b = pk2b;
            Pka2b = pka2b;
        }
    }
}
