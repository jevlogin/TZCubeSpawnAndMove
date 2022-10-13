using UnityEngine;
using WORLDGAMEDEVELOPMENT;


internal sealed class CanvasFactory
{
    #region Fields

    private CanvasData _canvasData;
    private CanvasModel _canvasModel;

    #endregion


    #region ClassLifeCycles

    public CanvasFactory(CanvasData canvasData)
    {
        _canvasData = canvasData;
    }

    #endregion


    #region Methods

    internal CanvasModel CreateCanvasModel()
    {
        if (_canvasModel == null)
        {
            var canvasStruct = _canvasData.CanvasStruct;
            var canvasSpawn = Object.Instantiate(_canvasData.CanvasStruct.Prefab);
            _canvasModel = new CanvasModel(canvasStruct);
        }
        return _canvasModel;
    }

    #endregion
}