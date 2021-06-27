using System;
namespace warmup
{
    public class Species
    {
        public string speciesName;
        public int avgHeight;
        public bool telepathic;

        public Species(string _speciesName, int _avgHeight, bool _telepath )
        {
            speciesName = _speciesName;
            avgHeight = _avgHeight;
            telepathic = _telepath;
        }

        /*the instances get moved into the Character class
         * because that's where the data is being used
         */

    }
}
