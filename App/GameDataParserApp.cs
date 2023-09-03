public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;

    public GameDataParserApp(IUserInteractor userInteractor, IGamesPrinter gamesPrinter,
        IVideoGamesDeserializer videoGamesDeserializer, IFileReader fileReader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = fileReader;
    }

    public void Run()
    {
        var fileName = _userInteractor.ReadValidFilePath();
        var fileContents = _fileReader.Read(fileName);
        var videoGames = _videoGamesDeserializer.DeserializeVideoGamesFrom(fileContents, fileName);
        _gamesPrinter.Print(videoGames);
    }
}