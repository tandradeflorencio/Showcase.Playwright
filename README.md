# Showcase Playwright

# Run the follow commands in your prompt to:

# Create a new project
dotnet new nunit -n Showcase.Playwright

# Navigate to project folder 
cd .\Showcase.Playwright\

# Add the NUnit nuget package
dotnet add package Microsoft.Playwright.NUnit

# Build the project bin folder
dotnet build

# Install Microsoft Power Shell if not exists yet
winget install --id Microsoft.PowerShell --source winget

# Navigate to current .Net Version bin folder
cd .\bin\Debug\net8.0\

# To install Chromium, Firefox and WebKit
.\playwright.ps1 install

# Run the tests
dotnet test -- NUnit.NumberOfTestWorkers=5














