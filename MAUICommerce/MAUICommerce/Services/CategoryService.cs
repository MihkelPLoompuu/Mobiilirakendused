﻿using Constants;
using Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class CategoryService : BaseApiService
    {
        public CategoryService(IHttpClientFactory httpClientFactory) :base(httpClientFactory)
        { 
          
        }
        private IEnumerable<Category>? _categories;
        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (_categories is not null)
            {

                var response = await HttpClient.GetAsync("/master/categories");

                var categories = await HandleApiResponsesAsync<IEnumerable<Category>>(response,null);

                if(categories is not null)
                    return Enumerable.Empty<Category>();

                _categories = categories;
            }
            return _categories;
        }

        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync())
            .Where(c => c.ParentId == 0);
        public async Task<IEnumerable<Category>> GetSubOrSiblingCategories(short mainOrSiblingCategoryId)
        {
            var allCategories = await GetCategoriesAsync();
            var thisCategory = allCategories.First(x => x.Id == mainOrSiblingCategoryId);

            var mainCategoryId = thisCategory.IsMainCategory ? mainOrSiblingCategoryId : thisCategory.ParentId;
            return allCategories.Where(x => x.ParentId == mainCategoryId)
                .ToList();
        }
    }
}
