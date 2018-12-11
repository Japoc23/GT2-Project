using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDistanceLookup {

	public static float getTimer(string nameCurrent, string nameNext) {
        float r = 0;
        if(nameCurrent == "BasicBlockLeft")
        {
            if (nameNext == "BasicBlockRight") r = 1.5f;
            if (nameNext == "BasicBlockLeft") r = 1.7f;
            if (nameNext == "BasicBlockMiddle") r = 1.6f;
        }

        if (nameCurrent == "BasicBlockRight")
        {
            if (nameNext == "BasicBlockLeft") r = 1.5f;
            if (nameNext == "BasicBlockRight") r = 1.7f;
            if (nameNext == "BasicBlockMiddle") r = 1.6f;
        }

        if (nameCurrent == "BasicBlockMiddle")
        {
            if (nameNext == "BasicBlockLeft") r = 1.6f;
            if (nameNext == "BasicBlockRight") r = 1.6f;
            if (nameNext == "BasicBlockMiddle") r = 1.1f;
        }
        if (r == 0)
        {
            r = 2f;
        }
        float multiplier = 1f;
        if (!globalVariables.lessDistance)
        {
            multiplier = 1.5f;
        }
        return r * multiplier;
    }
}
