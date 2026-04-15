# Blazor Kanban — CRUD with Custom Adaptor

A sample Blazor application demonstrating how to perform CRUD operations on a Syncfusion Kanban board using a custom data adaptor with the Blazor DataManager.

## Overview

This repository shows how to integrate custom server-side data handling with the Syncfusion Kanban component. The sample uses a custom adaptor to illustrate creating, reading, updating, and deleting cards while syncing changes with a backend data store.

**Online example**: https://blazor.syncfusion.com/demos/kanban/dialog-editing?theme=bootstrap4

## Features

- Server-backed CRUD via a custom `DataManager` adaptor
- Dialog editing for card details
- Demo of create, read, update, and delete workflows

## Prerequisites

- Visual Studio 2022 (or later)
- The .NET SDK required by the solution

## Running the project

1. Clone the repository to a local folder.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages by rebuilding the solution or running `dotnet restore`.
4. Update the backend database connection string or API endpoint in the project configuration as required for your environment.
5. Build and run the project from Visual Studio.

Optional CLI steps:

```powershell
dotnet restore
dotnet build
```

If you want, I can also update the README to include an example connection string placeholder and brief notes about the server endpoints expected by the custom adaptor.