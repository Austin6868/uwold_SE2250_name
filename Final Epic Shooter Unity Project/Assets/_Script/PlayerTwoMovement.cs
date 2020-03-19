﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : PlayerMovement
{
    public KeyCode[] combo;
    public int currentIndex = 0;

    // Update is called once per frame
    
	public override void FixedUpdate()
	{

        float x = transform.position.x;
        float y = transform.position.y;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
            if(movement.x == -1 && Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x - 1f, y, transform.position.z);
            
			}
			if(movement.x == 1 && Input.GetKeyDown(KeyCode.Space))
            {
            
                transform.position = new Vector3(x + 1f, y, transform.position.z);
            

            }
			if(movement.y == 1 && Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x, y + 1f, transform.position.z);
            
			}
			if (movement.y == -1 && Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x, y - 1f, transform.position.z);
            }
			}
        

    }

