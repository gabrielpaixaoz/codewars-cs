using System;
using System.Linq;


class Program { 
    static void Main()
    {
        string input = "testando";
        string result = Kata.Disemvowel(input);
        Console.WriteLine(result);
    }

}
public static class Kata
{
    public static string Disemvowel(string str)
    {
        string vowels = "aeiouAEIOU";

        string output = new string(str.Where(c => !vowels.Contains(c)).ToArray());

        return output;
    }

    

}

/* str.Where(...)
str: Aqui, str é a string que você está processando. Por exemplo, se str for "testando", estamos começando com essa string.

.Where(...): O método Where é um método de extensão do LINQ que filtra uma coleção, retornando apenas os elementos que atendem a uma condição específica. No contexto de uma string, Where trata a string como uma coleção de caracteres.

2. c => !vowels.Contains(c)
c: Este é um parâmetro que representa cada caractere da string str enquanto o método Where itera sobre ela.

!vowels.Contains(c):

vowels é uma string que contém todas as vogais que queremos remover (por exemplo, "aeiouAEIOU").
vowels.Contains(c) verifica se o caractere c está presente na string vowels.
O operador ! nega essa condição. Portanto, !vowels.Contains(c) será true se c não for uma vogal.
Resultado: O método Where retornará apenas os caracteres para os quais a condição !vowels.Contains(c) é verdadeira, ou seja, todos os caracteres que não são vogais.

3. .ToArray()
.ToArray(): Após o método Where filtrar os caracteres, o resultado é uma coleção de caracteres (IEnumerable<char>). O método ToArray() converte essa coleção em um array de caracteres (char[]).
4. new string(...)
new string(...): O construtor new string(...) é usado para criar uma nova string a partir de um array de caracteres.

Argumento: O array de caracteres que foi criado pelo ToArray() é passado como argumento para o construtor string. Isso resulta em uma nova string que contém apenas os caracteres que não são vogais.

Resumo Completo
Portanto, essa linha de código realiza as seguintes etapas:

Filtra os caracteres da string original (str) para manter apenas aqueles que não estão na string vowels (ou seja, não são vogais).
Converte a coleção filtrada de caracteres em um array de caracteres.
Cria uma nova string a partir desse array de caracteres filtrados.
Exemplo Prático
Vamos considerar um exemplo prático para ilustrar:

Suponha que str seja "testando" e vowels seja "aeiouAEIOU".

str.Where(...): A função Where verifica cada caractere:

't' → não é uma vogal → mantido
'e' → é uma vogal → descartado
's' → não é uma vogal → mantido
't' → não é uma vogal → mantido
'a' → é uma vogal → descartado
'n' → não é uma vogal → mantido
'd' → não é uma vogal → mantido
'o' → é uma vogal → descartado
O resultado após Where será {'t', 's', 't', 'n', 'd'}.

ToArray(): Isso converte a coleção em um array: ['t', 's', 't', 'n', 'd'].

new string(...): Isso cria a string "tstnd".

Assim, a variável output terá o valor "tstnd" após a execução dessa linha de código. */
