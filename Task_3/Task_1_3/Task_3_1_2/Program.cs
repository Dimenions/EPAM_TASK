using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"
                Your heart is a diamond
                Every soul wants to steal it
                From your fort of skin
                Your heart is a diamond
                Every soul wants to steal it
                From your fort of skin
                You let nobody in


                Your heart is a diamond
                A bleeding treasurre
                Crushed together by
                Grief and violence
                Tons of pain, big pressure


                Your heart is a diamond
                So hard and cold
                So uncut and so silent
                In a breathing vault


                That's my heart
                Let me help it feel
                That's my heart
                What they all want to steal


                Your heart is a diamond
                Every man wants to steal it
                Deep inside your fort of skin
                You keep yourself concealed
                Good hearts are so hard to find
                I will wait and stay
                A diamond ring will take its place
                Around my soul one day


                That's my heart
                Let me help it feel
                That's my heart
                What they all want to steal



                That's my heart
                Let me work that mine
                That's my heart
                Help me make it shine


                I lick your heart, I taste the pain
                Try your blood it feels the same
                I kiss your skin, your bitter lips
                There is no light
                At the end of the tunnel
                Between your hips


                That's my heart
                Let me help it feel
                That's my heart
                What they all want to steal


                That's my heart
                Let me work that mine
                That's my heart
                Help me make it shine";

            TextAnalizatorHandler.Start(text);
        }
    }
}
