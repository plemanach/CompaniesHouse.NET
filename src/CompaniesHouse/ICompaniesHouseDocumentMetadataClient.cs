﻿using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.DocumentMetadata;

namespace CompaniesHouse
{
    public interface ICompaniesHouseDocumentMetadataClient
    {
        Task<CompaniesHouseClientResponse<DocumentMetadata>> GetDocumentMetadataAsync(string documentId, CancellationToken caneCancellationToken = default);
    }
}