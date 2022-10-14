using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data", order = 51)]
    public sealed class Data : ScriptableObject
    {
        #region Fields

        [SerializeField] private string _canvasDataPath;
        [SerializeField] private string _cubeDataPath;

        private CanvasData _canvasData;
        private CubeData _cubeData;

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


        public CubeData CubeData
        {
            get
            {
                if (_cubeData == null)
                {
                    _cubeData = Resources.Load<CubeData>(Path.Combine(ManagerPath.DATA, ManagerPath.CUBEDATA));
                }
                if (_cubeData == null)
                {
                    _cubeData = Resources.Load<CubeData>(Path.Combine(_cubeDataPath));
                }
                return _cubeData;
            }
        }
        #endregion
    }
}