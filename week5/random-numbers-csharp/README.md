# Random Numbers in C#

Hagahan wuxuu sharxayaa sida tirooyin random ah loogu abuuro C# iyadoo la adeegsanayo `Random`.

## Waxa aad u baahan tahay

- .NET SDK
- Faham aasaasi ah oo C# ah

## Tiro random ah oo dhan

`Random.Next(minValue, maxValue)` wuxuu soo celiyaa tiro integer ah oo ka bilaabmaysa `minValue`, balse aan ku jirin `maxValue`.

```csharp
int number = Random.Shared.Next(1, 101);
Console.WriteLine(number);
```

Tusaalahan wuxuu soo saarayaa tiro u dhexaysa 1 iyo 100. `Random.Shared` waa habka ku habboon ee barnaamijyada casriga ah ee .NET marka la rabo isticmaalka wadaagga ah ee `Random`.

Si tiro looga helo eber ilaa xad aan ku jirin:

```csharp
int number = Random.Shared.Next(10); // 0 ilaa 9
```

## Tiro jajab ah

`NextDouble()` wuxuu soo celiyaa tiro `double` ah oo u dhexaysa 0.0 (ku jirta) iyo 1.0 (aan ku jirin).

```csharp
double fraction = Random.Shared.NextDouble();
Console.WriteLine(fraction);
```

Si loo helo qiime jajab ah oo u dhexeeya xadad kale:

```csharp
double min = 5.0;
double max = 10.0;
double value = min + Random.Shared.NextDouble() * (max - min);
Console.WriteLine(value);
```

## Tusaale dhamaystiran

```csharp
using System;

Console.WriteLine("Tiro random ah: " + Random.Shared.Next(1, 101));
```

Ku kaydi tusaalaha `Program.cs`, dabadeed ka dhex socodsii mashruuc .NET ah:

```sh
dotnet run
```

## Sawirrada

- [Hordhaca random numbers](screenshots/01-random-intro.png)
- [Qaabka Random.Next](screenshots/02-random-next-syntax.png)

Sharaxaadda sawirrada waxay ku jirtaa [screenshots/README.md](screenshots/README.md).

## Xusuusin

`Random` waxaa loogu talagalay tirooyin aan u baahnayn amni. Ha u adeegsan siraha, furayaasha amniga, ama tokens; xaaladahaas isticmaal `System.Security.Cryptography.RandomNumberGenerator`.
