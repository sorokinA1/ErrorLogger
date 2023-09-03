public interface IVideoGamesDeserializer
{
    public List<VideoGame> DeserializeVideoGamesFrom(string fileContents, string fileName);
}