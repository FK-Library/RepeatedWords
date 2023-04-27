// See https://aka.ms/new-console-template for more information


/*
 * I assumed we just want a list of repeated words in the given paragraph , list s not sitinct and we dont want the number of occurance
 * Also you have given me the clean text without different delimiters or ' , otherwise I would have tried to clean the text
 * I forgot to ask if should i write test or not 
 * 
 * What Im planning:
 * have a list that being filled with non repeated words and another list that holds repeated words
 * In this way I looping in the smaller list of non repeated words which are gradually increasing.
 * 
 * I thought of that, but then I though how about using dictionary after spliting and converting to array.
 * I assumed the lower and capital cases are same so used .ToLower() in comparison
 */

var paragraph = "I have started working as Software Engineer in the UK since 2014 and mainly in backend and after I graduated with commendation in MSc Software Engineering from University of Hertforshire. I like exploring different languages and technologies. I am enjoying working with my team to solve problems and enjoy accomplishing objectives together";

var arrayofParagraph = paragraph.Split(' ').ToArray();

var dict = new Dictionary<string, int>();

for (int i = 0; i < arrayofParagraph.Length; i++)
{
    if (dict.ContainsKey(arrayofParagraph[i].ToLower()))
    {
        dict[arrayofParagraph[i].ToLower()]++;
    }
    else
    {
        dict.Add(arrayofParagraph[i].ToLower(), 1);
    }
}

Console.WriteLine($"Paragraph:\n {paragraph} \n");
Console.WriteLine("Occurrence of each word in the paragraph \n");
foreach (var item in dict)
{
    Console.WriteLine($"Word in paragraph: {item.Key} - reated x {item.Value}");
}
