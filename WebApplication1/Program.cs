using HD.Result;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

Product p = new()
{
    Name = "Ayakkab�",
    Description = "K��l�k Deri"
};
Product p2 = new()
{
    Name = "Ti��rt",
    Description = "Yazl�k Pamuklu"
};

app.MapGet("/", () => 
{
    List<string> meesages = new List<string>();
    return Result<Product>.Failure();
});


app.Run();
class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
}