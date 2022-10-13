using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    public struct CanvasStruct
    {
        [SerializeField] private GameObject _prefab;

        public GameObject Prefab => _prefab;
    }
}