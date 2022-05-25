using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription()
        {
            string description = "";

        }
        if(ShininessLevel<2){
            description = "dull";
        }
        else if(ShininessLevel <= 5 && ShininessLevel >=2)
        {  description= "noticeable";
        }
        else if (ShininessLevel >= 6 && ShininessLevel =< 9)
    description = "bright";
        }
        else
{
    ShininessLevel > 9
        description = "blinding";
}
return description;
}
