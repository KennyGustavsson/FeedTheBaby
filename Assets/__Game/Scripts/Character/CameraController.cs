using UnityEngine;

public class CameraController : MonoBehaviour{
    [Header("Camera Option")] 
    [SerializeField] private float smoothening = 3f;
    
    private Transform _playerTrans = null;
    private Transform _camTrans = null;
    private Vector3 _offset = Vector3.zero;
    private float _time = 0;
    
    void Awake()
    {
        _playerTrans = GameManagement.GetPlayer().transform;
        _camTrans = GameManagement.GetMainCamera().transform;
        _offset = _camTrans.position - _playerTrans.position;
    }

    private void Update(){
        _camTrans.position = Vector3.Lerp(_camTrans.position, _playerTrans.position + _offset, 2);
        _time += Time.deltaTime;
    }
}
