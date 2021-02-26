using UnityEngine;
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
using UnityEngine.EventSystems;
#endif
using Cysharp.Threading.Tasks.Triggers;
using Cysharp.Threading.Tasks;

namespace toddlerer.UniTaskWithCancellationToken
{
    public readonly partial struct UniTaskWithCancellationToken
    {
        public UniTask Wrap(AsyncFixedUpdateTrigger asyncFixedUpdateTrigger)
            => asyncFixedUpdateTrigger.FixedUpdateAsync(cancellationToken);
        public UniTask Wrap(AsyncLateUpdateTrigger asyncLateUpdateTrigger)
            => asyncLateUpdateTrigger.LateUpdateAsync(cancellationToken);
        public UniTask<int> Wrap(AsyncAnimatorIKTrigger asyncAnimatorIKTrigger)
            => asyncAnimatorIKTrigger.OnAnimatorIKAsync(cancellationToken);
        public UniTask Wrap(AsyncAnimatorMoveTrigger asyncAnimatorMoveTrigger)
            => asyncAnimatorMoveTrigger.OnAnimatorMoveAsync(cancellationToken);
        public UniTask<bool> Wrap(AsyncApplicationFocusTrigger asyncApplicationFocusTrigger)
            => asyncApplicationFocusTrigger.OnApplicationFocusAsync(cancellationToken);
        public UniTask<bool> Wrap(AsyncApplicationPauseTrigger asyncApplicationPauseTrigger)
            => asyncApplicationPauseTrigger.OnApplicationPauseAsync(cancellationToken);
        public UniTask Wrap(AsyncApplicationQuitTrigger asyncApplicationQuitTrigger)
            => asyncApplicationQuitTrigger.OnApplicationQuitAsync(cancellationToken);
        public UniTask<(float[] data, int channels)> Wrap(AsyncAudioFilterReadTrigger asyncAudioFilterReadTrigger)
            => asyncAudioFilterReadTrigger.OnAudioFilterReadAsync(cancellationToken);
        public UniTask Wrap(AsyncBecameInvisibleTrigger asyncBecameInvisibleTrigger)
            => asyncBecameInvisibleTrigger.OnBecameInvisibleAsync(cancellationToken);
        public UniTask Wrap(AsyncBecameVisibleTrigger asyncBecameVisibleTrigger)
            => asyncBecameVisibleTrigger.OnBecameVisibleAsync(cancellationToken);
        public UniTask Wrap(AsyncBeforeTransformParentChangedTrigger asyncBeforeTransformParentChangedTrigger)
            => asyncBeforeTransformParentChangedTrigger.OnBeforeTransformParentChangedAsync(cancellationToken);
        public UniTask Wrap(AsyncOnCanvasGroupChangedTrigger asyncOnCanvasGroupChangedTrigger)
            => asyncOnCanvasGroupChangedTrigger.OnCanvasGroupChangedAsync(cancellationToken);
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collision> Wrap(AsyncCollisionEnterTrigger asyncCollisionEnterTrigger)
            => asyncCollisionEnterTrigger.OnCollisionEnterAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collision2D> Wrap(AsyncCollisionEnter2DTrigger asyncCollisionEnter2DTrigger)
            => asyncCollisionEnter2DTrigger.OnCollisionEnter2DAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collision> Wrap(AsyncCollisionExitTrigger asyncCollisionExitTrigger)
            => asyncCollisionExitTrigger.OnCollisionExitAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collision2D> Wrap(AsyncCollisionExit2DTrigger asyncCollisionExit2DTrigger)
            => asyncCollisionExit2DTrigger.OnCollisionExit2DAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collision> Wrap(AsyncCollisionStayTrigger asyncCollisionStayTrigger)
            => asyncCollisionStayTrigger.OnCollisionStayAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collision2D> Wrap(AsyncCollisionStay2DTrigger asyncCollisionStay2DTrigger)
            => asyncCollisionStay2DTrigger.OnCollisionStay2DAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<ControllerColliderHit> Wrap(AsyncControllerColliderHitTrigger asyncControllerColliderHitTrigger)
            => asyncControllerColliderHitTrigger.OnControllerColliderHitAsync(cancellationToken);
#endif
        public UniTask Wrap(AsyncDisableTrigger asyncDisableTrigger)
            => asyncDisableTrigger.OnDisableAsync(cancellationToken);
        public UniTask Wrap(AsyncDrawGizmosTrigger asyncDrawGizmosTrigger)
            => asyncDrawGizmosTrigger.OnDrawGizmosAsync(cancellationToken);
        public UniTask Wrap(AsyncDrawGizmosSelectedTrigger asyncDrawGizmosSelectedTrigger)
            => asyncDrawGizmosSelectedTrigger.OnDrawGizmosSelectedAsync(cancellationToken);
        public UniTask Wrap(AsyncEnableTrigger asyncEnableTrigger)
            => asyncEnableTrigger.OnEnableAsync(cancellationToken);
        public UniTask Wrap(AsyncGUITrigger asyncGUITrigger)
            => asyncGUITrigger.OnGUIAsync(cancellationToken);
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<float> Wrap(AsyncJointBreakTrigger asyncJointBreakTrigger)
            => asyncJointBreakTrigger.OnJointBreakAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Joint2D> Wrap(AsyncJointBreak2DTrigger asyncJointBreak2DTrigger)
            => asyncJointBreak2DTrigger.OnJointBreak2DAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseDownTrigger asyncMouseDownTrigger)
            => asyncMouseDownTrigger.OnMouseDownAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseDragTrigger asyncMouseDragTrigger)
            => asyncMouseDragTrigger.OnMouseDragAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseEnterTrigger asyncMouseEnterTrigger)
            => asyncMouseEnterTrigger.OnMouseEnterAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseExitTrigger asyncMouseExitTrigger)
            => asyncMouseExitTrigger.OnMouseExitAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseOverTrigger asyncMouseOverTrigger)
            => asyncMouseOverTrigger.OnMouseOverAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseUpTrigger asyncMouseUpTrigger)
            => asyncMouseUpTrigger.OnMouseUpAsync(cancellationToken);
#endif
#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)
        public UniTask Wrap(AsyncMouseUpAsButtonTrigger asyncMouseUpAsButtonTrigger)
            => asyncMouseUpAsButtonTrigger.OnMouseUpAsButtonAsync(cancellationToken);
#endif
        public UniTask<GameObject> Wrap(AsyncParticleCollisionTrigger asyncParticleCollisionTrigger)
            => asyncParticleCollisionTrigger.OnParticleCollisionAsync(cancellationToken);
        public UniTask Wrap(AsyncParticleSystemStoppedTrigger asyncParticleSystemStoppedTrigger)
            => asyncParticleSystemStoppedTrigger.OnParticleSystemStoppedAsync(cancellationToken);
        public UniTask Wrap(AsyncParticleTriggerTrigger asyncParticleTriggerTrigger)
            => asyncParticleTriggerTrigger.OnParticleTriggerAsync(cancellationToken);
#if UNITY_2019_3_OR_NEWER && (!UNITY_2019_1_OR_NEWER || UNITASK_PARTICLESYSTEM_SUPPORT)
        public UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> Wrap(AsyncParticleUpdateJobScheduledTrigger asyncParticleUpdateJobScheduledTrigger)
            => asyncParticleUpdateJobScheduledTrigger.OnParticleUpdateJobScheduledAsync(cancellationToken);
#endif
        public UniTask Wrap(AsyncPostRenderTrigger asyncPostRenderTrigger)
            => asyncPostRenderTrigger.OnPostRenderAsync(cancellationToken);
        public UniTask Wrap(AsyncPreCullTrigger asyncPreCullTrigger)
            => asyncPreCullTrigger.OnPreCullAsync(cancellationToken);
        public UniTask Wrap(AsyncPreRenderTrigger asyncPreRenderTrigger)
            => asyncPreRenderTrigger.OnPreRenderAsync(cancellationToken);
        public UniTask Wrap(AsyncRectTransformDimensionsChangeTrigger asyncRectTransformDimensionsChangeTrigger)
            => asyncRectTransformDimensionsChangeTrigger.OnRectTransformDimensionsChangeAsync(cancellationToken);
        public UniTask Wrap(AsyncRectTransformRemovedTrigger asyncRectTransformRemovedTrigger)
            => asyncRectTransformRemovedTrigger.OnRectTransformRemovedAsync(cancellationToken);
        public UniTask<(RenderTexture source, RenderTexture destination)> Wrap(AsyncRenderImageTrigger asyncRenderImageTrigger)
            => asyncRenderImageTrigger.OnRenderImageAsync(cancellationToken);
        public UniTask Wrap(AsyncRenderObjectTrigger asyncRenderObjectTrigger)
            => asyncRenderObjectTrigger.OnRenderObjectAsync(cancellationToken);
        public UniTask Wrap(AsyncServerInitializedTrigger asyncServerInitializedTrigger)
            => asyncServerInitializedTrigger.OnServerInitializedAsync(cancellationToken);
        public UniTask Wrap(AsyncTransformChildrenChangedTrigger asyncTransformChildrenChangedTrigger)
            => asyncTransformChildrenChangedTrigger.OnTransformChildrenChangedAsync(cancellationToken);
        public UniTask Wrap(AsyncTransformParentChangedTrigger asyncTransformParentChangedTrigger)
            => asyncTransformParentChangedTrigger.OnTransformParentChangedAsync(cancellationToken);
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collider> Wrap(AsyncTriggerEnterTrigger asyncTriggerEnterTrigger)
            => asyncTriggerEnterTrigger.OnTriggerEnterAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collider2D> Wrap(AsyncTriggerEnter2DTrigger asyncTriggerEnter2DTrigger)
            => asyncTriggerEnter2DTrigger.OnTriggerEnter2DAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collider> Wrap(AsyncTriggerExitTrigger asyncTriggerExitTrigger)
            => asyncTriggerExitTrigger.OnTriggerExitAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collider2D> Wrap(AsyncTriggerExit2DTrigger asyncTriggerExit2DTrigger)
            => asyncTriggerExit2DTrigger.OnTriggerExit2DAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS_SUPPORT
        public UniTask<Collider> Wrap(AsyncTriggerStayTrigger asyncTriggerStayTrigger)
            => asyncTriggerStayTrigger.OnTriggerStayAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_PHYSICS2D_SUPPORT
        public UniTask<Collider2D> Wrap(AsyncTriggerStay2DTrigger asyncTriggerStay2DTrigger)
            => asyncTriggerStay2DTrigger.OnTriggerStay2DAsync(cancellationToken);
#endif
        public UniTask Wrap(AsyncValidateTrigger asyncValidateTrigger)
            => asyncValidateTrigger.OnValidateAsync(cancellationToken);
        public UniTask Wrap(AsyncWillRenderObjectTrigger asyncWillRenderObjectTrigger)
            => asyncWillRenderObjectTrigger.OnWillRenderObjectAsync(cancellationToken);
        public UniTask Wrap(AsyncResetTrigger asyncResetTrigger)
            => asyncResetTrigger.ResetAsync(cancellationToken);
        public UniTask Wrap(AsyncUpdateTrigger asyncUpdateTrigger)
            => asyncUpdateTrigger.UpdateAsync(cancellationToken);
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncBeginDragTrigger asyncBeginDragTrigger)
            => asyncBeginDragTrigger.OnBeginDragAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<BaseEventData> Wrap(AsyncCancelTrigger asyncCancelTrigger)
            => asyncCancelTrigger.OnCancelAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<BaseEventData> Wrap(AsyncDeselectTrigger asyncDeselectTrigger)
            => asyncDeselectTrigger.OnDeselectAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncDragTrigger asyncDragTrigger)
            => asyncDragTrigger.OnDragAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncDropTrigger asyncDropTrigger)
            => asyncDropTrigger.OnDropAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncEndDragTrigger asyncEndDragTrigger)
            => asyncEndDragTrigger.OnEndDragAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncInitializePotentialDragTrigger asyncInitializePotentialDragTrigger)
            => asyncInitializePotentialDragTrigger.OnInitializePotentialDragAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<AxisEventData> Wrap(AsyncMoveTrigger asyncMoveTrigger)
            => asyncMoveTrigger.OnMoveAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncPointerClickTrigger asyncPointerClickTrigger)
            => asyncPointerClickTrigger.OnPointerClickAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncPointerDownTrigger asyncPointerDownTrigger)
            => asyncPointerDownTrigger.OnPointerDownAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncPointerEnterTrigger asyncPointerEnterTrigger)
            => asyncPointerEnterTrigger.OnPointerEnterAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncPointerExitTrigger asyncPointerExitTrigger)
            => asyncPointerExitTrigger.OnPointerExitAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncPointerUpTrigger asyncPointerUpTrigger)
            => asyncPointerUpTrigger.OnPointerUpAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<PointerEventData> Wrap(AsyncScrollTrigger asyncScrollTrigger)
            => asyncScrollTrigger.OnScrollAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<BaseEventData> Wrap(AsyncSelectTrigger asyncSelectTrigger)
            => asyncSelectTrigger.OnSelectAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<BaseEventData> Wrap(AsyncSubmitTrigger asyncSubmitTrigger)
            => asyncSubmitTrigger.OnSubmitAsync(cancellationToken);
#endif
#if !UNITY_2019_1_OR_NEWER || UNITASK_UGUI_SUPPORT
        public UniTask<BaseEventData> Wrap(AsyncUpdateSelectedTrigger asyncUpdateSelectedTrigger)
            => asyncUpdateSelectedTrigger.OnUpdateSelectedAsync(cancellationToken);
#endif
    }
}