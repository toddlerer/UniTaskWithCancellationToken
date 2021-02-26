# UniTaskWithCancellationToken

Omit passing CancellationToken as an argument repeatedly in UniTask.

Supports `Cysharp.Threading.Tasks` and `Cysharp.Threading.Tasks.Triggers`.

```cs
using System.Threading;
using UnityEngine;
using System.Collections;
using Cysharp.Threading.Tasks;
using toddlerer.UniTaskWithCancellationToken; // You need to use this namespace

public class Sample1 : MonoBehaviour
{
    public float value;
    async UniTaskVoid Start()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        // this is UniTaskWithCancellationToken Object
        var uniTask = new UniTaskWithCancellationToken(cancellationToken);

        await UniTask.Delay(1000, cancellationToken: cancellationToken);
        await uniTask.Delay(1000); // You can write this instead

        var fooAsset = await Resources.LoadAsync<TextAsset>("foo").WithCancellation(cancellationToken);
        var fooAsset2 = await uniTask.Wrap(Resources.LoadAsync<TextAsset>("foo")); // You can write this instead

        await UniTask.DelayFrame(100, PlayerLoopTiming.FixedUpdate, cancellationToken);
        await uniTask.DelayFrame(100, PlayerLoopTiming.FixedUpdate); // You can write this instead

        IEnumerator FooCoroutine()
        {
            Debug.Log("Start Coroutine");
            yield return null;
            Debug.Log("End Coroutine");
        }
        await FooCoroutine().WithCancellation(cancellationToken);
        await uniTask.Wrap(FooCoroutine()); // You can write this instead

        await UniTask.NextFrame(cancellationToken: cancellationToken);
        await uniTask.NextFrame(); // You can write this instead

        await UniTask.WaitUntil(() => value > 1, cancellationToken: cancellationToken);
        await uniTask.WaitUntil(() => value > 1); // You can write this instead


        await UniTask.SwitchToThreadPool();

        /* work on ThreadPool */

        await UniTask.SwitchToMainThread(cancellationToken: cancellationToken);
        await uniTask.SwitchToMainThread(); // You can write this instead
    }
}
```

## Requirements

[UniTask](https://github.com/Cysharp/UniTask)

## Installing

### Install via Git URL

Requires a version of unity that supports path query parameter for git packages (Unity >= 2019.3.4f1, Unity >= 2020.1a21). You can add `https://github.com/toddlerer/UniTaskWithCancellationToken.git?path=src/UniTaskWithCancellationToken/Assets/UniTaskWithCancellationToken` to Package Manager

## Credits

### UniTask

The MIT License (MIT)

Copyright (c) 2019 Yoshifumi Kawai / Cysharp, Inc.

<https://github.com/Cysharp/UniTask/blob/master/LICENSE>

## License

[MIT License](./LICENSE)
