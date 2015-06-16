using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    
    public interface IISObject
    {
        string Name { get; set; }
        int Value { get; set; }  //Gold Value
        Sprite Icon { get; set; }
        int Burdon { get; set; }
        ISQuality Quality { get; set; }


    }
}