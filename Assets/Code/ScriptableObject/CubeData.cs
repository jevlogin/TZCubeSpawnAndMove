using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "CubeData", menuName = "Data/CubeData", order = 51)]
    public sealed class CubeData : ScriptableObject
    {
        #region Fields

        [SerializeField] private CubeStruct _cubeStruct;
        [SerializeField] private CubeComponents _cubeComponents;

        #endregion


        #region Properties

        public CubeStruct CubeStruct => _cubeStruct;
        public CubeComponents CubeComponents => _cubeComponents;

        #endregion
    }
}