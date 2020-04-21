using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    public static float EPSILON = 2f;
    public static bool ApproximatelyEqual(float a, float b)
    {
        return Mathf.Abs(a - b) < EPSILON;
    }

    public static float Clamp(float val, float min, float max)
    {
        if (val < min)
        {
            val = min;
        }
        if (val > max)
        {
            val = max;
        }
        return val;
    }

    public static float AngleDiffPosNeg(float a, float b)
    {
        float diff = a - b;
        if (diff > 180)
        {
            return diff - 360;
        }
        if (diff < -180)
        {
            return diff + 360;
        }
        return diff;
    }


    public static float Degrees360(float angleDegrees)
    {
        while (angleDegrees >= 360)
        {
            angleDegrees -= 360;
        }
        while (angleDegrees < 0)
        {
            angleDegrees += 360;
        }
        return angleDegrees;
    }

    public static float AngleOfAttack(Vector3 start, Vector3 finish)
    {

        Vector3 diff = finish - start;
        float angleOfAttack = Mathf.Atan2(diff.x, diff.z);

        //Debug.Log(angleOfAttack + " * " + Mathf.Rad2Deg + " = " + Mathf.Rad2Deg * angleOfAttack);

        return Mathf.Rad2Deg * angleOfAttack;
    }

    public static bool inFollowPosition(Vector3 leaderPos, Vector3 followerPos)
    {

        if (ApproximatelyEqual((Mathf.Abs(leaderPos.x) + 100), followerPos.x))
        {
            if ((leaderPos.z - followerPos.z) < EPSILON)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        return false;
    }

}

