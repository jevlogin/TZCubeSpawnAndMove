using System;
using UnityEngine;


internal sealed class CanvasController : IInitialization, IDisposable
{
    #region Fields

    private CanvasModel _canvasModel;

    #endregion


    #region ClassLifeCycles

    public CanvasController(CanvasModel canvasModel)
    {
        _canvasModel = canvasModel;
    }

    #endregion


    #region IInitialization

    public void Initialization()
    {
        _canvasModel.CanvasComponents.CanvasView.InputFieldSpeed.onValueChanged.AddListener(InputSpeed);
        _canvasModel.CanvasComponents.CanvasView.InputFieldDistance.onValueChanged.AddListener(InputDistance);
        _canvasModel.CanvasComponents.CanvasView.InputFieldTimeInterval.onValueChanged.AddListener(InputInterval);
    }

    #endregion


    #region Methods

    private void InputInterval(string valueTime)
    {
        if (float.TryParse(valueTime, out _canvasModel.CanvasStruct.TimeInterval))
        {
            Debug.Log($"TimeInterval = {_canvasModel.CanvasStruct.TimeInterval}");
        }
        else
        {
            var text = _canvasModel.CanvasComponents.CanvasView.InputFieldTimeInterval.text;
            text = text.Remove(text.Length - 1);
            _canvasModel.CanvasComponents.CanvasView.InputFieldTimeInterval.text = text;
        }
    }

    private void InputDistance(string valueDistance)
    {
        if (float.TryParse(valueDistance, out _canvasModel.CanvasStruct.Distance))
        {
            Debug.Log($"Distance = {_canvasModel.CanvasStruct.Distance}");
        }
        else
        {
            var text = _canvasModel.CanvasComponents.CanvasView.InputFieldDistance.text;
            text = text.Remove(text.Length - 1);
            _canvasModel.CanvasComponents.CanvasView.InputFieldDistance.text = text;
        }
    }

    private void InputSpeed(string valueSpeed)
    {
        if (float.TryParse(valueSpeed, out _canvasModel.CanvasStruct.Speed))
        {
            Debug.Log($"Speed = {_canvasModel.CanvasStruct.Speed}");
        }
        else
        {
            var text = _canvasModel.CanvasComponents.CanvasView.InputFieldSpeed.text;
            text = text.Remove(text.Length - 1);
            _canvasModel.CanvasComponents.CanvasView.InputFieldSpeed.text = text;
        }
    }

    #endregion


    #region IDisposable

    public void Dispose()
    {
        _canvasModel.CanvasComponents.CanvasView.InputFieldSpeed.onValueChanged.RemoveAllListeners();
        _canvasModel.CanvasComponents.CanvasView.InputFieldDistance.onValueChanged.RemoveAllListeners();
        _canvasModel.CanvasComponents.CanvasView.InputFieldTimeInterval.onValueChanged.RemoveAllListeners();
    }

    #endregion
}