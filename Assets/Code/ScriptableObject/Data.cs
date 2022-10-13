using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data", order = 51)]
    public sealed class Data : ScriptableObject
    {
        #region Fields

        [SerializeField] private string _canvasDataPath;

        private CanvasData _canvasData;

        #endregion


        #region Properties

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
                    _canvasData = Resources.Load<CanvasData>(Path.Combine(_canvasDataPath));
                }
                return _canvasData;
            }
        }

        #endregion
    }
}