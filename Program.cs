using System.Text;
var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha");
sb.AppendLine("e o fim");

using var sr = new StringReader(sb.ToString());
//mesma coisa que a baixo!
do
{
Console.WriteLine(sr.ReadLine());
}
while (sr.Peek() > 0);


// var buffer = new char[10];
// var tamanho = buffer.Length;
// do
// {
// tamanho = sr.Read(buffer);
// Console.WriteLine($"{string.Join(" ", buffer)}");

// }

// while (tamanho > buffer.Length);
 Console.WriteLine("Digite [enter] para finalizar");
 Console.ReadKey();


