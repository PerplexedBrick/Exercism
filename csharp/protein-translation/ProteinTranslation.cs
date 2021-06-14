using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {

        List<string> codons = new List<string>(); 

        for(int i = 0; i < strand.Length; i += 3)
        {
            string codon = strand.Substring(i, 3);
            if (codon == "UAA" || codon == "UAG" || codon == "UGA") break;
            codons.Add(codon switch
            {
                "AUG" => "Methionine",
                "UUU" => "Phenylalanine",
                "UUC" => "Phenylalanine",
                "UUA" => "Leucine",
                "UUG" => "Leucine",
                "UCU" => "Serine",
                "UCC" => "Serine",
                "UCA" => "Serine",
                "UCG" => "Serine",
                "UAU" => "Tyrosine",
                "UAC" => "Tyrosine",
                "UGU" => "Cysteine",
                "UGC" => "Cysteine",
                "UGG" => "Tryptophan",
                _ => ""
            });
        }


        return codons.ToArray();

    }
}