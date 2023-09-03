// gamesInvalidFormat.json
var userInteractor = new ConsoleUserInterActor();

var app = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFilerReader());

var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine(
        "Sorry! The application has experienced an unexpected error and will have to be closed");
    logger.Log(ex);
}