using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace WORLDGAMEDEVELOPMENT
{
    public sealed class CanvasView : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Button _submitButton;
        [SerializeField] private TMP_InputField _inputFieldSpeed;
        [SerializeField] private TMP_InputField _inputFieldDistance;
        [SerializeField] private TMP_InputField _inputFieldTimeInterval;

        #endregion


        #region Properties

        public Button SubmitButton => _submitButton;
        public TMP_InputField InputFieldSpeed => _inputFieldSpeed;
        public TMP_InputField InputFieldDistance => _inputFieldDistance;
        public TMP_InputField InputFieldTimeInterval => _inputFieldTimeInterval;

        #endregion
    }
}