using DG.Tweening;
using TMPro;
using UnityEngine;

namespace _Project.CodeBase.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class TaskView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _taskDescriptionText;
        [SerializeField] private TMP_Text _taskAnswerText;

        private CanvasGroup _canvasGroup;


        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        private void Start()
        {
            _canvasGroup.alpha = 0;
        }

        public void ShowTask(string taskDescription, string taskAnswer)
        {
            _taskDescriptionText.text = taskDescription;
            _taskAnswerText.text = taskAnswer;

            _canvasGroup.DOFade(1f, 2f).SetEase(Ease.InOutQuad);
        }

        public void HideTask()
        {
            _canvasGroup.DOFade(0f, 2f).SetEase(Ease.InOutQuad);
        }
    }
}