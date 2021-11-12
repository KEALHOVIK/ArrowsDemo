using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace Level
{
    namespace Track
    {
        public interface ITargerProvider
        {
            public GameObject GetSuitableTarget(List<GameObject> targetPrefabs, BigInteger targetResult, (int Min, int Max) numberOfTargetsRange);
        }
    }
}