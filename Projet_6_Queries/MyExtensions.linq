<Query Kind="Program">
  <Reference Relative="..\..\..\source\repos\Icanebal\Projet_6\Projet_6\obj\Debug\net9.0\Projet_6.dll">&lt;UserProfile&gt;\source\repos\Icanebal\Projet_6\Projet_6\obj\Debug\net9.0\Projet_6.dll</Reference>
  <Namespace>Projet_6.Models.Dtos</Namespace>
  <Namespace>Projet_6.Models.Entities</Namespace>
</Query>

void Main()
{
	// Write code to test your extensions here. Press F5 to compile and run.
}

public static class MyExtensions
{
		public static IQueryable<TicketDto> ToTicketDto(this IQueryable<Ticket> query)
{
    return query.Select(t => new TicketDto
    {
        TicketId = t.TicketId,
        Produit = t.ProductVersionOperatingSystem.ProductVersion.Product.ProductName,
        Version = t.ProductVersionOperatingSystem.ProductVersion.Number,
        OS = t.ProductVersionOperatingSystem.OperatingSystem.OperatingSystemName,
        CreationDate = t.CreationDate,
        Issue = t.Issue,
        ResolutionDate = t.ResolutionDate,
        Resolution = t.Resolution,
        Statut = t.TicketStatus.Label
    });
}

	    public static IQueryable<Ticket> ApplyFilters(
        this IQueryable<Ticket> query,
        string? statut = null,
        string? produit = null,
        string? version = null,
        DateTime? dateMin = null,
        DateTime? dateMax = null,
        string? motCle = null)
    {
        if (statut != null)
            query = query.Where(t => t.TicketStatus.Label == statut);
        if (produit != null)
            query = query.Where(t => t.ProductVersionOperatingSystem.ProductVersion.Product.ProductName == produit);
        if (version != null)
            query = query.Where(t => t.ProductVersionOperatingSystem.ProductVersion.Number == version);
        if (dateMin.HasValue)
            query = query.Where(t => t.CreationDate >= dateMin.Value);
        if (dateMax.HasValue)
            query = query.Where(t => t.CreationDate <= dateMax.Value);
        if (motCle != null)
            query = query.Where(t => t.Issue.Contains(motCle) || (t.Resolution != null && t.Resolution.Contains(motCle)));
        return query;
    }
	
}

// You can also define namespaces, non-static classes, enums, etc.

#region Advanced - How to multi-target

// The NETx symbol is active when a query runs under .NET x or later.
// (LINQPad also recognizes NETx_0_OR_GREATER in case you enjoy typing.)

#if NET8
// Code that requires .NET 8 or later
#endif

#if NET7
// Code that requires .NET 7 or later
#endif

#if NET6
// Code that requires .NET 6 or later
#endif

#if NETCORE
// Code that requires .NET Core or later
#else
// Code that runs under .NET Framework (LINQPad 5)
#endif

#endregion