<Query Kind="Statements">
  <Connection>
    <ID>d6fbb9a8-2982-48c9-bb1b-3ee6e8d84cef</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPathEncoded>&lt;UserProfile&gt;\source\repos\Icanebal\Projet_6\Projet_6\bin\Debug\net9.0\Projet_6.dll</CustomAssemblyPathEncoded>
    <CustomTypeName>Projet_6.Data.AppDbContext</CustomTypeName>
    <CustomCxString>Server=(localdb)\mssqllocaldb;Database=aspnet-Projet_6;Trusted_Connection=True;MultipleActiveResultSets=true</CustomCxString>
    <DisplayName>Bdd_Projet_6</DisplayName>
    <DriverData>
      <UseDbContextOptions>true</UseDbContextOptions>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

// Paramètres
string statut = "in_progress";
string produit = "Trader en Herbe";

Tickets
    .ApplyFilters(statut, produit, null, null, null, null)
    .ToTicketDto()
    .Dump();



