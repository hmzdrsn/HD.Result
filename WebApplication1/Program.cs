using HD.Result;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

Product p = new()
{
    Name = "Ayakkabý",
    Description = "Kýþlýk Deri"
};
Product p2 = new()
{
    Name = "Tiþört",
    Description = "Yazlýk Pamuklu"
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