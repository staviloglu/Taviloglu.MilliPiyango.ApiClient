# Taviloglu.MilliPiyango.ApiClient
.NET Client for downloading and checking results of Milli Piyango Lotteries (Turkey’s National Lottery Administration).

## Usage [![NuGet](https://img.shields.io/nuget/v/Taviloglu.MilliPiyango.ApiClient.svg)](https://www.nuget.org/packages/Taviloglu.MilliPiyango.ApiClient/) [![NuGet Downloads](https://img.shields.io/nuget/dt/Taviloglu.MilliPiyango.ApiClient.svg)](https://www.nuget.org/packages/Taviloglu.MilliPiyango.ApiClient/)

### Get Result from web
```csharp
var milliPiyangonClient = new MilliPiyangoApiClient();
var onNumaraResult = milliPiyangonClient.OnNumara.GetResult(new DateTime(2018, 10, 15));
```
### Get Result and save to a file
```csharp
var milliPiyangonClient = new MilliPiyangoApiClient();
var onNumaraResult = milliPiyangonClient.OnNumara.GetResult(new DateTime(2018, 10, 15), "onnumara-20181015.json");
```

### Get Result from file
```csharp
var milliPiyangonClient = new MilliPiyangoApiClient();
var onNumaraResult = milliPiyangonClient.GetResultFromFile<LotoResult>("onnumara-20181015.json");
```

### Get Prize 
Download result once and check many guesses
```csharp
var milliPiyangonClient = new MilliPiyangoApiClient();
var onNumaraResult = milliPiyangonClient.OnNumara.GetResult(new DateTime(2018, 10, 15));
var onNumaraPrize = milliPiyangonClient.OnNumara.GetPrize(onNumaraResult, new OnNumaraGuess(new List<int> { 1, 8, 14, 24, 25, 35, 41, 9, 10, 11 }));
```
### Get Prize (extension)
You can use the GetPrize extension without passing Result object. (Downloads the result each time you call this function)
```csharp
var milliPiyangonClient = new MilliPiyangoApiClient();
var onNumaraPrize = milliPiyangonClient.OnNumara.GetPrize(new DateTime(2018, 10, 15), new OnNumaraGuess(new List<int> { 1, 8, 14, 24, 25, 35, 41, 9, 10, 11 }));
```
