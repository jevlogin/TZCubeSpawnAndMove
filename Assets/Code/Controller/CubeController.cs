using DG.Tweening;
using System;
using UnityEngine;


internal sealed class CubeController : IInitialization, IDisposable
{
    #region Fields

    private CubeModel _cubeModel;
    private CanvasModel _canvasModel;

    #endregion


    #region ClassLifeCycles

    public CubeController(CubeModel cubeModel, CanvasModel canvasModel)
    {
        _canvasModel = canvasModel;
        _cubeModel = cubeModel;
    }

    #endregion


    #region IDisposable

    public void Dispose()
    {
        _canvasModel.CanvasComponents.CanvasView.SubmitButton.onClick.RemoveAllListeners();
    }

    #endregion


    #region IInitialization

    public void Initialization()
    {
        _canvasModel.CanvasComponents.CanvasView.SubmitButton.onClick.AddListener(CheckAndSendParameters);
    }

    #endregion


    #region Methods

    private void CheckAndSendParameters()
    {
        var cube = _cubeModel.CubeComponents.CubeTransform;
        var speed = _canvasModel.CanvasStruct.Speed;
        var distance = _canvasModel.CanvasStruct.Distance;
        var timeInterval = _canvasModel.CanvasStruct.TimeInterval;

        var timeToMove = distance / speed;

        var sequence = DOTween.Sequence();
        sequence.Append(cube.DOMoveZ(distance, timeToMove).SetEase(Ease.InOutBack));
        sequence.Append(cube.DOScale(Vector3.zero, 1.0f).SetEase(Ease.InCubic));
        sequence.AppendInterval(timeInterval);

        sequence.OnComplete(() =>
        {
            cube.localPosition = _cubeModel.CubeStruct.StartPosition;
            cube.localRotation = _cubeModel.CubeStruct.StartRotation;
            cube.localScale = Vector3.one;
        });
    }

    #endregion
}