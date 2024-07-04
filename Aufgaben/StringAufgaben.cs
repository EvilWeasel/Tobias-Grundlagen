using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
  internal class StringAufgaben
  {
    /// <summary>
    /// Drucke den gegeben Text rückwärts, wobei jedes Zeichen mit einem Leerzeichen getrennt sein soll.
    /// Input: "Lagerregal"
    /// Output: "l a g e r r e g a L"
    /// Input: "Hamster"
    /// Output: "r e t s m a H"
    /// </summary>
    /// <param name="text"></param>
    internal static void PrintBackwards(string text) { }

    /// <summary>
    /// Eine Funktion, welche die Anzahl von Worten in einer beliebigen Zeichenkette zählt.
    /// Ein Wort besteht aus mehreren zusammenhängenden Buchstaben und werden mit Leerzeichen voneinander getrennt.
    /// Input: "Hier könnte Ihre Werbung stehen!"
    /// Output: 5
    /// Input: "lorem ipsum dolor est"
    /// Ouput: 4
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    internal static int CountWords(string text) { return 0; }

    /// <summary>
    /// Eine Funktion, welche die Anzahl an Buchstaben des letzten Wortes des Textes zurückgibt.
    /// <param name="text">Eine beliebig lange Sequenz an Text</param>
    /// <list type="bullet">
    /// <item>
    /// Input: "Mein Hamster hat meine Hausis gefressen"
    /// Output: 9
    /// </item>
    /// <item>
    /// Input: "Döner mit Scharf"
    /// Output: 6
    /// </item>
    /// </list>
    /// <returns>Die Anzahl an Buchstaben im letzten Wort als Int</returns>
    /// </summary>
    internal static int CountCharsOfLastWordInText(string text) { return 0; }

    /// <summary>
    /// Eine Funktion, welche einen beliebigen Text als Input bekommt und in der Konsole die Anzahl an Vokalen und Konsonanten anzeigt.
    /// Input: "Buxtehude"
    /// Output: Anzahl Vokale: 4
    ///         Anzahl Konsonanten: 5
    /// Input: "lorem ipsum dolor est"
    /// Output: Anzahl Vokale: 7
    ///         Anzahl Konsonanten: 11
    /// 
    /// HINT: Sind Leerzeichen Vokale oder Konsonanten?
    /// </summary>
    /// <param name="text"></param>
    internal static void PrintConsonantAndVowels(string text) { }


  }
}
