using System;
using CommandLine;

namespace Factory
{
    class Program
    {
        public class Options
        {
            [Option('t', "type", Required = true, HelpText = "Choose the president type")]
            public string Type { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
              .WithParsed(RunOptions);

            static void RunOptions(Options opts)
            {
                Factory.CreatePresident(opts.Type);
            }
            Console.ReadKey();
        }
    }

    
    public class Factory
    {
        public static President CreatePresident(string type)
        {
            switch(type)
            {
                case "Venal":
                    return new Venal();
                    break;
                case "Indecis":
                    return new Indecis();
                    break;
                case "Fou":
                    return new Fou();
                    break;
                case "Prophiteur":
                    return new Prophiteur();
                    break;
                case "Psychopathe":
                    return new Psychopathe();
                    break;
                case "Xenophobe":
                    return new Xenophobe();
                    break;
                default:
                    Console.WriteLine("Enter a valid president choice, bitch");
                    Console.WriteLine("You've got the following options, bitch");
                    Console.WriteLine("\t Venal");
                    Console.WriteLine("\t Indecis");
                    Console.WriteLine("\t Fou");
                    Console.WriteLine("\t Prophiteur");
                    Console.WriteLine("\t Psychopathe");
                    Console.WriteLine("\t Xenophobe");
                    type = Console.ReadLine();
                    return CreatePresident(type);
                    break;
            }
        }
    }
    public abstract class President
    {
        public abstract string Slogan { get; }
    }

    public class Venal : President
    {
        public override string Slogan => "I'm gonna sell my ass for a penny. I simply like this shit";

        public Venal ()
        {
            Console.WriteLine(Slogan);
        }
    }

    public class Indecis : President
    {
        public override string Slogan => "I don't fucking know what to say";

        public Indecis()
        {
            Console.WriteLine(Slogan);
        }
    }

    public class Fou : President
    {
        public override string Slogan => "I'm a Crazy piece of shit";

        public Fou()
        {
            Console.WriteLine(Slogan);
        }
    }

    public class Prophiteur : President
    {
        public override string Slogan => "I'm a Cunning piece of shit";

        public Prophiteur()
        {
            Console.WriteLine(Slogan);
        }
    }

    public class Psychopathe : President
    {
        public override string Slogan => "I'm crazy as fuck. I'm gonna suck your cock and then beat the shit out of you!";

        public Psychopathe()
        {
            Console.WriteLine(Slogan);
        }
    }

    public class Xenophobe : President
    {
        public override string Slogan => "I'm a Xenophobe piece of shit";

        public Xenophobe()
        {
            Console.WriteLine(Slogan);
        }
    }
}
