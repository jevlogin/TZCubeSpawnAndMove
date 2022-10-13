﻿using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [Serializable]
    public struct CanvasStruct
    {
        #region Fields

        [SerializeField] private GameObject _prefab;

        #endregion


        #region Properties

        public GameObject Prefab => _prefab;

        #endregion
    }
}