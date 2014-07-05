## 津田塾大学 Unity セミナー

### 配布物

- [Clear.fbx](https://github.com/keijiro/TsudaUnity/raw/handouts/Clear.fbx)
- [Sample Assets beta.unitypackage](https://dl.dropboxusercontent.com/u/137644105/Sample%20Assets%20beta.unitypackage)

### 前編：Unity 復習

- サンプルを見てみる
- Unity 基本操作
- プレイヤーの操作系
- 箱のプレハブ化と配置
- メダルの配置
- モデルのインポート

```csharp
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector3.up * 300);
        }
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * 20);
        rigidbody.AddForce(Vector3.forward * Input.GetAxis("Vertical") * 20);
    }
}
```

```csharp
using UnityEngine;
using System.Collections;

public class Medal : MonoBehaviour
{
    public GameObject clearText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            clearText.SetActive(true);
        }
    }
}
```

### 後編：Unity 応用

- Sample Assets のインポート
- Prototype プレハブを使ってみる
- 様々な Vehicle
- サンプルを豪華に作り直してみる
