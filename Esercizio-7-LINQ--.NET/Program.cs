//Se voglio solo 1 articolo e voglio assicurarmi che sia l'unico articolo con quel valore,
//quale uso tra  FirstOrDefault e SingleOrDefault

//FirstOrDefault
//Questo metodo restituisce il primo elemento da una
//raccolta che soddisfa una condizione specificata o
//un valore predefinito se non viene trovato alcun elemento di questo tipo

int[] num = { 1, 5, 4, 8, 9, 10 };
int firstNum = num.FirstOrDefault( x => x % 2 == 0);
Console.WriteLine(firstNum);

//SingleOrDefault
//Questo metodo restituisce l'unico elemento nell'array che soddisfa la condizione.
//Se fossero presenti più elementi con il valore 3 o se nessun elemento corrispondesse alla condizione,
// si generebbe una condizione
int uniqueNum = num.SingleOrDefault( x => x == 1);
Console.WriteLine(uniqueNum);   