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

    internal CanvasModel GetCanvasModel()
    {
        if (_canvasModel == null)
        {
            var canvasStruct = _canvasData.CanvasStruct;
            var canvasSpawn = Object.Instantiate(_canvasData.CanvasStruct.Prefab);
            var canvasComponents = _canvasData.CanvasComponents;
            
            canvasComponents.CanvasView = canvasSpawn.GetComponentInChildren<CanvasView>();
            canvasComponents.CanvasView.InputFieldSpeed.text = canvasStruct.Speed.ToString();
            canvasComponents.CanvasView.InputFieldDistance.text = canvasStruct.Distance.ToString();
            canvasComponents.CanvasView.InputFieldTimeInterval.text = canvasStruct.TimeInterval.ToString();

            _canvasModel = new CanvasModel(canvasStruct, canvasComponents);
        }
        return _canvasModel;
    }

    #endregion
}