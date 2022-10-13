using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "CanvasData", menuName = "Data/CanvasData", order = 51)]
    public sealed class CanvasData : ScriptableObject
    {
        #region Fields

        [SerializeField] private CanvasStruct _canvasStruct;

        #endregion


        #region Properties

        public CanvasStruct CanvasStruct => _canvasStruct;

        #endregion
    }
}