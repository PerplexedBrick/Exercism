using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        StringBuilder transcriptedToRNA = new StringBuilder();

        if (String.IsNullOrEmpty(nucleotide)) return "";

        foreach (char c in nucleotide)
        {
            char a = c switch
            {
                'G' => 'C',
                'C' => 'G',
                'T' => 'A',
                'A' => 'U',
                 _  => throw new ArgumentException($"{c} is not valid nucleotide in DNA")
            };
            transcriptedToRNA.Append(a);
        }

        return transcriptedToRNA.ToString();
    }
}