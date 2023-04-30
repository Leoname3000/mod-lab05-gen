using System;

namespace generator
{
    public class PairGenerator : IGenerator
    {
        public PairGenerator()
        {
            pairs = new string[]
            {
                "и не", "и в", "потому что", "я не", "у меня", "может быть", "то что", "что он", "не было", "в том", 
                "у нас", "в этом", "у него", "что в", "не только", "том что", "что я", "и на", "ничего не", "так и", 
                "и с", "он не", "и я", "о том", "и все", "но и", "с ним", "а в", "так как", "что это", 
                "как бы", "все это", "как и", "да и", "вместе с", "не в", "то есть", "и что", "и он", "никогда не", 
                "к нему", "не может", "если бы", "а я", "так что", "он был", "а не", "об этом", "и даже", "что не", 
                "это не", "еще не", "но не", "и как", "не мог", "из них", "не знаю", "на него", "в нем", "а потом", 
                "что же", "в то", "при этом", "уже не", "в его", "это было", "во время", "что она", "того что", "как будто", 
                "то же", "но в", "как в", "ко мне", "так же", "а также", "и по", "что у", "у них", "и т", 
                "и так", "и вот", "один из", "никто не", "в москве", "и его", "у вас", "к тому", "не могу", "в конце", 
                "что вы", "но я", "что они", "я и", "только в", "его в", "таким образом", "что и", "в россии", "несмотря на"
            };
            weights = new int[]
            {
                201352, 193983, 117401, 113767, 97102, 96065, 95251, 92743, 92729, 89842, 
                86446, 84820, 82963, 80398, 80252, 77858, 75642, 74347, 71816, 71614, 
                71079, 68787, 68653, 67202, 66971, 66247, 65937, 60045, 58376, 57962, 
                56860, 52951, 50613, 50243, 49521, 49285, 49262, 49137, 48879, 48344, 
                48225, 48027, 47665, 47558, 47525, 47234, 46620, 45100, 44977, 44953, 
                44867, 44753, 44428, 42588, 42307, 41386, 40338, 40336, 40316, 40259, 
                40197, 39971, 39931, 39037, 38517, 38081, 37952, 37436, 37244, 37176, 
                37103, 36943, 36837, 36495, 36435, 36133, 35266, 35149, 34548, 33965, 
                33734, 33586, 33342, 33320, 33159, 33095, 33010, 32814, 32714, 32590, 
                32428, 31972, 31330, 31004, 30819, 30782, 30278, 30274, 29973, 29741
            };
        }
        private string[] pairs;
        private int[] weights;
        
        public string GenerateText(int length, int? randSeed = null)
        {
            Random random = randSeed == null ? new Random() : new Random(randSeed.Value);
            string text = "";
            for (int i = 0; i < length; i++)
            {
                int pairIndex = Roulette.Roll(weights, random);
                string pair = pairs[pairIndex];
                text += pair + " ";
            }
            return text;
        }
    }
}