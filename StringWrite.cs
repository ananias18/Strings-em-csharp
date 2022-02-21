string textReaderText = "conjunto das palavras escritas
 em livro folheto documento etc 
popos a comentários aditamentos sumário 
etc redação original de 
qualquer obra escrita
um t manuscrito
trecho ou fragmento de obra de um autor.
o t de Graciliano Ramos"\n\n;

Console.WriteLine($"Texto Original: "textReaderText);
string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha == null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado:{paragrafo}");
int caractereLido;
char caractereConvertido;

var sw = new StringWrite();
sr = new StringReader(paragrafo);

while (true)
{
    caractereConvertido = sr.Read();
    if (caractereLido == -1)
        break;

    caractereConvertido = Convert.ToChar(caractereLido);
    if (caracterLido = '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);

    }
}
Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToStrings()");
    Console.WriteLine("Digite [enter] para finalizar ...");
    Console.ReadLine();



