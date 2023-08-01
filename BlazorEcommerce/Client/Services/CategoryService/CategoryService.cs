﻿namespace BlazorEcommerce.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<Category> Categories { get; set; } = new();

    public async Task GetCategories()
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
        if (result is not null && result.Data is not null)
            Categories = result.Data;
    }
}
