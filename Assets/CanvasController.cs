internal class CanvasController : IController
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
}