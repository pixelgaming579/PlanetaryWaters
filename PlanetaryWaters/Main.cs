using System;
// using System.Collections;
using UnityEngine;
using ModLoader;
// using HarmonyLib;
using SFS;
using SFS.WorldBase;

namespace PlanetaryWaters
{
    public class Main : SFSMod
    {
        GameObject manager;
        public Main() : base("PlanetaryWaters", "PlanetaryWaters", "pixel_gamer579", "v1.x.x", "v1.0", "Adds water/oceans with physics to planets!"){}
        private void WorldLoaded(object sender, EventArgs e)
        {
            manager = new GameObject("WaterManager", typeof(PlanetDataLoader));
            UnityEngine.Object.DontDestroyOnLoad(manager);
            manager.SetActive(true);
        }
        private void HomeLoaded(object sender, EventArgs e)
        {
            if (manager != null)
            {
                manager.GetComponent<PlanetDataLoader>().RemoveWaters();
                UnityEngine.Object.Destroy(manager);
                manager = null;
            }
        }
        private void BuildLoaded(object sender, EventArgs e)
        {
            if (manager != null)
            {
                UnityEngine.Object.Destroy(manager);
                manager = null;
            }
        }
        public override void load()
        {
            Helper.OnWorldSceneLoaded += this.WorldLoaded;
            Helper.OnHomeSceneLoaded += this.HomeLoaded;
            Helper.OnBuildSceneLoaded += this.BuildLoaded;
        }
        public override void unload()
        {
            throw new System.NotImplementedException();
        }
    }
}
