using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace BurgZergArcade.ItemSystem
{
    public class ISObjectDatabase : ScriptableObject
    {
        [SerializeField] List<ISObject> ObjectDatabase;

    }
}