namespace _31ThePropertiesofArrows
{
    internal partial class Program
    {
        public class Arrow
        {
            public ArrowHead _arrowHead { get; }
            public Fletching _fletching { get; }
            public float _arrowLength {  get; }

            public Arrow(ArrowHead arrowHead, Fletching fletching, float arrowLength)
            {
                arrowHead = _arrowHead;
                fletching = _fletching;
                arrowLength = _arrowLength;
            }

            public float GetCost()
            {
                float arrowHeadCost;
                float fletchingCost;
                float arrowLengthCost;

                arrowHeadCost = _arrowHead switch
                {
                    ArrowHead.steel => 10,
                    ArrowHead.wood => 3,
                    ArrowHead.obsidian => 5,
                };

                fletchingCost = _fletching switch
                {
                    Fletching.plastic => 10,
                    Fletching.turkeyfeathers => 5,
                    Fletching.goosefeathers => 3
                };

                arrowLengthCost = _arrowLength * (float).05;

                return arrowHeadCost + fletchingCost + arrowLengthCost;
            }
        }
    }
}
