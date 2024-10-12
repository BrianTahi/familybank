public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<UniversityContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    services.AddControllers();
    services.AddSwaggerGen(); // For API documentation
}
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddSwaggerGen();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "XYZ University API V1");
    });

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
