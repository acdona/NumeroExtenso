using System.Text.RegularExpressions;
using System.Globalization;

namespace NumeroExtenso
{
    public enum TiposMoedas
    {
        Desconhecida = 0,
        Real = 1,
        Dollar = 2,
        Euro = 3,
        Libra = 4,
        Iene = 5,
    }

    public static class Moedas
    {
        private static CultureInfo Brazil = CultureInfo.GetCultureInfo("pt-BR");

        private static readonly string[] NomeSingular = { "Real", "Real", "Dolar", "Euro", "Libra Esterlina", "Iene" };
        private static readonly string[] NomePlural = { "Reais", "Reais", "Dolares", "Euros", "Libras Esterlina", "Ienes" };

        private static readonly string[] NomeSimbolos = { "R$", "R$", "US$", "€", "£", "¥" };

        public static string GetSimbolo(TiposMoedas moeda)
        {
            return NomeSimbolos[(int)moeda];
        }

        public static string GetNomeSingular(TiposMoedas moeda)
        {
            return NomeSingular[(int)moeda];
        }

        public static string GetNomePlural(TiposMoedas moeda)
        {
            return NomePlural[(int)moeda];
        }

        public static TiposMoedas GetMoedaFromSymbol(string valor)
        {
            for (int c = 0; c < NomeSimbolos.Length; c++)
            {
                if (valor.Contains(NomeSimbolos[c])) return (TiposMoedas)c;
            }

            return TiposMoedas.Desconhecida;
        }

        //public static decimal CurrencyToDecimal(string valor)
        //{
        //    string replaced = valor;
        //    if (!string.IsNullOrEmpty(replaced))
        //    {
        //        replaced = replaced.Replace(".", "");

        //        // Remove simbolos como: R$ e US$
        //        string toRemove = new Regex(@"^\D+").Match(replaced).Value;
        //        if (!string.IsNullOrEmpty(toRemove))
        //        {
        //            replaced = replaced.Replace(toRemove, "");
        //        }

        //        //// Verifica o formato do numero 1,000,000.00 ou 1.000.000,00

        //        //if (new Regex(@"[0-9]{1,3}((\,[0-9]{3})?)+(.[0-9])?").IsMatch(replaced)) // 1.000.000,00
        //        //{
        //        //    replaced = replaced.Replace(",", "");
        //        //}
        //        //else if (new Regex(@"[0-9]{1,3}((\.[0-9]{3})?)+(,[0-9])?").IsMatch(replaced)) // 1,000,000.00
        //        //{
        //        //    replaced = replaced.Replace(".", "");
        //        //    replaced = replaced.Replace(",", ".");
        //        //}
                
        //    }
        //    return !string.IsNullOrEmpty(replaced) ? decimal.Parse(replaced, NumberStyles.Currency) : 0M;
        //}
    }
}