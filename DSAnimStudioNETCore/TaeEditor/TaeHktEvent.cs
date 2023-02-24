using SoulsFormats;
using SoulsAssetPipeline.Animation;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DSAnimStudio.TaeEditor
{
    public class TaeHktEvent : Dictionary<string, Dictionary<long, List<TaeHktEvent.SmallEvent>>>
    {
        //public Dictionary<string, Dictionary<long, List<TAE.Event>>> TAE { get; set; }
        public TaeHktEvent()
        {

        }
        
        public class SmallEvent
        {
            public SmallEvent(float startTime, float endTime, int type, int unk04, byte[] parameters, bool isBigEndianParameters)
            {
                this.startTime = startTime;
                this.endTime = endTime;
                this.type = type;
                this.unk04 = unk04;
                this.parameters = parameters;
                this.isBigEndianParameters = isBigEndianParameters;
            }

            public float startTime { get; set; }
            public float endTime { get; set; }
            public int type { get; set; }
            public int unk04 { get; set; }
            public byte[] parameters { get; set; }
            public bool isBigEndianParameters { get; set; }
        }
            
    }
}
