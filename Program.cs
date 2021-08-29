using System;
using System.IO;

namespace TxtEdit
{
    class Program
    {
        /// <summary>
        /// Ein Programm, welches eine Txt lesen und schreiben kann
        /// </summary>
        static void Main()
        {
            //Pfad zur Txt zum auslesen
            StreamReader streamReader = new StreamReader("D:/Coding/VSProjects/TxtEdit/Txts/Read.txt");
            //Pfad zur Txt zum schreiben                              //true, damit der Text angefügt und nicht ersetzt wird
            StreamWriter streamWriter = new StreamWriter("D:/Coding/VSProjects/TxtEdit/Txts/Write.txt", true);

            //Inhalt der Txt in Console ausgeben lassen
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
            //Inhalt der Txt schreiben
            //Das \n um in die nächste Zeile zu springen
            streamWriter.WriteLine("\nHallo");
            streamWriter.Close();


            

        }
    }
}
