using WORLDGAMEDEVELOPMENT;


internal sealed class CanvasModel
{
    #region Fields

    public CanvasStruct CanvasStruct;
    public CanvasComponents CanvasComponents;

    #endregion


    #region ClassLifeCycles

    public CanvasModel(CanvasStruct canvasStruct, CanvasComponents canvasComponents)
    {
        CanvasStruct = canvasStruct;
        CanvasComponents = canvasComponents;
    }

    #endregion
}