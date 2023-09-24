namespace TheCashier.Config;
public class DB
{
    public string? Server { get; init; }
    public string? Uid { get; init; }
    public string? Pwd { get; init; }
    public string? DataBase { get; init; }
    public string ConnectionString => $"server={Server};uid={Uid};pwd={Pwd};database={DataBase}";
}
