// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Blogging.Tagging;
using Volo.Blogging.Tagging.Dtos;

// ReSharper disable once CheckNamespace
namespace Volo.Blogging;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITagAppService), typeof(TagsClientProxy))]
public partial class TagsClientProxy : ClientProxyBase<ITagAppService>, ITagAppService
{
    public virtual async Task<List<TagDto>> GetPopularTagsAsync(Guid blogId, GetPopularTagsInput input)
    {
        return await RequestAsync<List<TagDto>>(nameof(GetPopularTagsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), blogId },
            { typeof(GetPopularTagsInput), input }
        });
    }
}
