/* 
 * Description: 
 * Write, compile, and test a program named Lyrics that displays at least four lines of your favorite song.
 */

using System;
using static System.Console;

class Lyrics
{
    static void Main()
    {
        string artist = "Adele";
        string song = "Someone Like You";

        WriteLine("Artist: " + artist);
        WriteLine("Song: " + song);
        WriteLine();

        WriteLine("I heard that you're settled down");
        WriteLine("That you found a girl and you're married now");
        WriteLine("I heard that your dreams came true");
        WriteLine("Guess she gave you things I didn't give to you");

        // add more lyrics here
    }
}
