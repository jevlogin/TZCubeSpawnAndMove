using DG.Tweening;

internal class CubeController : IInitialization
{
    private CubeModel _cubeModel;

    public CubeController(CubeModel cubeModel)
    {
        _cubeModel = cubeModel;
    }

    public void Initialization()
    {
        var cube = _cubeModel.CubeComponents.CubeTransform;
        cube.DOMoveZ(10.0f, 5.0f);
    }
}