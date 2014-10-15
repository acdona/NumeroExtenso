NumeroExtenso
=============

Metodos de extensão ToLongString para Int e Decimal. Escreve números por extenso.<br />
<br />

Decimal: Reais em Extenso <br />
Int: Numeros Cardinais<br />
Double: Numeros Cardinais com Virgula<br />

=============

Exemplos:

Decimal numDecimal = 123.45;<br />
numDecimal.ToLongString(); // cento e vinte e três reais e quarenta e cinco centavos<br />
<br />
int numInteiro = 34;<br />
numInteiro.ToLongString(); // trinta e quatro<br />
<br />
double numDouble = 1230.45;<br />
numDouble.ToLongString(); // um mil duzentros e trinta virgula quarenta e cinco<br />

=============

É possível utilizar outras moedas: "Real", "Real", "Dolar", "Euro", "Libra Esterlina", "Iene"<br />
Com numDecimal.ToLongString(TipoMoeda)<br />
<br />
Suporte apenas para pt-BR.<br />
Criado para: www.contratosnahora.com.br<br />
