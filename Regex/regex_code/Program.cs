
using System;
namespace  Regexx;

public class Program
{
    public static void Main(String[] args)
    {
        //BadWord bw = new BadWord();
        //bw.removeBadWords();
        //ReplaceMutipleSpaces rms = new ReplaceMutipleSpaces();
        //rms.ReplaceSpace();
        //ExtractAllCapitalisedWords e = new ExtractAllCapitalisedWords();
        //e.ExtractCapital();
        //CurrencyExract c = new CurrencyExract();
        //c.ExtractCurrency();
        //DateExtract d = new DateExtract();
        //d.ExtractDates();
        //FindRepeatedWords f = new FindRepeatedWords();
        //f.RepeatedWords();
        ValidSSN ssn = new ValidSSN();
        Console.Write(ssn.ValidSSNumber());

    }
}