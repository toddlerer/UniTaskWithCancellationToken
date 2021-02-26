using System.Threading;
using UnityEngine;
using Cysharp.Threading.Tasks;
using toddlerer.UniTaskWithCancellationToken;
using Cysharp.Threading.Tasks.Triggers;

public class SandBox : MonoBehaviour
{
    async UniTaskVoid Start()
    {

        await UniTask.Delay(1000);
        print("hello");
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        var uniTask = new UniTaskWithCancellationToken(cancellationToken);

        await uniTask.OverWrap(uniTask.Delay(1).WithCancellation(cancellationToken));
        UniTask.Action(async (c) => { await UniTask.Yield(); }, cancellationToken);
        uniTask.Action(async (c) => { await uniTask.Yield(PlayerLoopTiming.Update); });
        await gameObject.GetAsyncDisableTrigger().OnDisableAsync(cancellationToken);
        // await this.GetAsyncFixedUpdateTrigger().OnDestroyAsync();
        await uniTask.Wrap(this.GetAsyncFixedUpdateTrigger());
        await uniTask.Wrap(this.GetAsyncAnimatorIKTrigger());
        this.GetAsyncFixedUpdateTrigger().GetFixedUpdateAsyncHandler();
        await uniTask.Delay(1000);
        await uniTask.NextFrame();
        print("helloa");
        uniTask = new UniTaskWithCancellationToken(cancellationToken);
        cancellationTokenSource.CancelAfter(3000);
        try
        {
            await uniTask.Delay(5000);
            print("ok");
        }
        catch (System.OperationCanceledException ex)
        {
            Debug.LogException(ex);
        }
        finally
        {
            print("finally");
        }
    }

}
