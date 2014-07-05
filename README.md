## 津田塾大学 Unity セミナー

### 配布物

- ["Clear!!" の文字のモデル](https://github.com/keijiro/TsudaUnity/raw/handouts/Clear.fbx)
- [Sample Assets (beta)](https://dl.dropboxusercontent.com/u/137644105/Sample%20Assets%20beta.unitypackage)

### 前編：Unity 復習

- 作例を確認
- プレイヤーの操作系
- 箱のプレハブ化と配置
- メダルの配置と当たり判定
- “Clear!!” モデルのインポート
- Active フラグの操作

### 後編：Unity 応用

- Sample Assets のインポート（かなり時間かかる）
- Asset Store と Sample Asset の説明 → [リンク](https://www.assetstore.unity3d.com/jp/#!/content/14474)
- 様々なサンプル (Sample Assets/Sample Scenes/Scenes)
- Prototype プレハブを使ってみる
- サンプルを豪華に作り直してみる
- AI を使ってみる

### ソースコードリスト

```csharp
// Player.cs
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
// Medal.cs
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

