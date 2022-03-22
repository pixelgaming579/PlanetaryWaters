using System.Collections.Generic;
using UnityEngine;
using SFS.World;
using SFS.WorldBase;
using SFS.Input;
using SFS.UI;
using static SFS.Base;

namespace PlanetaryWaters
{
    public class PlanetDataLoader : MonoBehaviour
    {
        Dictionary<string, Planet> planets = planetLoader.planets;
        
        private void Start()
        {

        }
        private void Update()
        {

        }
        public void RemoveWaters()
        {
            foreach (Planet planet in planets)
            {
                planet.GetComponent<PlanetWater>().RemoveWater()
            }
        }
    }
}
