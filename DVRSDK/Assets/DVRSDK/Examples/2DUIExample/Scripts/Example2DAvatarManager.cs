using UnityEngine;

namespace DVRSDK.Test
{
    public class Example2DAvatarManager : MonoBehaviour
    {
        [SerializeField]
        private DMMVRConnectUI dmmVRConnectUI;

        [SerializeField] private RuntimeAnimatorController _controller;

        private void Awake()
        {
            dmmVRConnectUI.OnAvatarLoadedAction += OnAvatarLoaded;
        }

        private void OnAvatarLoaded(GameObject model)
        {
            dmmVRConnectUI.ShowVRM();
            dmmVRConnectUI.AddAutoBlink();
            
            Debug.Log(model, model);

            // アバターロード後指定のアニメーションを再生する
            var animator = model.GetComponent<Animator>();
            animator.runtimeAnimatorController = _controller;
        }
    }
}
