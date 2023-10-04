using System;
using System.Collections.Generic;

public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string str in input)
        {
            if (IsNumeroTelefonoItaliano(str))
            {
                return str;
            }
        }

        return string.Empty;
    }

    private static bool IsNumeroTelefonoItaliano(string str)
    {
        // Rimuovi gli spazi e i caratteri di punteggiatura dalla stringa
        string cleanedStr = RemoveSpacesAndPunctuation(str);

        // Verifica se la stringa inizia con +39 ed è lunga 13 caratteri
        if (cleanedStr.StartsWith("+39") && cleanedStr.Length == 13)
        {
            return true;
        }
        // Verifica se la stringa inizia con 0039 ed è lunga 14 caratteri
        if (cleanedStr.StartsWith("0039") && cleanedStr.Length == 14)
        {
            return true;
        }
        // Verifica se la stringa inizia con 3 ed è lunga 10 caratteri
        if (cleanedStr.StartsWith("3") && cleanedStr.Length == 10)
        {
            return true;
        }

        return false;
    }

    private static string RemoveSpacesAndPunctuation(string str)
    {
        // Rimuovi gli spazi e i caratteri di punteggiatura dalla stringa
        string cleanedStr = string.Empty;
        foreach (char c in str)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                cleanedStr += c;
            }
        }
        return cleanedStr;
    }
}
