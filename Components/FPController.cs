using System;

using UnityEngine;

namespace LiarsBarEnhance.Components;

public class FpController : MonoBehaviour
{
    private PlayerStats _playerStats;
    private CharController _charController;
    private readonly float _acceleration = 10f;
    private readonly float _deceleration = 100f;
    private readonly float _bodySpeed = 5f;
    private Vector3 _headSpeed;
    private Vector3 _initHeadPosition;
    private Vector3 _initBodyPosition;
    private Quaternion _initBodyRotation;

    public void Start()
    {
        _charController = GetComponent<CharController>();
        _playerStats = GetComponent<PlayerStats>();
        _initHeadPosition = _charController.HeadPivot.transform.localPosition;
        _initBodyPosition = _charController.transform.localPosition;
        _initBodyRotation = _charController.transform.localRotation;
    }

    public void Update()
    {
        if (!_charController.isOwned)
            return;

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            _charController.HeadPivot.transform.localPosition = _initHeadPosition;
            _charController.transform.localRotation = _initBodyRotation;
            _charController.transform.localPosition = _initBodyPosition;
        }

        _headSpeed.z = _headSpeed.z > 0 ?
            Mathf.Max(0, _headSpeed.z - (Input.GetKey(KeyCode.LeftArrow) ^ Input.GetKey(KeyCode.RightArrow) ? 0f : _deceleration * Time.deltaTime)) :
            Mathf.Min(0, _headSpeed.z + (Input.GetKey(KeyCode.LeftArrow) ^ Input.GetKey(KeyCode.RightArrow) ? 0f : _deceleration * Time.deltaTime));

        _headSpeed.x = _headSpeed.x > 0 ?
            Mathf.Max(0, _headSpeed.x - (Input.GetKey(KeyCode.UpArrow) ^ Input.GetKey(KeyCode.DownArrow) ? 0f : _deceleration * Time.deltaTime)) :
            Mathf.Min(0, _headSpeed.x + (Input.GetKey(KeyCode.UpArrow) ^ Input.GetKey(KeyCode.DownArrow) ? 0f : _deceleration * Time.deltaTime));

        _headSpeed.z += (Input.GetKey(KeyCode.LeftArrow) ? 1 : 0) * _acceleration * Time.deltaTime;
        _headSpeed.z -= (Input.GetKey(KeyCode.RightArrow) ? 1 : 0) * _acceleration * Time.deltaTime;

        _headSpeed.x += (Input.GetKey(KeyCode.DownArrow) ? 1 : 0) * _acceleration * Time.deltaTime;
        _headSpeed.x -= (Input.GetKey(KeyCode.UpArrow) ? 1 : 0) * _acceleration * Time.deltaTime;

        _charController.HeadPivot.transform.Translate(_headSpeed * Time.deltaTime, Space.Self);

        if (Input.GetMouseButton(2))
        {
            var delta = Input.GetAxis("Mouse Y");
            _charController.HeadPivot.transform.Translate(delta * Vector3.up, Space.Self);
        }


        if (_playerStats.HaveTurn)
            return;

        if (Input.GetKey(KeyCode.W))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.forward, Space.Self);
        if (Input.GetKey(KeyCode.S))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.back, Space.Self);
        if (Input.GetKey(KeyCode.A))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.left, Space.Self);
        if (Input.GetKey(KeyCode.D))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.right, Space.Self);
        if (Input.GetKey(KeyCode.LeftShift))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.up, Space.Self);
        if (Input.GetKey(KeyCode.LeftControl))
            _charController.transform.Translate(_bodySpeed * Time.deltaTime * Vector3.down, Space.Self);
    }
}