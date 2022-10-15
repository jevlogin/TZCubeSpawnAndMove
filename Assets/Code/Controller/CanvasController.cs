internal class CanvasController : IInitialization
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
        _canvasModel.CanvasComponents.CanvasView.InputFieldSpeed.text = "666 km/h";
        _canvasModel.CanvasComponents.CanvasView.InputFieldDistance.text = "999 km";
        _canvasModel.CanvasComponents.CanvasView.InputFieldTimeInterval.text = "10";
    }

    #endregion
}