using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [Serializable]
    public struct CubeStruct
    {
        #region Fields

        [SerializeField] private GameObject _prefab;
        internal Vector3 StartPosition;
        internal Quaternion StartRotation;

        #endregion


        #region Properties

        public GameObject Prefab => _prefab;

        #endregion
    }
}