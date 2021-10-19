using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float speed = 6f;
    public int debug = 0;


    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    Vector3 m_EulerAngleVelocity;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float turn = Input.GetAxis("Turn") * turnSpeed;
        float walk = Input.GetAxis("Walk") * speed;

        //m_Movement.Set(walk, 0f, turn);
        //m_Movement.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(turn, 0f);
        bool hasVerticalInput = !Mathf.Approximately(walk, 0f);

        //I was goinh to make it so the player stops walking when doing both but couldn't set that up
        bool isWalking = (hasHorizontalInput || hasVerticalInput);

        m_Animator.SetBool("IsWalking", isWalking);

        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }


        //Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        //m_Rotation = Quaternion.LookRotation(desiredForward);
    }

    private void OnAnimatorMove()
    {
        float turn = Input.GetAxis("Turn") * turnSpeed;
        float walk = Input.GetAxis("Walk") * speed;


        // Conditional that stops the player from moving and turning at the same time 
        if (turn != 0)
        {
            m_EulerAngleVelocity = new Vector3(0, turn, 0);

            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }
        else if (walk != 0)
        {
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            m_Rigidbody.velocity = transform.forward * walk;
        }
    }
}
