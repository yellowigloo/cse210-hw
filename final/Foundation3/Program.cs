using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lect = new Lecture();
        lect.SetTitle("Man and Beast");
        lect.SetDescription("A lecture on man's wanderings in the wilderness");
        lect.SetDate("4/30");
        lect.SetTime("4:15");
        lect.SetSpeaker("James Adams");
        lect.SetTopic("History and Biology");
        Address addy1 = new Address();
        addy1.SetCity("Austin");
        addy1.SetStreet("1232 Rodeo Dr.");
        lect.SetAddress(addy1);
        lect.DisplayStdDetails();
        lect.DisplayFullDets();
        lect.DisplayShortDescript();

        OutdoorGath outGath = new OutdoorGath();
        outGath.SetTitle("Woods Talk");
        outGath.SetDescription("Just vibing in the woods");
        outGath.SetDate("4/20");
        outGath.SetTime("12:00");
        outGath.SetType("Nature Vibes");
        outGath.SetDress("Hippie");
        Address addy2 = new Address();
        addy2.SetCity("Dallas");
        addy2.SetStreet("3254 Ball St.");
        outGath.SetAddress(addy2);
        outGath.DisplayStdDetails();
        outGath.DisplayFullDets();
        outGath.DisplayShortDescript();

        Reception recept = new Reception();
        recept.SetTitle("A Wonderful Wedding");
        recept.SetDescription("Two who love are joined");
        recept.SetDate("3/21");
        recept.SetTime("3:00");
        recept.SetCouple("Jones/Adams");
        Address addy3 = new Address();
        addy3.SetCity("Portland");
        addy3.SetStreet("4352 Stone St.");
        recept.SetAddress(addy3);
        recept.DisplayStdDetails();
        recept.DisplayFullDets();
        recept.DisplayShortDescript();
    }
}