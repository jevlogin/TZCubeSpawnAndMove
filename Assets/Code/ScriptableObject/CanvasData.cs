using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "CanvasData", menuName = "Data/CanvasData", order = 51)]
    public sealed class CanvasData : ScriptableObject
    {
        private CanvasStruct _canvasStruct;

        public CanvasStruct CanvasStruct => _canvasStruct;
    }
}