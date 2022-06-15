using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public int Health;
    public float Speed;
    public float YIncrement;
    public float MinHeight, MaxHeight;
    public TMP_Text Text;
    
    private Vector2 _targetPos = Vector2.zero;

    private void Start()
    {
        Text.text = Health.ToString();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W)&&_targetPos.y<MaxHeight)
            _targetPos = new Vector2(_targetPos.x, _targetPos.y + YIncrement);
        else if(Input.GetKeyDown(KeyCode.S)&&_targetPos.y>MinHeight)
            _targetPos = new Vector2(_targetPos.x, _targetPos.y - YIncrement);
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        Text.text = Health.ToString();
        if(Health<=0)
            Destroy(gameObject);
    }
}
