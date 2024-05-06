using System.Drawing;

namespace Po1640_SVGAnimace.Models
{
    public abstract class Obrazec
    {
        public Obrazec(TypObrazce typObrazce, Color barva, int pozX, int pozY)
        { 
            TypObrazce = typObrazce;
            Barva = barva;
            PozX = pozX;
            PozY = pozY;
        }
        public TypObrazce TypObrazce { get; set; }
        public int PozX { get; set; }
        public int PozY { get; set;}
        public Color Barva { get; set; }

        public void PosunObjekt(int krok, int svgWidth, int svgHeight, int maxRozmer)
        {
            PozX += krok;
            PozY += krok;

            if (PozX > svgWidth + maxRozmer)
                PozX = -maxRozmer;
            if (PozY > svgHeight + maxRozmer)
                PozY = -maxRozmer;
        }
    }
}
