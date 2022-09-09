using SlabSolver.Enums;

namespace SlabSolver.Domain
{
    public abstract class Slab
    {
        public string Signature { get; private set; }
        public int Thickness { get; private set; }
        public Concrete Concrete { get; private set; }
        public FireResistance FireResistance { get; private set; }
        public float Mcr { get; private set; }                  // Cracking bending moment                              kNm
        public float Mcr_topedge { get; private set; }          // Cracking bending moment (top edge)                   kNm
        public float Mcrw02 { get; private set; }               // Cracking bending moment w02                          kNm
        public float Mdec { get; private set; }                 // Decompression bending moment                         kNm
        public float Mrd { get; private set; }                  // Design value of the bending resistance               kNm
        public float Mrd_topedge { get; private set; }          // Design value of the bending resistance (top edge)    kNm
        public float Vrd { get; private set; }                  // Design value of the shear resistance                 kN
        public float Q { get; private set; }                    // Own weight                                           kN/m2
        public Slab(
            string signature,
            int thickness,
            Concrete concrete,
            FireResistance fireResistance,
            float mcr,
            float mcr_topedge,
            float mcrw02,
            float mdec,
            float mrd,
            float mrd_topedge,
            float vrd,
            float q
            )
        {
            Signature = signature;
            Thickness = thickness;
            Concrete = concrete;
            FireResistance = fireResistance;
            Mcr = mcr;
            Mcrw02 = mcrw02;
            Mdec = mdec;
            Mrd = mrd;
            Vrd = vrd;
            Q = q;
        }

        public override string ToString()
        {
            return Signature;
        }
    }
}
