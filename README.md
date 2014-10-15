NumeroExtenso
=============

Metodos de extensão ToLongString para Int e Decimal. Escreve números por extenso.


Decimal: Reais em Extenso
Int: Numeros Cardinais
Double: Numeros Cardinais com Virgula

=============

Exemplos:

Decimal numDecimal = 123.45;
numDecimal.ToLongString(); // cento e vinte e três reais e quarenta e cinco centavos

int numInteiro = 34;
numInteiro.ToLongString(); // trinta e quatro

double numDouble = 1230.45;
numDouble.ToLongString(); // um mil duzentros e trinta virgula quarenta e cinco

=============

É possível utilizar outras moedas: "Real", "Real", "Dolar", "Euro", "Libra Esterlina", "Iene"
Com numDecimal.ToLongString(TipoMoeda)

Suporte apenas para pt-BR.
Criado para: www.contratosnahora.com.br
