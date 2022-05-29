using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Config
{
    public enum SceneConfig
    { 
        Title,
        Main
    }


    public class PreSet
    {
        public static Dictionary<string, Color32> ColorDict
            = new Dictionary<string, Color32>()
            {
                ["Blue"] = new Color32(0, 100, 255, 255),
                ["Red"] = new Color32(255, 25, 0, 255),
                ["Black"] = new Color32(0, 0, 0, 255)
            };
    }

    
}
