using UnityEngine;

public class Singleton <T>: MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get {
            if (_instance == null)
            {
                // 이미 해당 Type의 Object가 있는지 찾아서 할당하고,
                _instance = FindAnyObjectByType<T>(); 

                // 그래도 없으면 새로 생성
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();
                }
            }

            return _instance;
        }
    }


    public virtual void Awake()
    {
        // Instance를 get하지 않았을 때, 초기화되지 않았으므로 할당하는 부분을 넣어준다.
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
