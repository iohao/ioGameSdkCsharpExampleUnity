using Config;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyNetConfig.StartNet();

        OnClick("OnIntValue").AddListener(() => { _ = Index.OnIntValue(); });
        OnClick("OnLongValue").AddListener(() => { _ = Index.OnLongValue(); });
        OnClick("OnBoolValue").AddListener(() => { _ = Index.OnBoolValue(); });
        OnClick("OnStringValue").AddListener(() => { _ = Index.OnStringValue(); });
        OnClick("OnValueObject").AddListener(() => { _ = Index.OnValueObject(); });

        OnClick("OnListInt").AddListener(() => { _ = Index.OnListInt(); });
        OnClick("OnListLong").AddListener(() => { _ = Index.OnListLong(); });
        OnClick("OnListBool").AddListener(() => { _ = Index.OnListBool(); });
        OnClick("OnListString").AddListener(() => { _ = Index.OnListString(); });
        OnClick("OnListValue").AddListener(() => { _ = Index.OnListValue(); });

        OnClick("OnTestError").AddListener(() => { _ = Index.OnTestError(); });
        OnClick("OnTriggerBroadcast").AddListener(Index.OnTriggerBroadcast);
    }

    private static Button.ButtonClickedEvent OnClick(string name)
    {
        return GameObject.Find(name).GetComponent<Button>().onClick;
    }

    // Update is called once per frame
    void Update()
    {
        // Receiving server messages
        MyNetConfig.Poll();
    }
}