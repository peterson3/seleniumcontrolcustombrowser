using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SeleniumControlCustomBrowser
{
    public class ProfilerGenerator
    {
        public Faker<Pessoa> _faker;

        public ProfilerGenerator()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;


            var dataNames = new NameFromFileReader().GetNameFromFile().OrderByDescending(x => x.frequency_total).ToList();
            var maleDataNames = dataNames.Where(x => x.Sex == 'M').ToList();
            var femaleDataNames = dataNames.Where(x => x.Sex == 'F').ToList();

            _faker = new Faker<Pessoa>("pt_BR")
                .RuleFor(p => p.Sexo, f => f.Person.Gender.ToString().First())
                .RuleFor(p => p.FirstName, (f, p) =>
                {
                    if (p.Sexo == 'M')
                    {
                        Random r = new Random();
                        int sorteado = r.Next(0, maleDataNames.Count);

                        return textInfo.ToTitleCase(maleDataNames.ElementAt(sorteado).group_name.ToLower());
                    }
                    else
                    {
                        Random r = new Random();
                        int sorteado = r.Next(0, femaleDataNames.Count);

                        return textInfo.ToTitleCase(femaleDataNames.ElementAt(sorteado).group_name.ToLower());                    }
                })
                .RuleFor(p => p.LastName, (f, p) =>
                {
                    return f.Person.LastName;
                })
                .RuleFor(p => p.Nome, (f,p) =>
                {
                    return p.FirstName + " " + p.LastName;
                })
                .RuleFor(p => p.UserName, (f, p) => f.Internet.UserName(p.FirstName, p.LastName))
                .RuleFor(p => p.Senha, f => f.Internet.PasswordCustom())
                .RuleFor(p => p.Proxy, f => f.Internet.WebShareProxyCustom())
                .RuleFor(p => p.DataNascimento, f => f.Person.DateOfBirth)
                .RuleFor(p => p.Number, f => new getOrBanNumberResponse())
                .RuleFor(p => p.Cidade, f => f.Address.City());
        }


        public Pessoa Generate() 
        {
            return _faker.Generate();
        }

        public IEnumerable<Pessoa> Generate(int quantidade)
        {
            return _faker.Generate(quantidade);
        }

    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Sexo { get; set; }
        public string Senha { get; set; }
        public Proxy Proxy {get; set;}
        public DateTime DataNascimento { get; set; }
        public getOrBanNumberResponse Number { get; set; }
        public string Cidade { get; internal set; }
    }

    public static class MyExtensions
    {
        public static string PasswordCustom(this Internet internet)
        {

            var r = internet.Random;

            var number = r.Replace("#");  // length 1
            var letter = r.Replace("?");  // length 2
            var lowerLetter = letter.ToLower(); //length 3
            var symbol = r.Char((char)33, (char)47); //length 4 - ascii range 33 to 47

            var padding = r.String2(r.Number(2, 6)); //length 6 - 10

            return new string(r.Shuffle(number + letter + lowerLetter + symbol + padding).ToArray());
        }


        public static Proxy WebShareProxyCustom(this Internet internet)
        {
            ProxyWebShareIO _proxyintegration = new ProxyWebShareIO();
            var proxyList = _proxyintegration.GetProxyList();

            Random r = new Random();
            var randomNumber=  r.Next(0, proxyList.results.Count);

            return proxyList.results.ElementAt(randomNumber);

        }

        //public static String NameCustom(this Person pessoa)
        //{
        //}
    }
}
