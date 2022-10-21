using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [Serializable]
    public struct CanvasStruct
    {
        #region Fields

        [SerializeField] internal float Speed;
        [SerializeField] internal float Distance;
        [SerializeField] internal float TimeInterval;
        [SerializeField] private GameObject _prefab;

        #endregion


        #region Properties

        public GameObject Prefab => _prefab;

        #endregion
    }
}