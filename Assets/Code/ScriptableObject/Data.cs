using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data", order = 51)]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _canvasDataPath;

        private CanvasData _canvasData;

        public CanvasData CanvasData 
        {
            get
            {
                if (_canvasData == null)
                {
                    _canvasData = Resources.Load<CanvasData>(Path.Combine(ManagerPath.DATA, ManagerPath.CANVASDATA));
                }
                if (_canvasData == null)
                {
                    _canvasData = Resources.Load<CanvasData>(Path.Combine(ManagerPath.DATA, _canvasDataPath)); 
                }
                return _canvasData;
            }
        }
    }
}